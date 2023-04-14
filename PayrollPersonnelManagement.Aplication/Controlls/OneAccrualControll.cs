using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PayrollPersonnelManagement.Aplication.Dto;
using PayrollPersonnelManagement.Common;
using PayrollPersonnelManagement.context;
using System.Collections.Generic;
using System.Linq;

namespace PayrollPersonnelManagement.Infasrtucture.Controlls
{
    public class OneAccrualControll : ModelActions<OneAccrual, OneAccrualDto>
    {

        public override string Name { get; set; } = "Разовые начисления";
        public override DbSet<OneAccrual> DbSet { get; set; }
        protected override PayrollPersonnelManagementContext DbContext { get; set; }
        public override IMapper Mapper { get; set; }

        public OneAccrualControll(PayrollPersonnelManagementContext dbContext,
            DbSet<OneAccrual> dbSet,
            IMapper mapper)
            : base(dbContext, dbSet, mapper)
        {
        }

        public override List<OneAccrual> Get()
        {
            NewDbContext();
            var res = DbContext.OneAccrual
                .AsNoTracking()
                .Include(c => c.Employee)
                .ThenInclude(c => c.PhisicalFace)
                .Include(c => c.Employee)
                .ThenInclude(c => c.Post)
                .Include(c => c.Employee)
                .ThenInclude(c => c.Subdivision)
                .Where(c => !c.IsDelete)
                .ToList();

            return res;
        }

        public ICollection<EmployeeDto> GetEmployeeDtos()
        {
            var res = DbContext.Employees
                .Include(c => c.PhisicalFace)
                .Include(c => c.Subdivision)
                .Include(c => c.Post)
                .Where(c => !c.IsDelete)
                .AsNoTracking().ToList();
            return Mapper.Map<ICollection<EmployeeDto>>(res);
        }

        public override void NewDbContext()
        {
            base.NewDbContext();
            DbSet = DbContext.OneAccrual;
        }

    }
}
