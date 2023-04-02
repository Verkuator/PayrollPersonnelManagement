using PayrollPersonnelManagement.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollPersonnelManagement.Aplication.Dto
{
    public class EmployeeDto
    {
        [Browsable(false)]
        public int Id { get; set; }
        [Browsable(false)]
        public int PhisicalFaceId { get; set; }
        [Browsable(false)]
        [DisplayName("ФИО")]
        public string Fio { get; set; }
        [Browsable(false)]
        public int SubdivisionId { get; set; }
        [DisplayName("Отдел")]
        public string Subdivision { get; set; }
        [Browsable(false)]
        public int PostId { get; set; }
        [DisplayName("Должность")]
        public string Post { get; set; }
    }
}
