using PayrollPersonnelManagement.Aplication.Dto;
using PayrollPersonnelManagement.Common;
using PayrollPersonnelManagement.Infasrtucture.Controlls;
using System;
using System.Windows.Forms;

namespace PayrollPersonnelManagement.View.FormSave
{
    public partial class PostFormSave : FormAdapter<PostDto>, IFormSave<Post>
    {
        public PostControll ModelActions { get; set; }
        public PostFormSave(PostControll modelActions)
        {
                ModelActions = modelActions;
                InitializeComponent();
        }

        public void CancelSimpleButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void DtoMapToForm()
        {
            if (Dto != null)
            {
                NameEdit.EditValue = Dto.Name;
                SalaryEdit.EditValue = Dto.Salary;
            }
        }

        public Post FormMapToModel()
        {
            var res = new Post();
            if (Dto != null)
            {
                res.Id = Dto.Id;
            }
            res.Name = NameEdit.Text;
            res.Salary = SalaryEdit.Value;
            return res;
        }

        public void NewAdd()
        {
            NameEdit.EditValue = null;
            SalaryEdit.EditValue = null;
        }

        private void PostFormSave_Load(object sender, EventArgs e)
        {
            DtoMapToForm();
        }

        private void SaveSimpleButton_Click(object sender, EventArgs e)
        {
            if (NameEdit.EditValue != null & SalaryEdit.EditValue != null)
            {
                var model = FormMapToModel();
                ModelActions.Save(model);
                Close();
            }
            
        }
    }
}
