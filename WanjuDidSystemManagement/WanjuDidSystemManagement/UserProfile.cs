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
    public partial class UserProfile : Form
    {
        XmlRead xmlRead;
        csNetDrive csNetDrive;
        string deptIndex = string.Empty;
        int gridIndex = 0;
        public UserProfile(string deptIndex , int gridIndex)
        {
            InitializeComponent();
            xmlRead = new XmlRead();
            csNetDrive = new csNetDrive();
            this.deptIndex = deptIndex;
            this.gridIndex = gridIndex;
            UserPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            SetProfile();
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

        /// <summary>
        /// User 프로필을 로드하여 세팅한다
        /// </summary>
        private void SetProfile()
        {
            string xmlTxt = string.Empty;
            string deptmentIndex = deptIndex;
            string[] xmlArray;
            int rowIndex = gridIndex;
            string strFile = string.Empty;
            FileInfo fileInfo;
            FileStream fileStram;
            string ip = ConfigurationManager.AppSettings["DIDip"];
            int tt = csNetDrive.setRemoteConnection(@"\\" + ip + "\\images", "test", "1234", "Y");//공유 폴더 전송 테스트
            try
            {

                switch (deptmentIndex)
                {
                    //민원과
                    case "0":
                        strFile = @"\\"+ip+"\\images\\Complaunts\\" + rowIndex + ".jpg";
                        fileInfo = new FileInfo(strFile);
                        //파일 있는지 확인 있을때(true), 없으면(false)
                        if (fileInfo.Exists)
                        {
                            fileStram = new FileStream(strFile, FileMode.Open, FileAccess.Read);
                            UserPictureBox.Image = System.Drawing.Image.FromStream(fileStram);
                            fileStram.Close();
                        }

                        UserPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        xmlTxt = xmlRead.XmlParser(@"\\" + ip + "\\DIDXML\\Complaints.xml", rowIndex);
                        break;
                    //건축과
                    case "1":
                        strFile = @"\\" + ip + "\\images\\Construct\\" + rowIndex + ".jpg";
                        fileInfo = new FileInfo(strFile);
                        //파일 있는지 확인 있을때(true), 없으면(false)
                        if (fileInfo.Exists)
                        {
                            fileStram = new FileStream(strFile, FileMode.Open, FileAccess.Read);
                            UserPictureBox.Image = System.Drawing.Image.FromStream(fileStram);
                            fileStram.Close();
                        }

                        UserPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        xmlTxt = xmlRead.XmlParser(@"\\" + ip + "\\DIDXML\\Construct.xml", rowIndex);
                        break;

                    case "2":
                        strFile = @"\\" + ip + "\\images\\" + rowIndex + ".jpg";
                        fileInfo = new FileInfo(strFile);
                        //파일 있는지 확인 있을때(true), 없으면(false)
                        if (fileInfo.Exists)
                        {
                            fileStram = new FileStream(strFile, FileMode.Open, FileAccess.Read);
                            UserPictureBox.Image = System.Drawing.Image.FromStream(fileStram);
                            fileStram.Close();
                        }

                        UserPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        xmlTxt = xmlRead.XmlParser(@"\\" + ip + "\\DIDXML\\organizationchart.xml", rowIndex);
                        break;
                }

                xmlArray = xmlTxt.Split(',');

                NameTxtBox.Text = xmlArray[2].ToString();
                TeamTxtBox.Text = xmlArray[3].ToString();
                WorkTxtBox.Text = xmlArray[4].ToString();
                TelTxtBox.Text = xmlArray[5].ToString();
                if (xmlArray[6].ToString() == "true")
                    NameCardCheckBox.Checked = true;
                else
                    NameCardCheckBox.Checked = false;
            }
            catch (Exception ex)
            {
                WriteLog.WriteLogger(ex.ToString());
            }
            csNetDrive.CencelRemoteServer("Y:"); //공유폴더연결 닫음
        }

        private void FileDialog_Btn_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image files (*.jpg)|*.jpg";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    UserPictureBox.Load(openFileDialog.FileName);
                }
            }
            catch(Exception ex) { WriteLog.WriteLogger(ex.ToString()); }
        }

        private void ColseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 사용자 사진 삭제
        /// </summary>
        /// <param name="filePath"></param>
        private void UserPictureDelete(string filePath)
        {
            try
            {

                FileInfo fileInfo = new FileInfo(filePath);
                if (fileInfo.Exists)
                    fileInfo.Delete();
                else
                    MessageBox.Show("해당 이미지가 없습니다.");
            }
            catch(Exception ex) { WriteLog.WriteLogger(ex.ToString()); }
        }

        private void PicTureClearBtn_Click(object sender, EventArgs e)
        {
            string deptmentIndex = deptIndex; 
            int rowIndex = gridIndex;
            string ip = ConfigurationManager.AppSettings["DIDip"];
            int tt = csNetDrive.setRemoteConnection(@"\\" + ip + "\\images", "test", "1234", "Y");//공유 폴더 전송 테스트
            try
            {

                if (MessageBox.Show("선택한 이미지를 삭제 하시겠습니까?", "경고", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                    == DialogResult.OK)
                {
                    UserPictureBox.Image = null;
                    switch (deptmentIndex)
                    {
                        case "0":
                            UserPictureDelete(@"\\" + ip + "\\images\\Complaunts\\" + rowIndex + ".jpg");
                            break;
                        case "1":
                            UserPictureDelete(@"\\" + ip + "\\images\\Construct\\" + rowIndex + ".jpg");
                            break;
                        case "2":
                            UserPictureDelete(@"\\" + ip + "\\images\\" + rowIndex + ".jpg");
                            break;
                    }

                }
                MessageBox.Show("사진이 삭제 되었습니다.");
            }catch(Exception ex)
            {
                WriteLog.WriteLogger(ex.ToString());
            }
            csNetDrive.CencelRemoteServer("Y:"); //공유폴더연결 닫음
        }
        /// <summary>
        /// 사용자 사진 저장
        /// </summary>
        /// <param name="folderPath"></param>
        /// <param name="SavePath"></param>
        private void UserPictureSave(string folderPath, string SavePath)
        {
            try
            {

                if (Directory.Exists(folderPath))
                    UserPictureBox.Image.Save(SavePath, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch(Exception ex)
            {
                WriteLog.WriteLogger(ex.ToString());
            }
        }
        /// <summary>
        /// 사용자 프로필 저장
        /// </summary>
        private void UserProfileSave()
        {
            System.IO.FileInfo fi;
            string deptmentIndex = deptIndex;
            int rowIndex = gridIndex;            
            string userName = string.Empty;
            string team = string.Empty;
            string work = string.Empty;
            string tel = string.Empty;
            string nameCardVisibility = string.Empty;
            
            string ip = ConfigurationManager.AppSettings["DIDip"];
            int tt = csNetDrive.setRemoteConnection(@"\\" + ip + "\\images", "test", "1234", "Y");//공유 폴더 전송 테스트
            try
            {

                if (NameTxtBox.Text.Length > 0)
                    userName = NameTxtBox.Text;
                else
                    userName = " ";

                if (TeamTxtBox.Text.Length > 0)
                    team = TeamTxtBox.Text;
                else
                    team = " ";

                if (WorkTxtBox.Text.Length > 0)
                    work = WorkTxtBox.Text;
                else
                    work = " ";

                if (TelTxtBox.Text.Length > 0)
                    tel = TelTxtBox.Text;
                else
                    tel = " ";

                if (NameCardCheckBox.Checked)
                    nameCardVisibility = "true";
                else
                    nameCardVisibility = "false";

                
                switch (deptmentIndex)
                {
                    case "0":
                        if (UserPictureBox.Image != null)
                        {
                            fi = new System.IO.FileInfo(@"\\" + ip + "\\images\\Complaunts\\" + rowIndex + ".jpg");
                            if (!fi.Exists)
                                UserPictureSave(@"\\" + ip + "\\images\\Complaunts", @"\\" + ip + "\\images\\Complaunts\\" + rowIndex + ".jpg");
                        }
                        xmlRead.XmlSave(@"\\" + ip + "\\DIDXML\\Complaints.xml", rowIndex, userName, team, work, tel, nameCardVisibility);
                        break;
                    case "1":
                        if (UserPictureBox.Image != null)
                        {
                            fi = new System.IO.FileInfo(@"\\" + ip + "\\images\\Complaunts\\" + rowIndex + ".jpg");
                            if (!fi.Exists)
                                UserPictureSave(@"\\" + ip + "\\images\\Complaunts", @"\\" + ip + "\\images\\Complaunts\\" + rowIndex + ".jpg");
                        }
                       

                        xmlRead.XmlSave(@"\\" + ip + "\\DIDXML\\Construct.xml", rowIndex, userName, team, work, tel, nameCardVisibility);
                        break;
                    case "2":
                        if (UserPictureBox.Image != null)
                        {
                            fi = new System.IO.FileInfo(@"\\" + ip + "\\images\\" + rowIndex + ".jpg");
                            if (!fi.Exists)
                                UserPictureSave(@"\\" + ip + "\\images\\Complaunts", @"\\" + ip + "\\images\\" + rowIndex + ".jpg");
                        }
                        

                        xmlRead.XmlSave(@"\\" + ip + "\\DIDXML\\organizationchart.xml", rowIndex, userName, team, work, tel, nameCardVisibility);
                        break;
                }
                MessageBox.Show("사용자가 추가 저장되었습니다.");
            }
            catch(Exception ex)
            {
                WriteLog.WriteLogger(ex.ToString());
            }
            csNetDrive.CencelRemoteServer("Y:"); //공유폴더연결 닫음
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            UserProfileSave();
        }
    }
}
