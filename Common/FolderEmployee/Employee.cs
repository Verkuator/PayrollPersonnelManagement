using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollPersonnelManagement.Common
{
    class Employee
    {
        public int ID { get; set; }

        public string FIO 
        {
            get { return _PhisicalFace.Surname + " " + _PhisicalFace.Name + " " + _PhisicalFace.Patronymic; }
        }

        public string Subdivision 
        {
            get { return _Subdivision.Name; }
        }
        public string Post 
        {
            get { return _Post.Name; }
        }
        public PhisicalFace _PhisicalFace { get; set; }
        public Subdivision _Subdivision { get; set; }
        public Post _Post { get; set; }
    }
}
