using System;

namespace PayrollPersonnelManagement.Common
{
    public class OneAccrual
    {
        public int Id { get; set; }
        public DateTime InDate { get; set; }
        public decimal HoursMonth { get; set; }
        public decimal Sum { get; set; }
        public Employee Employee { get; set; }
    }
}
