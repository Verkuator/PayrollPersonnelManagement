using PayrollPersonnelManagement.Common;
using PayrollPersonnelManagement.context;
using PayrollPersonnelManagement.Infasrtucture.Controlls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollPersonnelManagement.Infasrtucture.Controll
{
    public class PhisicalFaceControll : IController<PhisicalFace>
    {
        private readonly PayrollPersonnelManagementContext _dbContext;

        public string Name { get; set; } = "PhisicalFace";

        public PhisicalFaceControll(PayrollPersonnelManagementContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ICollection<PhisicalFace> Get()
        {
            var phisicalFaces = _dbContext.PhisicalFaces.ToList();
            return phisicalFaces;
        }

        public PhisicalFace Save(PhisicalFace obj)
        {
            PhisicalFace phisicalFace = (PhisicalFace)obj;
            if (obj.Id == 0)
            {
                _dbContext.PhisicalFaces.Add(obj);
            }
            else
            {
                _dbContext.PhisicalFaces.Update(obj);
            }
            _dbContext.SaveChanges();
            return obj;
        }

        public void Delete(PhisicalFace obj)
        {
            _dbContext.PhisicalFaces.Remove(obj);
            _dbContext.SaveChanges();
        }
    }
}
