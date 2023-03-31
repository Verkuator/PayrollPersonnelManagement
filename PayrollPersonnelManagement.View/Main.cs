using PayrollPersonnelManagement.Common;
using PayrollPersonnelManagement.Infasrtucture.Controll;
using PayrollPersonnelManagement.Infasrtucture.Controlls;
using PayrollPersonnelManagement.View;
using System;
using System.Threading;
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
            var f = new BaseFormAdapter<PhisicalFace>(ControllHelper.PhisicalFaceControll) { MdiParent = this };
            f.Show();
        }

        private void PostTab_Click(object sender, EventArgs e)
        {
            var f = new BaseFormAdapter<Post>(ControllHelper.PostControll) { MdiParent = this };
            f.Show();
        }

        private void OneAccrualTab_Click(object sender, EventArgs e)
        {
            var f = new BaseFormAdapter<OneAccrual>(ControllHelper.OneAccrualControll) { MdiParent = this };
            f.Show();
        }

        private void SubdivisionTab_Click(object sender, EventArgs e)
        {
            var f = new BaseFormAdapter<Subdivision>(ControllHelper.SubdivisionControll) { MdiParent = this };
            f.Show();
        }

        private void EmployeeTab_Click(object sender, EventArgs e)
        {
            var f = new BaseFormAdapter<Employee>(ControllHelper.EmployeeControll) { MdiParent = this };
            f.Show();
        }
    }
}
