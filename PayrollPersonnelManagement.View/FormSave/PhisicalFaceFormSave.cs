using PayrollPersonnelManagement.Aplication.Controlls;
using System;
using System.Windows.Forms;

namespace PayrollPersonnelManagement.View.FormSave
{
    public partial class PhisicalFaceFormSave : FormAdapter
    {
        public PhisicalFaceFormSave()
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

        private void stackPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void stackPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void stackPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
