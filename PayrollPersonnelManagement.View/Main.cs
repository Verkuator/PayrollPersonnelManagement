using PayrollPersonnelManagement.Common;
using PayrollPersonnelManagement.Infasrtucture.Controll;
using PayrollPersonnelManagement.Infasrtucture.Controlls;
using PayrollPersonnelManagement.Infasrtucture.Model;
using System;
using System.Windows.Forms;

namespace PayrollPersonnelManagement.View
{
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            OpenMainForm();
        }

        private void OpenMainForm()
        {
        }

        private void PhisicalFaceTab_Click(object sender, EventArgs e)
        {
            OpenTab(ControllHelper.PhisicalFaceControll, ControllHelper.PhisicalFaceFormSave);
        }

        private void PostTab_Click(object sender, EventArgs e)
        {
            OpenTab(ControllHelper.PostControll, ControllHelper.PostFormSave);
        }

        private void OneAccrualTab_Click(object sender, EventArgs e)
        {
            OpenTab(ControllHelper.OneAccrualControll, ControllHelper.OneAccrualFormSave);
        }

        private void SubdivisionTab_Click(object sender, EventArgs e)
        {
            OpenTab(ControllHelper.SubdivisionControll, ControllHelper.SubdivisionFormSave);
        }

        private void EmployeeTab_Click(object sender, EventArgs e)
        {
            OpenTab(ControllHelper.EmployeeControll, ControllHelper.EmploeeFormSave);
        }

        private void OpenTab<T, D>(ModelActions<T, D> controller, Form form) 
            where T : class, IModel , new()
            where D : class, new()
        {
            if(!ThisOpenTab(controller.Name))
            {
                var f = new BaseFormAdapter<T, D>(controller, form) { MdiParent = this };
                f.Show();
            }
        }

        private bool ThisOpenTab(string name)
        {
            bool found = false;
            foreach (var frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    found = true;
                    frm.Select();
                    break;
                }
            }
            return found;
        }
    }
}
