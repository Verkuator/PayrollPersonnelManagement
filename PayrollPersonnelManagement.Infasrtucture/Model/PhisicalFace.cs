using System;
using System.Collections.Generic;

namespace PayrollPersonnelManagement.Common
{
    public class PhisicalFace
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public DateTime DateBirth { get; set; }
        public ICollection<Employee> Employee { get; set; }
    }
}
