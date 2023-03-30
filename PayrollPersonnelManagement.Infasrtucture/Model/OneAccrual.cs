using PayrollPersonnelManagement.Infasrtucture.Model;
using System;

namespace PayrollPersonnelManagement.Common
{
    public class OneAccrual : IModel
    {
        public int Id { get; set; }
        public DateTime InDate { get; set; }
        public decimal HoursMonth { get; set; }
        public decimal Sum { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
