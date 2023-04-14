using PayrollPersonnelManagement.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollPersonnelManagement.Aplication.Dto
{
    public class OneAccrualDto
    {
        [Browsable(false)]
        public int Id { get; set; }
        [DisplayName("Дата начисления")]
        public DateTime InDate { get; set; }
        [DisplayName("Часов в месяц")]
        public decimal HoursMonth { get; set; }
        [DisplayName("Сумма")]
        public decimal Sum { get; set; }
        [Browsable(false)]
        public int EmployeeId { get; set; }
        [DisplayName("Сотрудник")]
        public string EmployeeName { get; set; }
        [Browsable(false)]
        public EmployeeDto Employee { get; set; }
    }
}
