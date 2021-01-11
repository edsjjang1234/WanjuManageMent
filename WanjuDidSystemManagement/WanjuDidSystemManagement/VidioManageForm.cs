using LogLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WanjuDidSystemManagement
{
    public partial class VidioManageForm : Form
    {
        OpenFileDialog openFileDialog;
        csNetDrive csNetDrive;
        XmlRead xmlRead;
        public VidioManageForm()
        {
            InitializeComponent();
            csNetDrive = new csNetDrive();
            xmlRead = new XmlRead();
            VidioListInit();
            SetDidSystemIpAddress();
        }

        private void SetDidSystemIpAddress()
        {
            try
            {
                string ip = ConfigurationManager.AppSettings["DIDip"];
                string[] ipArray;
                ipArray = ip.Split('.');

                ipFTxt.Text = ipArray[0];
                ipMTxt.Text = ipArray[1];
                ipLTxt.Text = ipArray[2];
                ipLLTxt.Text = ipArray[3];
            }
            catch(Exception ex)
            {
                WriteLog.WriteLogger(ex.ToString());
            }
        }

        private void VidioListInit()
        {
            vidioListView.View = View.Details;           //컬럼형식으로 변경
            vidioListView.FullRowSelect = true;          //Row 전체 선택
            vidioListView.Columns.Add("No", 30);
            vidioListView.Columns.Add("동영상 이름", 250);

            VidioAddToList();
        }

        private void VidioAddToList()
        {
            string ip = ConfigurationManager.AppSettings["DIDip"];
            string[] fileName;
            int tt = csNetDrive.setRemoteConnection(@"\\"+ ip +"\\Videos", "test", "1234", "Y");//공유 폴더 전송 테스트
            try
            {

                fileName = Directory.GetFiles(@"\\" + ip + "\\Videos");
                if (fileName.Length > 0)
                {
                    vidioListView.BeginUpdate();

                    
                    for (int i = 0; i < fileName.Length; i++)
                    {
                        ListViewItem lvItem = new ListViewItem(Convert.ToString(i+1));
                        lvItem.SubItems.Add(Path.GetFileName(fileName[i]));
                        vidioListView.Items.Add(lvItem);
                    }
                   

                    vidioListView.EndUpdate();
                }
            }catch(Exception ex)
            {
                WriteLog.WriteLogger(ex.ToString());
            }
            csNetDrive.CencelRemoteServer("Y:"); //공유폴더연결 닫음
        }
        private void DrawGroupBox(GroupBox box, Graphics g, Color textColor, Color borderColor)
        {
            if (box != null)
            {
                Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(borderColor);
                Pen borderPen = new Pen(borderBrush);
                SizeF strSize = g.MeasureString(box.Text, box.Font);
                Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                               box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                               box.ClientRectangle.Width - 1,
                                               box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                // Clear text and border
                g.Clear(this.BackColor);

                // Draw text
                g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);

                // Drawing Border
                //Left
                g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                //Right
                g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Bottom
                g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Top1
                g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
                //Top2
                g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
            }
        }

        private void vidioGroupBox_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.Black, Color.Black);
        }

        private void vidioDeleteBTn_Click(object sender, EventArgs e)
        {
            string ip = ConfigurationManager.AppSettings["DIDip"];
            int tt = csNetDrive.setRemoteConnection(@"\\" + ip + "\\Videos", "test", "1234", "Y");//공유 폴더 전송 테스트
            try
            { 
                if (MessageBox.Show("동영상을 삭제 하시겠습니까?", "경고", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                   == DialogResult.OK)
                {
                    int rowIndex = vidioListView.SelectedItems[0].Index;
                    string fileName = vidioListView.Items[rowIndex].SubItems[1].Text;

                    //string path = @"\\" + ip + "\\Videos" + "\\" + fileName;
                    VidioDelete(@"\\"+ip+"\\Videos"+ "\\"+ fileName);

                    MessageBox.Show("동영상이 삭제 되었습니다.");
                }
                vidioListView.Items.Clear();
                VidioAddToList();
            }
            catch(Exception ex)
            {
                WriteLog.WriteLogger(ex.ToString());
            }
            csNetDrive.CencelRemoteServer("Y:"); //공유폴더연결 닫음
        }

        private void VidioDelete(string filePath)
        {
            //DirectoryInfo dir = new DirectoryInfo(filePath);
            //System.IO.FileInfo[] files = dir.GetFiles("*.*", SearchOption.AllDirectories);
           // FileInfo fileInfo = new FileInfo(filePath);
            try
            {
                FileInfo fileInfo = new FileInfo(filePath);  
                fileInfo.Delete();
                //foreach (System.IO.FileInfo file in files)
                //{
                //    string name = filePath + "\\" + file.Name;
                //    fileInfo = new FileInfo(name);
                //    file.Attributes = FileAttributes.Normal;
                //    fileInfo.Delete();
                //}
            }
            catch(Exception ex) { WriteLog.WriteLogger(ex.ToString()); }
        }

        private void vidioSaveBtn_Click(object sender, EventArgs e)
        {
            VidioFileSave();
            vidioListView.Items.Clear();
            VidioAddToList();
        }

        private void VidioFileSave()
        {
            string ip = ConfigurationManager.AppSettings["DIDip"];
            int tt = csNetDrive.setRemoteConnection(@"\\" + ip + "\\Videos", "ANYTEK", "0000", "Y");//공유 폴더 전송 테스트
            try
            {
                if (MessageBox.Show("동영상을 저장 하시겠습니까?", "경고", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                  == DialogResult.Cancel)
                    return;

                DirectoryInfo dir = new DirectoryInfo(@"\\"+ ip+"\\Videos");
                System.IO.FileInfo[] files = dir.GetFiles("*.*", SearchOption.AllDirectories);

                DirectoryInfo di = new DirectoryInfo(@"\\" + ip + "\\Videos");
                if (!di.Exists) Directory.CreateDirectory(@"\\" + ip + "\\Videos");

                //if (files.Length == 0)
                //{
                    if (openFileDialog != null)
                    {
                        string name = @"\\" + ip + "\\Videos" + "\\" + Path.GetFileName(openFileDialog.FileName);
                        System.IO.File.Copy(openFileDialog.FileName, name);
                        //csNetDrive.CencelRemoteServer("Y:"); //공유폴더연결 닫음
                        MessageBox.Show("동영상이 저장 되었습니다.");
                    }
                    else
                    {
                        MessageBox.Show("불러오기를하여 파일을 선택해주세요.");
                    }
                //}
                //else
                //{
                //    MessageBox.Show("동영상 업로드 가능 개수는 1개 입니다. 동영상 삭제 후 진행해 주세요");
                //}
            }
            catch (Exception ex)
            {
                WriteLog.WriteLogger(ex.ToString());
            }
            csNetDrive.CencelRemoteServer("Y:"); //공유폴더연결 닫음
        }

        private void dialogBtn_Click(object sender, EventArgs e)
        {
            try
            {

                openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files(*.MP4;)|*.MP4;";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    vidioPathTat.Text = openFileDialog.FileName;
                }
            }
            catch(Exception ex)
            {
                WriteLog.WriteLogger(ex.ToString());
            }
        }


        private void ipFTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (ipFTxt.Text.Length > 3)
                {
                    MessageBox.Show("3자리가 넘을수 없습니다.");
                    ipFTxt.Text = "";
                }
            }
            catch(Exception ex) { WriteLog.WriteLogger(ex.ToString()); }
        }

        private void ipMTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (ipMTxt.Text.Length > 3)
                {
                    MessageBox.Show("3자리가 넘을수 없습니다.");
                    ipMTxt.Text = "";
                }
            }
            catch(Exception ex) { WriteLog.WriteLogger(ex.ToString()); }
        }

        private void ipLTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (ipLTxt.Text.Length > 3)
                {
                    MessageBox.Show("3자리가 넘을수 없습니다.");
                    ipLTxt.Text = "";
                }
            }catch(Exception ex) { WriteLog.WriteLogger(ex.ToString()); }
        }

        private void ipLTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //숫자만 입력되도록 필터링
                if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
                {
                    e.Handled = true;
                    MessageBox.Show("숫자만 입력 가능 합니다.");
                }
            }catch(Exception ex) { WriteLog.WriteLogger(ex.ToString()); }
        }

        private void ipMTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //숫자만 입력되도록 필터링
                if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
                {
                    e.Handled = true;
                    MessageBox.Show("숫자만 입력 가능 합니다.");
                }

            }catch(Exception ex) { WriteLog.WriteLogger(ex.ToString()); }
        }


        private void ipFTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                //숫자만 입력되도록 필터링
                if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
                {
                    e.Handled = true;
                    MessageBox.Show("숫자만 입력 가능 합니다.");
                }
            }
            catch(Exception ex) { WriteLog.WriteLogger(ex.ToString()); }
        }

        private void ipSaveBtn_Click(object sender, EventArgs e)
        {
            SetAppConfig();
            MessageBox.Show("저장 되었습니다.");
        }

        private void SetAppConfig()
        {
            try
            {
                if (MessageBox.Show("DIDSystem IP Address를 저장 하시겠습니까?", "알림", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                   == DialogResult.OK)
                {
                    //xmlRead.AppSettingXmlSave(ipFTxt.Text + "." + ipMTxt.Text + "." + ipLTxt.Text + "." + ipLLTxt.Text, @"Config.xml");
                    Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    KeyValueConfigurationCollection cfgCollextion = config.AppSettings.Settings;

                    cfgCollextion.Remove("DIDip");
                    cfgCollextion.Add("DIDip", ipFTxt.Text + "." + ipMTxt.Text + "." + ipLTxt.Text + "." + ipLLTxt.Text);

                    config.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
                }
            }
            catch(Exception ex) { WriteLog.WriteLogger(ex.ToString()); }

        }
         
        private void ipLLTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ipLLTxt.Text.Length > 3)
                {
                    MessageBox.Show("3자리가 넘을수 없습니다.");
                    ipLLTxt.Text = "";
                }
            }
            catch(Exception ex) { WriteLog.WriteLogger(ex.ToString()); }
        }

        private void ipLLTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                //숫자만 입력되도록 필터링
                if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
                {
                    e.Handled = true;
                    MessageBox.Show("숫자만 입력 가능 합니다.");
                }
            }
            catch(Exception ex) { WriteLog.WriteLogger(ex.ToString()); }
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.Black, Color.Black);
        }
    }
}
