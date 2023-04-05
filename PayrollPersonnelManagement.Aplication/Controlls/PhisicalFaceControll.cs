using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PayrollPersonnelManagement.Aplication.Dto;
using PayrollPersonnelManagement.Common;
using PayrollPersonnelManagement.context;
using PayrollPersonnelManagement.Infasrtucture.Controlls;

namespace PayrollPersonnelManagement.Infasrtucture.Controll
{
    public class PhisicalFaceControll : ModelActions<PhisicalFace, PhisicalFaceDto>
    {
        public override string Name { get; set; } = "Физ. лица";
        public override DbSet<PhisicalFace> DbSet { get; set; }
        protected override PayrollPersonnelManagementContext DbContext { get; set; }
        public override IMapper Mapper { get; set; }

        public PhisicalFaceControll(PayrollPersonnelManagementContext dbContext,
            DbSet<PhisicalFace> dbSet,
            IMapper mapper)
            : base(dbContext, dbSet, mapper)
        {
        }
    }
}
