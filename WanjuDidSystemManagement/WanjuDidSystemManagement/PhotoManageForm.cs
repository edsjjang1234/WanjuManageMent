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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WanjuDidSystemManagement
{
    public partial class PhotoManageForm : Form
    {
        DataTable photoDt;
        DataRow dataRow;
        XmlRead xmlRead;
        FileStream fileStream;
        PhotoAddForm photoAddForm;
        csNetDrive csNetDrive;

        public PhotoManageForm()
        {
            InitializeComponent();
            xmlRead = new XmlRead();
            csNetDrive = new csNetDrive();
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            
            photoGrid.ReadOnly = true;
            photoGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            FileRead();
        }

        private void FileRead()
        {
            int row = 1;
            string photoRemark = string.Empty;
            string ip = ConfigurationManager.AppSettings["DIDip"];
            int tt = csNetDrive.setRemoteConnection(@"\\" + ip + "\\Image", "test", "1234", "Y");//공유 폴더 전송 테스트
            try
            { 
                photoDt = new DataTable();
                photoDt.Columns.Add("선택", typeof(bool));
                photoDt.Columns.Add("순서", typeof(string));
                photoDt.Columns.Add("사진이름", typeof(string));
                photoDt.Columns.Add("사진설명", typeof(string));

                foreach (string fileName in Directory.GetFiles(@"\\" + ip + "\\Image"))
                {
                    if (Regex.IsMatch(fileName, @".jpg|.png|.bmp|.JPG|.PNG|.BMP|.JPEG|.jpeg$"))
                    {
                        dataRow = photoDt.NewRow();

                        dataRow["선택"] = false;
                        dataRow["순서"] = Convert.ToString(row);
                        dataRow["사진이름"] = Path.GetFileName(fileName);

                        photoRemark = xmlRead.PhotoXmlParer(@"\\" + ip + "\\Image\\" + Path.GetFileNameWithoutExtension(fileName) + ".xml");
                        dataRow["사진설명"] = photoRemark;
                        photoDt.Rows.Add(dataRow);
                        row++;
                    }
                }

                photoGrid.DataSource = photoDt;
                row = 0;
            }
            catch(Exception ex)
            {
                WriteLog.WriteLogger(ex.ToString());
            }
            csNetDrive.CencelRemoteServer("Y:"); //공유폴더연결 닫음
        }

        private void SetPhoto(string photoFileName)
        {
            string ip = ConfigurationManager.AppSettings["DIDip"];
            int tt = csNetDrive.setRemoteConnection(@"\\" + ip + "\\Image", "test", "1234", "Y");//공유 폴더 전송 테스트
            try
            {
                fileStream = new FileStream(@"\\" + ip + "\\Image\\" + photoFileName, FileMode.Open, FileAccess.Read);
                pictureBox1.Image = System.Drawing.Image.FromStream(fileStream);
                fileStream.Close();
            }
            catch(Exception ex)
            {
                WriteLog.WriteLogger(ex.ToString());
            }
            csNetDrive.CencelRemoteServer("Y:"); //공유폴더연결 닫음
        }

        private void photoGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int photoIndex = 0;
            try
            {

                //Check to ensure that the row CheckBox is clicked. 
                if (e.RowIndex >= 0 && e.ColumnIndex == 0)
                { //Loop and uncheck all other CheckBoxes. 
                    foreach (DataGridViewRow row in photoGrid.Rows)
                    {
                        if (row.Index == e.RowIndex)
                        {
                            row.Cells["선택"].Value = !Convert.ToBoolean(row.Cells["선택"].EditedFormattedValue);
                            photoIndex = e.RowIndex;
                        }
                        else { row.Cells["선택"].Value = false; }
                    }
                }

                SetPhoto(photoGrid.Rows[photoIndex].Cells["사진이름"].Value.ToString());
            }
            catch(Exception ex) { WriteLog.WriteLogger(ex.ToString()); }
        }

        private void photoDeleteBtn_Click(object sender, EventArgs e)
        {
            string ip = ConfigurationManager.AppSettings["DIDip"];
            int tt = csNetDrive.setRemoteConnection(@"\\" + ip + "\\Image", "test", "1234", "Y");//공유 폴더 전송 테스트

            try
            {
                if (MessageBox.Show("선택한 이미지를 삭제 하시겠습니까?", "경고", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                   == DialogResult.OK)
                {
                    string photoName = string.Empty;
                    photoGrid.EndEdit();
                    for (int i = 0; i < photoGrid.Rows.Count; i++)
                    {
                        bool IsChecked = Convert.ToBoolean(photoGrid.Rows[i].Cells["선택"].Value);
                        if (IsChecked)
                        {
                            photoName = photoGrid.Rows[i].Cells["사진이름"].Value.ToString();
                            break;
                        }
                    }

                    PhotoDelete(@"\\" + ip + "\\Image\\" + photoName);
                    PhotoDelete(@"\\" + ip + "\\Image\\" + Path.GetFileNameWithoutExtension(photoName) + ".xml");
                }

                pictureBox1.Image = null;
                MessageBox.Show("이미지가 삭제 처리 되었습니다.");
                FileRead();
            }
            catch(Exception ex)
            {
                WriteLog.WriteLogger(ex.ToString());
            }
            csNetDrive.CencelRemoteServer("Y:"); //공유폴더연결 닫음
        }

        /// <summary>
        /// 사진 삭제
        /// </summary>
        /// <param name="filePath"></param>
        private void PhotoDelete(string filePath)
        {
            try
            {

                FileInfo fileInfo = new FileInfo(filePath);
                if (fileInfo.Exists)
                    fileInfo.Delete();
                else
                    MessageBox.Show("해당 이미지가 없습니다.");
            }
            catch(Exception ex)
            {
                WriteLog.WriteLogger(ex.ToString());
            }
        }

        private void photoAddBtn_Click(object sender, EventArgs e)
        {
            try
            {

                photoAddForm = new PhotoAddForm();
                photoAddForm.Owner = this;
                photoAddForm.ShowDialog();

                FileRead();
            }
            catch(Exception ex) { WriteLog.WriteLogger(ex.ToString()); }
        }
    }
}
