using System;

namespace PayrollPersonnelManagement.Common
{
    class OneAccrual
    {
        public int ID { get; set; }
        public string FIOPost { get { return _Employee.FIO + " " + _Employee.Post; } }
        public DateTime InDate { get; set; }
        public decimal HoursMonth { get; set; }
        public decimal Sum { get; set; }
        public Employee _Employee { get; set; }
    }
}
