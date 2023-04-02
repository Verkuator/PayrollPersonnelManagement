using PayrollPersonnelManagement.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollPersonnelManagement.Aplication.Dto
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public int PhisicalFaceId { get; set; }
        public PhisicalFace PhisicalFace { get; set; }
        public int SubdivisionId { get; set; }
        public Subdivision Subdivision { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
