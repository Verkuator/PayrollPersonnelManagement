using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollPersonnelManagement.Aplication.Dto
{
    public class PostDto
    {
        public virtual int Id { get; set; }
        [DisplayName("Название")]
        public string Name { get; set; }
        [DisplayName("Зарплата")]
        public decimal Salary { get; set; }
    }
}
