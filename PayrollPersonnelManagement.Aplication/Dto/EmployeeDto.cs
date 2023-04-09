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
        public PhisicalFaceDto PhisicalFace { get; set; }
        [DisplayName("ФИО")]
        public string Fio { get; set; }
        [Browsable(false)]
        public int SubdivisionId { get; set; }
        [Browsable(false)]
        public SubdivisionDto Subdivision { get; set; }
        [DisplayName("Отдел")]
        public string SubdivisionName { get; set; }
        [Browsable(false)]
        public int PostId { get; set; }
        [Browsable(false)]
        public PostDto Post { get; set; }
        [DisplayName("Должность")]
        public string PostName { get; set; }

        public override string ToString()
        {
            string res = Fio + " " + Subdivision + " " + Post;
            return res;
        }
    }
}
