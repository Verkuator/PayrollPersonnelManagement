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
        [Browsable(false)]
        public int Id { get; set; }
        [DisplayName("Наименование")]
        public string Name { get; set; }
        [DisplayName("Надбавка")]
        public decimal Allowance { get; set; }

        public override string ToString()
        {
            string res = Name + " " + Allowance;
            return res;
        }
    }
}
