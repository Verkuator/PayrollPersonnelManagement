using DevExpress.XtraEditors;
using PayrollPersonnelManagement.Aplication.Controlls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollPersonnelManagement.View.UI.FormSave
{
    public partial class EmploeeFormSave : FormAdapter
    {
        public EmploeeFormSave()
        {
            InitializeComponent();
        }

        public void SaveSimpleButton_Click(object sender, EventArgs e)
        {
            //ControllHelper.PhisicalFaceControll.Save(new PhisicalFace());
        }

        public void CancelSimpleButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public override void MapForm(object obj)
        {

        }
    }
}