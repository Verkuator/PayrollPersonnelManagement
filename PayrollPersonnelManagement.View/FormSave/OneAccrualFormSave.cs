using PayrollPersonnelManagement.Aplication.Dto;
using PayrollPersonnelManagement.Common;
using PayrollPersonnelManagement.Infasrtucture.Controlls;
using System;
using System.Collections.Generic;
using System.Linq;
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
                EmployeeEdit.EditValue = ((ICollection<EmployeeDto>)EmployeeEdit.Properties.DataSource).Select((elem, index) => new { elem, index })
                        .First(p => p.elem.Id == Dto.EmployeeId)
                        .elem;
                
                EmployeeEdit.RefreshEditValue();
            }
        }

        public OneAccrual FormMapToModel()
        {
            var res = new OneAccrual();
            if (Dto != null)
            {
                res.Id = Dto.Id;
            }
            res.InDate = dateEdit1.DateTime;
            res.HoursMonth = HoursEdit.Value;
            res.Sum = SumEdit.Value;
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