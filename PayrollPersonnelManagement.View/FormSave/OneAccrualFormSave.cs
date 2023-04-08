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
            var model = FormMapToModel();
            ModelActions.Save(model);
            Close();
        }

        public void CancelSimpleButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void DtoMapToForm()
        {
            if (Dto != null)
            {
                dateEdit1.EditValue = Dto.InDate;
                HoursEdit.EditValue = Dto.HoursMonth;
                SumEdit.EditValue = Dto.Sum;
                EmployeeEdit.EditValue = Dto.Employee;
            }
        }

        public OneAccrual FormMapToModel()
        {
            var res = new OneAccrual();
            if (Dto != null)
            {
                res.Id = Dto.Id;
                res.InDate = Dto.InDate;
                res.HoursMonth = Dto.HoursMonth;
                res.Sum = Dto.Sum;
            }
            res.EmployeeId = ((EmployeeDto)EmployeeEdit.EditValue).Id;
            return res;
        }

        public void NewAdd()
        {
            dateEdit1.EditValue = null;
            HoursEdit.EditValue = null;
            SumEdit.EditValue = null;
            EmployeeEdit.EditValue = null;
        }

        private void OneAccrualFormSave_Load(object sender, EventArgs e)
        {
            var employees = ModelActions.GetEmployeeDtos();

            EmployeeEdit.Properties.DataSource = employees;
            DtoMapToForm();
        }
    }
}