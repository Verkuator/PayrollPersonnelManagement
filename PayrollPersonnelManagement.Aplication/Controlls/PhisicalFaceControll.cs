using Microsoft.EntityFrameworkCore;
using PayrollPersonnelManagement.Aplication.Controlls;
using PayrollPersonnelManagement.Common;
using PayrollPersonnelManagement.context;
using PayrollPersonnelManagement.Infasrtucture.Controlls;

namespace PayrollPersonnelManagement.Infasrtucture.Controll
{
    public class PhisicalFaceControll : IController<PhisicalFace>
    {
        public override string Name { get; set; } = "Физ. лица";
        public override FormAdapter FormAdapter { get; set; }
        protected override DbSet<PhisicalFace> DbSet { get; set; }
        protected override PayrollPersonnelManagementContext DbContext { get; set; }

        public PhisicalFaceControll(PayrollPersonnelManagementContext dbContext, FormAdapter form)
        {
            DbContext = dbContext;
            FormAdapter = form;
            DbSet = dbContext.PhisicalFaces;
        }
    }
}
