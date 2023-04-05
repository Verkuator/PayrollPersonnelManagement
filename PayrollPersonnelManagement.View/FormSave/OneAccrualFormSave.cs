using PayrollPersonnelManagement.Aplication.Dto;
using PayrollPersonnelManagement.Common;
using PayrollPersonnelManagement.Infasrtucture.Controlls;
using System;
using System.Windows.Forms;

namespace PayrollPersonnelManagement.View.FormSave
{
    public partial class OneAccrualFormSave : FormAdapter<OneAccrualDto>, IFormSave<OneAccrual>
    {
        public OneAccrualControll ModelActions { get; set; }
        public OneAccrualFormSave(OneAccrualControll modelActions)
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

        public OneAccrual FormMapToModel()
        {
            throw new NotImplementedException();
        }
    }
}