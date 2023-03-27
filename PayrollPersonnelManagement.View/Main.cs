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
            var f = new BaseForm() { MdiParent = this };
            f.Show();
        }

    }
}
