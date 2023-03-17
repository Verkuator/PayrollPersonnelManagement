using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollPersonnelManagement.Common
{
    class Employee
    {
        public int Id { get; set; }
        public PhisicalFace PhisicalFace { get; set; }
        public Subdivision Subdivision { get; set; }
        public Post Post { get; set; }
    }
}
