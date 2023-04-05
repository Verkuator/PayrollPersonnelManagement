using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollPersonnelManagement.Aplication.Dto
{
    public class PhisicalFaceDto
    {
        [Browsable(false)]
        public int Id { get; set; }
        [DisplayName("Фамилия")]
        public string Surname { get; set; }
        [DisplayName("Имя")]
        public string Name { get; set; }
        [DisplayName("Отчество")]
        public string Patronymic { get; set; }
        [DisplayName("Дата рождения")]
        public DateTime DateBirth { get; set; }

        public override string ToString()
        {
            string res = Surname + " " + Name + " " + Patronymic;
            return res;
        }
    }
}
