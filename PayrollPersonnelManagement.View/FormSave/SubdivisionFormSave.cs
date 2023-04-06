using PayrollPersonnelManagement.Aplication.Dto;
using PayrollPersonnelManagement.Common;
using PayrollPersonnelManagement.Infasrtucture.Controlls;
using System;
using System.Windows.Forms;

namespace PayrollPersonnelManagement.View.FormSave
{
    public partial class SubdivisionFormSave : FormAdapter<SubdivisionDto>, IFormSave<Subdivision>
    {
        public SubdivisionControll ModelActions { get; set; }
        public SubdivisionFormSave(SubdivisionControll modelActions)
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

        }

        public void DtoMapToForm()
        {
            throw new NotImplementedException();
        }

        public Subdivision FormMapToModel()
        {
            throw new NotImplementedException();
        }

        public void NewAdd()
        {
            throw new NotImplementedException();
        }
    }
}