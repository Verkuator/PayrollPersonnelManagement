using PayrollPersonnelManagement.Aplication.Dto;
using PayrollPersonnelManagement.Common;
using PayrollPersonnelManagement.Infasrtucture.Controll;
using PayrollPersonnelManagement.Infasrtucture.Controlls;
using System;
using System.Windows.Forms;

namespace PayrollPersonnelManagement.View.FormSave
{
    public partial class PhisicalFaceFormSave : FormAdapter<PhisicalFaceDto>, IFormSave<PhisicalFace>
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

        public void DtoMapToForm()
        {
            throw new NotImplementedException();
        }

        public PhisicalFace FormMapToModel()
        {
            throw new NotImplementedException();
        }
    }
}
