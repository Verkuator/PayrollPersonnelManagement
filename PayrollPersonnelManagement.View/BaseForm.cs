using DevExpress.XtraBars;
using PayrollPersonnelManagement.Infasrtucture.Controlls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollPersonnelManagement.View
{
    public partial class BaseForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public string TabName { get; set; }
        private bool UseTab { get; set; }
        public BaseForm()
        {
            InitializeComponent();
            ControlBox = false;
            UseTab = true;
        }

        public bool IsUseTab()
        {
            return UseTab;
        }       

        
    }
}