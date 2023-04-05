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

        public override string Name { get; set; } = "Сделки";
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
            var res = DbContext.OneAccrual
                .Include(c => c.Employee)
                .ThenInclude(c => c.PhisicalFace)
                .ToList();

            return res;
        }

    }
}
