using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PayrollPersonnelManagement.Aplication.Controlls;
using PayrollPersonnelManagement.Aplication.Dto;
using PayrollPersonnelManagement.Common;
using PayrollPersonnelManagement.context;

namespace PayrollPersonnelManagement.Infasrtucture.Controlls
{
    public class OneAccrualControll : IController<OneAccrual, OneAccrualDto>
    {

        public override string Name { get; set; } = "Сделки";
        public override FormAdapter FormAdapter { get; set; }
        protected override DbSet<OneAccrual> DbSet { get; set; }
        protected override PayrollPersonnelManagementContext DbContext { get; set; }
        protected override IMapper Mapper { get; set; }

        public OneAccrualControll(PayrollPersonnelManagementContext dbContext, FormAdapter form)
        {
            DbContext = dbContext;
            FormAdapter = form;
            DbSet = dbContext.OneAccrual;
        }

    }
}
