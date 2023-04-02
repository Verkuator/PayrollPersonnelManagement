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
        public virtual int Id { get; set; }
        [DisplayName("Дата")]
        public DateTime InDate { get; set; }
        [DisplayName("Часов в месяц")]
        public decimal HoursMonth { get; set; }
        [DisplayName("Сумма")]
        public decimal Sum { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
