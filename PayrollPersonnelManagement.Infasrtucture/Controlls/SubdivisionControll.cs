using PayrollPersonnelManagement.Common;
using PayrollPersonnelManagement.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollPersonnelManagement.Infasrtucture.Controlls
{
    public class SubdivisionControll
    {
        private readonly PayrollPersonnelManagementContext _dbContext;

        public SubdivisionControll(PayrollPersonnelManagementContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Subdivision> GetSubdivisionsList()
        {
            var subdivisions = _dbContext.Subdivisions.ToList();
            return subdivisions;
        }

        public void AddSubdivision(Subdivision subdivision)
        {
            _dbContext.Add(subdivision);
            _dbContext.SaveChanges();
        }

        public void UpdateSubdivision(Subdivision subdivision)
        {
            _dbContext.Update(subdivision);
            _dbContext.SaveChanges();
        }

        public void RemoveSubdivision(Subdivision subdivision)
        {
            _dbContext.Remove(subdivision);
            _dbContext.SaveChanges();
        }
    }
}
