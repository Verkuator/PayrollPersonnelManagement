using PayrollPersonnelManagement.Common;
using PayrollPersonnelManagement.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollPersonnelManagement.Infasrtucture.Controll
{
    public class PhisicalFaceControll
    {
        public static List<PhisicalFace> GetPhisicalFaceList()
        {
            using (PayrollPersonnelManagementContext db =  new PayrollPersonnelManagementContext())
            {
                var phisicalFaces = db.PhisicalFaces.ToList();
                return phisicalFaces;
            }
        }

        public static void AddPhisicalFace(string surname, string name, string patronymic, DateTime birthDate)
        {
            using (PayrollPersonnelManagementContext db = new PayrollPersonnelManagementContext())
            {
                PhisicalFace person = new PhisicalFace() {Surname = surname, Name = name,
                                                          Patronymic = patronymic, DateBirth = birthDate};
                db.PhisicalFaces.Add(person);
                db.SaveChanges();
            }
        }
    }
}
