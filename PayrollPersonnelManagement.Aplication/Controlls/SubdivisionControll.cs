using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PayrollPersonnelManagement.Aplication.Dto;
using PayrollPersonnelManagement.Common;
using PayrollPersonnelManagement.context;

namespace PayrollPersonnelManagement.Infasrtucture.Controlls
{
    public class SubdivisionControll : ModelActions<Subdivision, SubdivisionDto>
    {
        public override string Name { get; set; } = "Подразделения";
        public override DbSet<Subdivision> DbSet { get; set; }
        protected override PayrollPersonnelManagementContext DbContext { get; set; }
        public override IMapper Mapper { get; set; }

        public SubdivisionControll(PayrollPersonnelManagementContext dbContext,
            DbSet<Subdivision> dbSet,
            IMapper mapper)
            : base(dbContext, dbSet, mapper)
        {
        }

        public override void NewDbContext()
        {
            base.NewDbContext();
            DbSet = DbContext.Subdivisions;
        }
    }
}
