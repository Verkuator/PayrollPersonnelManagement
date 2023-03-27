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
    }
}
