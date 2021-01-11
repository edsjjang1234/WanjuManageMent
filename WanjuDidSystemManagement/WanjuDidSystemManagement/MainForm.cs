using LogLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WanjuDidSystemManagement
{
    public partial class MainForm : Form
    {
        private OrganizationForm organizationForm = null;
        private PhotoManageForm photoForm = null;
        private VidioManageForm vidioForm = null;

        public MainForm()
        {
            InitializeComponent();
            Inti();
        }

        private void Inti()
        {
            try
            {
                if (ActiveMdiChild != null)
                {
                    if (this.ActiveMdiChild != organizationForm)
                    {
                        ActiveMdiChild.Close();
                    }
                    organizationForm = ShowActiveForm(organizationForm, typeof(OrganizationForm)) as OrganizationForm;
                }
                else
                {
                    organizationForm = ShowActiveForm(organizationForm, typeof(OrganizationForm)) as OrganizationForm;
                }
            }
            catch(Exception ex)
            {
                WriteLog.WriteLogger(ex.ToString());
            }
        }

        private Form ShowActiveForm(Form form, Type t)
        {
            try
            {

                if (form == null)
                {
                    form = (Form)Activator.CreateInstance(t);
                    form.MdiParent = this;
                    form.WindowState = FormWindowState.Maximized;
                    form.Show();
                }
                else
                {
                    if (form.IsDisposed)
                    {
                        form = (Form)Activator.CreateInstance(t);
                        form.MdiParent = this;
                        form.WindowState = FormWindowState.Maximized;
                        form.Show();
                    }
                    else
                    {
                        form.Activate();
                    }
                }

                return form;
            }
            catch(Exception ex)
            {
                WriteLog.WriteLogger(ex.ToString());
                return form;               
            }
        }

        private void photo_Btn_Click(object sender, EventArgs e)
        {
            try
            {

                if (ActiveMdiChild != null)
                {
                    if (this.ActiveMdiChild != photoForm)
                    {
                        ActiveMdiChild.Close();
                    }
                    photoForm = ShowActiveForm(photoForm, typeof(PhotoManageForm)) as PhotoManageForm;
                }
                else
                {
                    photoForm = ShowActiveForm(photoForm, typeof(PhotoManageForm)) as PhotoManageForm;
                }
            }
            catch(Exception ex)
            {
                WriteLog.WriteLogger(ex.ToString());
            }
        }

        private void vidio_Btn_Click(object sender, EventArgs e)
        {
            try
            {

                if (ActiveMdiChild != null)
                {
                    if (this.ActiveMdiChild != vidioForm)
                    {
                        ActiveMdiChild.Close();
                    }
                    vidioForm = ShowActiveForm(vidioForm, typeof(VidioManageForm)) as VidioManageForm;
                }
                else
                {
                    vidioForm = ShowActiveForm(vidioForm, typeof(VidioManageForm)) as VidioManageForm;
                }
            }catch(Exception ex)
            {
                WriteLog.WriteLogger(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ActiveMdiChild != null)
                {
                    if (this.ActiveMdiChild != organizationForm)
                    {
                        ActiveMdiChild.Close();
                    }
                    organizationForm = ShowActiveForm(organizationForm, typeof(OrganizationForm)) as OrganizationForm;
                }
                else
                {
                    organizationForm = ShowActiveForm(organizationForm, typeof(OrganizationForm)) as OrganizationForm;
                }
            }
            catch(Exception ex)
            {
                WriteLog.WriteLogger(ex.ToString());
            }
        }
    }
}
