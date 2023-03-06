using PayrollPersonnelManagement.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollPersonnelManagement
{
    public partial class Directorys : UserControl
    {
        public Directorys()
        {
            InitializeComponent();
        }

        private void Directorys_Load(object sender, EventArgs e)
        {

        }

        public FlowLayoutPanel FlowLayoutPanel()
        {
            return this.flowLayoutPanel1;
        }

    }
}
