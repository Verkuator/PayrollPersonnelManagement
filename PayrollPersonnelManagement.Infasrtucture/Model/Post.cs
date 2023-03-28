using System.Collections.Generic;

namespace PayrollPersonnelManagement.Common
{
    public class Post
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public ICollection<Employee> Employee { get; set; }
    }
}
