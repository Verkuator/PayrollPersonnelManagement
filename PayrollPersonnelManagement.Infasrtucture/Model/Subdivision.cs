
using PayrollPersonnelManagement.Infasrtucture.Model;
using System.Collections.Generic;

namespace PayrollPersonnelManagement.Common
{
    public class Subdivision : IModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Allowance { get; set; }
        public ICollection<Employee> Employee { get; set; }
    }
}
