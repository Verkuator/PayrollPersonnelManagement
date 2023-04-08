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

        public void DtoMapToForm()
        {
            if (Dto != null)
            {
                NameEdit.EditValue = Dto.Name;
                SalaryEdit.EditValue = Dto.Allowance;
            }
        }

        public Subdivision FormMapToModel()
        {
            var res = new Subdivision();
            if (Dto != null)
            {
                res.Id = Dto.Id;
            }
            res.Name = NameEdit.Text;
            res.Allowance = SalaryEdit.Value;
            return res;
        }

        public void NewAdd()
        {
            NameEdit.EditValue = null;
            SalaryEdit.EditValue = null;
        }

        private void SubdivisionFormSave_Load(object sender, EventArgs e)
        {
            DtoMapToForm();
        }

        private void SaveSimpleButton_Click(object sender, EventArgs e)
        {
            var model = FormMapToModel();
            ModelActions.Save(model);
            Close();
        }

        private void CancelSimpleButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}