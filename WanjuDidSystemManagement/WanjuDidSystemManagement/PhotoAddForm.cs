using LogLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WanjuDidSystemManagement
{
    public partial class PhotoAddForm : Form
    {
        OpenFileDialog openFileDialog;
        XmlRead xmlRead;
        csNetDrive csNetDrive;

        public PhotoAddForm()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            xmlRead = new XmlRead();
            csNetDrive = new csNetDrive();
        }

        /// <summary>
        /// 폼에 그림자를 추가하여준다.
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void exittBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("저장 하시겠습니까?", "알림", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                == DialogResult.OK)
            { 
                PhotoViewSave(Path.GetFileName(openFileDialog.FileName));
            }
        }

        private void PhotoViewSave(string fileNane)
        {
            string directoryPath = @"C:\\anytekTest\\Image";

            try
            {
                if (!Directory.Exists(directoryPath))
                    Directory.CreateDirectory(directoryPath);

                pictureBox1.Image.Save(directoryPath + "\\" + fileNane, System.Drawing.Imaging.ImageFormat.Jpeg);
                if (photoReamrkTxt.Text.Length > 0)
                    //xmlRead.PhotoRemarkXmlAdd(@"\\172.16.0.100\Image\\" + Path.GetFileNameWithoutExtension(fileNane) + ".xml", photoReamrkTxt.Text);//공유 폴더 전송 테스트
                    xmlRead.PhotoRemarkXmlAdd(directoryPath + "\\" + Path.GetFileNameWithoutExtension(fileNane) + ".xml", photoReamrkTxt.Text);
                else
                    xmlRead.PhotoRemarkXmlAdd(directoryPath + "\\" + Path.GetFileNameWithoutExtension(fileNane) + ".xml", " ");

                string[] files = Directory.GetFiles(directoryPath);
                string ip = ConfigurationManager.AppSettings["DIDip"];
                
                //string imageName = @"\\" + ip + "\\Image\\" + Path.GetFileName(fileNane);
                FileInfo info = new FileInfo(@"\\" + ip + "\\Image\\" + Path.GetFileName(fileNane));
                int tt = csNetDrive.setRemoteConnection(@"\\" + ip + "\\Image", "test", "1234", "Y");//공유 폴더 전송 테스트

                if (!info.Exists)
                {
                    foreach (string s in files)
                    {
                        string file = Path.GetFileName(s);
                        string destFile = Path.Combine(@"\\" + ip + "\\Image", file);

                        File.Copy(s, destFile, false);
                    }

                    DirectoryInfo dirInfo = new DirectoryInfo(@"C:\\anytekTest");
                    dirInfo.Delete(true);

                    MessageBox.Show("이미지가 저장 되었습니다.");
                }
                else
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(@"C:\\anytekTest");
                    dirInfo.Delete(true);

                    MessageBox.Show("동일한 이름의 이미지가 있어 저장 할 수 없습니다.");
                }
                //string ip = ConfigurationManager.AppSettings["DIDip"];
                //int tt = csNetDrive.setRemoteConnection(@"\\" + ip + "\\Image", "test", "1234", "Y");//공유 폴더 전송 테스트
                //Bitmap img = (Bitmap)pictureBox1.Image;
                //Bitmap newImag = new Bitmap(img);
                //img.Dispose();
                //img = null;
                //newImag.Save(@"\\" + ip + "\\Image\\" + fileNane, System.Drawing.Imaging.ImageFormat.Jpeg);
                //MessageBox.Show("이미지가 저장 되었습니다.");


                //string ip = ConfigurationManager.AppSettings["DIDip"];
                //int tt = csNetDrive.setRemoteConnection(@"\\" + ip + "\\Image", "test", "1234", "Y");//공유 폴더 전송 테스트

                //    if (!Directory.Exists(@"\\" + ip + "\\Image\\" + fileNane))
                //    {

                //        //pictureBox1.Image.Save(@"\\" + ip + "\\Image\\" + fileNane, System.Drawing.Imaging.ImageFormat.Jpeg);
                //        Bitmap bitMap = new Bitmap(pictureBox1.Image);
                //        bitMap.Save(@"\\" + ip + "\\Image\\" + fileNane, System.Drawing.Imaging.ImageFormat.Jpeg);

                //        if (photoReamrkTxt.Text.Length > 0)
                //            //xmlRead.PhotoRemarkXmlAdd(@"\\172.16.0.100\Image\\" + Path.GetFileNameWithoutExtension(fileNane) + ".xml", photoReamrkTxt.Text);//공유 폴더 전송 테스트
                //            xmlRead.PhotoRemarkXmlAdd(@"\\" + ip + "\\Image\\" + Path.GetFileNameWithoutExtension(fileNane) + ".xml", photoReamrkTxt.Text);
                //        else
                //            xmlRead.PhotoRemarkXmlAdd(@"\\" + ip + "\\Image\\" + Path.GetFileNameWithoutExtension(fileNane) + ".xml", " ");
                //    }

                //    MessageBox.Show("이미지가 저장 되었습니다.");
                csNetDrive.CencelRemoteServer("Y:"); //공유폴더연결 닫음

            }
            catch (Exception ex)
            {
                csNetDrive.CencelRemoteServer("Y:"); //공유폴더연결 닫음
                DirectoryInfo dirInfo = new DirectoryInfo(@"C:\\anytekTest");
                dirInfo.Delete(true);
                WriteLog.WriteLogger(ex.ToString());
            }
        }
        private void dialogBtn_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Load(openFileDialog.FileName);
                }
            }
            catch(Exception ex) { WriteLog.WriteLogger(ex.ToString()); }
        }
    }
}
