using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollPersonnelManagement.Aplication.Dto
{
    public class SubdivisionDto
    {
        public virtual int Id { get; set; }
        [DisplayName("Название")]
        public string Name { get; set; }
        [DisplayName("Надбавка")]
        public decimal Allowance { get; set; }
    }
}
