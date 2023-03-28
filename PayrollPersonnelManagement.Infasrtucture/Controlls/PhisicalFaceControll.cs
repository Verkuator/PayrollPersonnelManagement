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
        private readonly PayrollPersonnelManagementContext _dbContext;

        public PhisicalFaceControll(PayrollPersonnelManagementContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<PhisicalFace> GetPhisicalFaceList()
        {
            var phisicalFaces = _dbContext.PhisicalFaces.ToList();
            return phisicalFaces;
        }

        public void AddPhisicalFace(PhisicalFace phisicalFace)
        {
            _dbContext.PhisicalFaces.Add(phisicalFace);
            _dbContext.SaveChanges();
        }

        public void UpdatePhisicalFace(PhisicalFace phisicalFace)
        {
            _dbContext.Update(phisicalFace);
            _dbContext.SaveChanges();
        }
        
        public void RemovePhisicalFace(PhisicalFace phisicalFace) 
        {
            _dbContext.Remove(phisicalFace);
            _dbContext.SaveChanges();
        }
    }
}
