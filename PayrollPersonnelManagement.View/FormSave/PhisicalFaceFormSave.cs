using PayrollPersonnelManagement.Aplication.Dto;
using PayrollPersonnelManagement.Common;
using PayrollPersonnelManagement.Infasrtucture.Controll;
using PayrollPersonnelManagement.Infasrtucture.Controlls;
using System;
using System.Windows.Forms;

namespace PayrollPersonnelManagement.View.FormSave
{
    public partial class PhisicalFaceFormSave : Form
    {
        public PhisicalFaceControll ModelActions { get; set; }
        public PhisicalFaceFormSave(PhisicalFaceControll modelActions)
        {
            ModelActions = modelActions;
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
