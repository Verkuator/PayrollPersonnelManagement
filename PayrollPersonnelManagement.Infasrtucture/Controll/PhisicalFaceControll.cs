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
        public PayrollPersonnelManagementContext _dbContext;

        public PhisicalFaceControll(PayrollPersonnelManagementContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<PhisicalFace> GetPhisicalFaceList()
        {
            var phisicalFaces = _dbContext.PhisicalFaces.ToList();
            return phisicalFaces;
        }

        public void AddPhisicalFace(string surname, string name, string patronymic, DateTime birthDate)
        {
            PhisicalFace person = new PhisicalFace()
            {
                Surname = surname,
                Name = name,
                Patronymic = patronymic,
                DateBirth = birthDate
            };
            _dbContext.PhisicalFaces.Add(person);
            _dbContext.SaveChanges();
        }
    }
}
