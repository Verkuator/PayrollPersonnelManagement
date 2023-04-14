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
            if (SurnameTextEd.EditValue != null & NameTextEd.EditValue != null & 
                PatronymicTextEd.EditValue != null & DateBirthDateEdit.EditValue != null)
            {
                var model = FormMapToModel();
                ModelActions.Save(model);
                Close();
            }
            
        }

        public void CancelSimpleButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void DtoMapToForm()
        {
            if (Dto != null)
            {
                SurnameTextEd.EditValue = Dto.Surname;
                NameTextEd.EditValue = Dto.Name;
                PatronymicTextEd.EditValue = Dto.Patronymic;
                DateBirthDateEdit.EditValue = Dto.DateBirth;
            }
        }

        public PhisicalFace FormMapToModel()
        {
           var res = new PhisicalFace();
           if (Dto != null)
           {
                res.Id = Dto.Id;
           }
            res.Surname = SurnameTextEd.Text;
            res.Name = NameTextEd.Text;
            res.Patronymic = PatronymicTextEd.Text;
            res.DateBirth = DateBirthDateEdit.DateTime;
            return res;
        }

        private void PhisicalFaceFormSave_Load(object sender, EventArgs e)
        {
            DtoMapToForm();
        }

        public void NewAdd()
        {
            SurnameTextEd.EditValue = null;
            NameTextEd.EditValue = null;
            PatronymicTextEd.EditValue = null;
            DateBirthDateEdit.EditValue = null;
        }
    }
}
