using LogLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WanjuDidSystemManagement
{
    public partial class OrganizationForm : Form
    {
        List<ConstructListControl> deptList = new List<ConstructListControl>();
        XmlRead xmlRead;
        DataTable deptDt;
        DataRow dataRow;
        UserProfile userProfile;
        csNetDrive csNetDrive;
        public OrganizationForm()
        {
            InitializeComponent();
            xmlRead = new XmlRead();
            csNetDrive = new csNetDrive();
            //xmlRead.XmlParser(@"C:\WanjuDIDSystem\DIDXML\\Complaints.xml", 4);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            ComplaintsGrid.ReadOnly = true;
            ComplaintsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ConstructGrid.ReadOnly = true;
            ConstructGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ComplaintsDepList();
        }
        /// <summary>
        /// 민원과 직원 리스트
        /// </summary>
        /// <param name="filePath"></param>
        private void ConstructDepList()
        {

            string ip = ConfigurationManager.AppSettings["DIDip"];
            int tt = csNetDrive.setRemoteConnection(@"\\" + ip + "\\DIDXML", "test", "1234", "Y");//공유 폴더 전송 테스트
            //string ip = xmlRead.AppSettingXmlParser(@"Config.xml");
            //int tt = csNetDrive.setRemoteConnection(@"\\" + ip + "\\DIDXML", "test", "1234", "Y");//공유 폴더 전송 테스트
            try
            {

                deptDt = new DataTable();
                deptDt.Columns.Add("선택", typeof(bool));
                deptDt.Columns.Add("순서", typeof(string));
                deptDt.Columns.Add("이름", typeof(string));
                deptDt.Columns.Add("과", typeof(string));
                deptDt.Columns.Add("팀", typeof(string));
                deptDt.Columns.Add("업무", typeof(string));
                deptDt.Columns.Add("전화번호", typeof(string));
                deptDt.Columns.Add("활성", typeof(string));

                deptList = xmlRead.XmlReader(@"\\" + ip + "\\DIDXML\\Construct.xml");

                for (int i = 0; i < deptList.Count; i++)
                {
                    dataRow = deptDt.NewRow();

                    dataRow["순서"] = deptList[i].Index;
                    dataRow["선택"] = false;
                    dataRow["이름"] = deptList[i].Name;
                    dataRow["과"] = deptList[i].Dept;
                    dataRow["팀"] = deptList[i].Team;
                    dataRow["업무"] = deptList[i].Work;
                    dataRow["전화번호"] = deptList[i].Tel;
                    if (deptList[i].Visibility.ToString() == "true")
                        dataRow["활성"] = "활성";
                    else
                        dataRow["활성"] = "비활성";

                    deptDt.Rows.Add(dataRow);
                }

                ConstructGrid.DataSource = deptDt;
            }
            catch(Exception ex)
            {
                WriteLog.WriteLogger(ex.ToString());
            }
            csNetDrive.CencelRemoteServer("Y:"); //공유폴더연결 닫음
        }
        /// <summary>
        /// 건축과 직원 리스트
        /// </summary>
        private void ComplaintsDepList()
        {
            string ip = ConfigurationManager.AppSettings["DIDip"];
            int tt = csNetDrive.setRemoteConnection(@"\\" + ip + "\\DIDXML", "test", "1234", "Y");//공유 폴더 전송 테스트
            try
            {
                deptDt = new DataTable();
                deptDt.Columns.Add("선택", typeof(bool));
                deptDt.Columns.Add("순서", typeof(string));
                deptDt.Columns.Add("이름", typeof(string));
                deptDt.Columns.Add("과", typeof(string));
                deptDt.Columns.Add("팀", typeof(string));
                deptDt.Columns.Add("업무", typeof(string));
                deptDt.Columns.Add("전화번호", typeof(string));
                deptDt.Columns.Add("활성", typeof(string));

                deptList = xmlRead.XmlReader(@"\\" + ip + "\\DIDXML\\Complaints.xml");

                for (int i = 0; i < deptList.Count; i++)
                {
                    dataRow = deptDt.NewRow();

                    dataRow["순서"] = deptList[i].Index;
                    dataRow["선택"] = false;
                    dataRow["이름"] = deptList[i].Name;
                    dataRow["과"] = deptList[i].Dept;
                    dataRow["팀"] = deptList[i].Team;
                    dataRow["업무"] = deptList[i].Work;
                    dataRow["전화번호"] = deptList[i].Tel;
                    if (deptList[i].Visibility.ToString() == "true")
                        dataRow["활성"] = "활성";
                    else
                        dataRow["활성"] = "비활성";

                    deptDt.Rows.Add(dataRow);
                }

                ComplaintsGrid.DataSource = deptDt;
            }catch(Exception ex)
            {
                WriteLog.WriteLogger(ex.ToString());
            }
            csNetDrive.CencelRemoteServer("Y:"); //공유폴더연결 닫음
        }
        /// <summary>
        /// 건축과
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConstructGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                //Check to ensure that the row CheckBox is clicked. 
                if (e.RowIndex >= 0 && e.ColumnIndex == 0)
                { //Loop and uncheck all other CheckBoxes. 
                    foreach (DataGridViewRow row in ComplaintsGrid.Rows)
                    {
                        if (row.Index == e.RowIndex)
                        {
                            row.Cells["선택"].Value = !Convert.ToBoolean(row.Cells["선택"].EditedFormattedValue);
                        }
                        else { row.Cells["선택"].Value = false; }
                    }
                }
            }
            catch(Exception ex)
            {
                WriteLog.WriteLogger(ex.ToString());
            }
        }
          
        private void Org_Tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = Org_Tab.SelectedIndex;
            try
            {
                switch (index)
                {
                    case 0:
                        ComplaintsDepList();
                        //ConstructDepList();
                        break;
                    case 1:
                        ConstructDepList();
                        //ComplaintsDepList();
                        break;
                    case 2:
                        OrganizationList();
                        break;
                }
            }

            catch (Exception ex) { WriteLog.WriteLogger(ex.ToString()); }
        }

        private void OrganizationList()
        {
            string ip = ConfigurationManager.AppSettings["DIDip"];
            int tt = csNetDrive.setRemoteConnection(@"\\" + ip + "\\DIDXML", "test", "1234", "Y");//공유 폴더 전송 테스트
            try
            {
                deptDt = new DataTable();
                deptDt.Columns.Add("선택", typeof(bool));
                deptDt.Columns.Add("순서", typeof(string));
                deptDt.Columns.Add("이름", typeof(string));
                deptDt.Columns.Add("과", typeof(string));
                deptDt.Columns.Add("팀", typeof(string));
                deptDt.Columns.Add("업무", typeof(string));
                deptDt.Columns.Add("전화번호", typeof(string));
                deptDt.Columns.Add("활성", typeof(string));

                deptList = xmlRead.XmlReader(@"\\" + ip + "\\DIDXML\\organizationchart.xml");

                for (int i = 0; i < deptList.Count; i++)
                {
                    dataRow = deptDt.NewRow();

                    dataRow["순서"] = deptList[i].Index;
                    dataRow["선택"] = false;
                    dataRow["이름"] = deptList[i].Name;
                    dataRow["과"] = deptList[i].Dept;
                    dataRow["팀"] = deptList[i].Team;
                    dataRow["업무"] = deptList[i].Work;
                    dataRow["전화번호"] = deptList[i].Tel;
                    if (deptList[i].Visibility.ToString() == "true")
                        dataRow["활성"] = "활성";
                    else
                        dataRow["활성"] = "비활성";

                    deptDt.Rows.Add(dataRow);
                }

                informationGrid.DataSource = deptDt;
            }
            catch(Exception ex)
            {
                WriteLog.WriteLogger(ex.ToString());
            }
            csNetDrive.CencelRemoteServer("Y:"); //공유폴더연결 닫음
        }
        /// <summary>
        /// 민원과
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComplaintsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                //Check to ensure that the row CheckBox is clicked. 
                if (e.RowIndex >= 0 && e.ColumnIndex == 0)
                { //Loop and uncheck all other CheckBoxes. 
                    foreach (DataGridViewRow row in ConstructGrid.Rows)
                    {
                        if (row.Index == e.RowIndex)
                        {
                            row.Cells["선택"].Value = !Convert.ToBoolean(row.Cells["선택"].EditedFormattedValue);
                        }
                        else { row.Cells["선택"].Value = false; }
                    }
                }
            }
            catch (Exception ex) { WriteLog.WriteLogger(ex.ToString()); }
        }
        /// <summary>
        /// 건축과
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConstructChange_Btn_Click(object sender, EventArgs e)
        {
            ConstructChange();
            ConstructDepList();
        }

        private void ConstructChange()
        {
            int rowIndex = 0;
            int checkIndex = 0;
            try
            {

                ConstructGrid.EndEdit();
                for (int i = 0; i < ConstructGrid.Rows.Count; i++)
                {
                    bool IsChecked = Convert.ToBoolean(ConstructGrid.Rows[i].Cells["선택"].Value);
                    if (IsChecked)
                    {
                        rowIndex = Convert.ToInt32(ConstructGrid.Rows[i].Cells["순서"].Value.ToString());
                        checkIndex = 1;
                    }
                }

                if (checkIndex == 1)
                {
                    userProfile = new UserProfile("1", rowIndex);
                    userProfile.Owner = this;
                    userProfile.ShowDialog();
                }
                else
                {
                    MessageBox.Show("저장/수정 할 목록을 체크 하세요.");
                }
                checkIndex = 0;
            }
            catch (Exception ex) { WriteLog.WriteLogger(ex.ToString()); }
        }
        /// <summary>
        /// 민원과
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComplaintsChange_Btn_Click(object sender, EventArgs e)
        {
            ComplaintsChange();
            ComplaintsDepList();
        }

        private void ComplaintsChange()
        {
            int rowIndex = 0;
            int checkIndex = 0;
            try
            {

                ComplaintsGrid.EndEdit();
                for (int i = 0; i < ComplaintsGrid.Rows.Count; i++)
                {
                    bool IsChecked = Convert.ToBoolean(ComplaintsGrid.Rows[i].Cells["선택"].Value);
                    if (IsChecked)
                    {
                        rowIndex = Convert.ToInt32(ComplaintsGrid.Rows[i].Cells["순서"].Value.ToString());
                        checkIndex = 1;
                    }
                }

                if (checkIndex == 1)
                {
                    userProfile = new UserProfile("0", rowIndex);
                    userProfile.Owner = this;
                    userProfile.ShowDialog();
                }
                else
                {
                    MessageBox.Show("저장/수정 할 목록을 체크 하세요.");
                }
                checkIndex = 0;
            }
            catch(Exception ex) { WriteLog.WriteLogger(ex.ToString()); }
        }

        private void organizationChange()
        {
            int rowIndex = 0;
            int checkIndex = 0;
            try
            {

                informationGrid.EndEdit();
                for (int i = 0; i < informationGrid.Rows.Count; i++)
                {
                    bool IsChecked = Convert.ToBoolean(informationGrid.Rows[i].Cells["선택"].Value);
                    if (IsChecked)
                    {
                        rowIndex = Convert.ToInt32(informationGrid.Rows[i].Cells["순서"].Value.ToString());
                        checkIndex = 1;
                    }
                }

                if (checkIndex == 1)
                {
                    userProfile = new UserProfile("2", rowIndex);
                    userProfile.Owner = this;
                    userProfile.ShowDialog();
                }
                else
                {
                    MessageBox.Show("저장/수정 할 목록을 체크 하세요.");
                }
                checkIndex = 0;
            }
            catch (Exception ex) { WriteLog.WriteLogger(ex.ToString()); }
        }

        private void informationGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Check to ensure that the row CheckBox is clicked. 
                if (e.RowIndex >= 0 && e.ColumnIndex == 0)
                { //Loop and uncheck all other CheckBoxes. 
                    foreach (DataGridViewRow row in informationGrid.Rows)
                    {
                        if (row.Index == e.RowIndex)
                        {
                            row.Cells["선택"].Value = !Convert.ToBoolean(row.Cells["선택"].EditedFormattedValue);
                        }
                        else { row.Cells["선택"].Value = false; }
                    }
                }
            }
            catch (Exception ex)
            {
                WriteLog.WriteLogger(ex.ToString());
            }
        }

        private void informationBtn_Click(object sender, EventArgs e)
        {
            organizationChange();
            OrganizationList();
        }
    }
}
