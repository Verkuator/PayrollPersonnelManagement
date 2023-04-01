using PayrollPersonnelManagement.Aplication.Controlls;
using System;

namespace PayrollPersonnelManagement.View.FormSave
{
    public partial class SubdivisionFormSave : FormAdapter
    {
        public SubdivisionFormSave()
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