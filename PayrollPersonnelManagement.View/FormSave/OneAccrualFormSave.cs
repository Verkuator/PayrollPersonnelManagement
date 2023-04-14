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
        private decimal sum = 0;
        public OneAccrualFormSave(OneAccrualControll modelActions)
        {
            ModelActions = modelActions;
            InitializeComponent();
        }

        public void DtoMapToForm()
        {
            if (Dto != null)
            {
                dateEdit1.EditValue = Dto.InDate;
                HoursEdit.EditValue = Dto.HoursMonth;

                var EmployeeEditData = (ICollection<EmployeeDto>)EmployeeEdit.Properties.DataSource;
                if (!EmployeeEditData.Select(c => c.Id).Contains(Dto.EmployeeId))
                    EmployeeEditData.Add(Dto.Employee);
                EmployeeEdit.EditValue = EmployeeEditData.Select((elem, index) => new { elem, index })
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
            res.Sum = sum;
            res.InDate = dateEdit1.DateTime;
            res.HoursMonth = HoursEdit.Value;
            res.EmployeeId = ((EmployeeDto)EmployeeEdit.EditValue).Id;
            return res;
        }

        public void NewAdd()
        {
            dateEdit1.EditValue = null;
            HoursEdit.EditValue = null;
            EmployeeEdit.EditValue = null;
            TotalSum.Text = "0 р";
        }

        private void OneAccrualFormSave_Load(object sender, EventArgs e)
        {
            var employees = ModelActions.GetEmployeeDtos();

            EmployeeEdit.Properties.DataSource = employees;
            DtoMapToForm();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (dateEdit1.EditValue != null &&
                HoursEdit.EditValue != null &&
                EmployeeEdit.EditValue != null)
            {
                var model = FormMapToModel();
                ModelActions.Save(model);
                Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if(EmployeeEdit.EditValue != null)
            {
                EmployeeDto employee = (EmployeeDto)EmployeeEdit.EditValue;
                int workingDays = GetWorkingDaysInCurrentMonth();
                int workingHoursInMonth = workingDays * 8;
                decimal hourlyRate = employee.Post.Salary / workingHoursInMonth;
                decimal totalSum = hourlyRate * HoursEdit.Value * employee.Subdivision.Allowance;
                TotalSum.Text = Math.Round(totalSum, 3).ToString() + " р";
                sum = Math.Round(totalSum, 3);
            }
            

        }

        public int GetWorkingDaysInCurrentMonth()
        {
            int workingDays = 0;
            DateTime currentDate = dateEdit1.DateTime;
            int daysInMonth = DateTime.DaysInMonth(currentDate.Year, currentDate.Month);

            for (int i = 1; i <= daysInMonth; i++)
            {
                DateTime day = new DateTime(currentDate.Year, currentDate.Month, i);

                if (day.DayOfWeek != DayOfWeek.Saturday && day.DayOfWeek != DayOfWeek.Sunday)
                {
                    workingDays++;
                }
            }

            return workingDays;
        }
    }
}