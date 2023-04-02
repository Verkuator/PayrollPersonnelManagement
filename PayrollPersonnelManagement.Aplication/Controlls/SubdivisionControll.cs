using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PayrollPersonnelManagement.Aplication.Controlls;
using PayrollPersonnelManagement.Aplication.Dto;
using PayrollPersonnelManagement.Common;
using PayrollPersonnelManagement.context;

namespace PayrollPersonnelManagement.Infasrtucture.Controlls
{
    public class SubdivisionControll : IController<Subdivision, SubdivisionDto>
    {
        public override string Name { get; set; } = "Отделы";
        public override FormAdapter FormAdapter { get; set; }
        protected override DbSet<Subdivision> DbSet { get; set; }
        protected override PayrollPersonnelManagementContext DbContext { get; set; }
        protected override IMapper Mapper { get; set; }

        public SubdivisionControll(PayrollPersonnelManagementContext dbContext, FormAdapter form)
        {
            DbContext = dbContext;
            FormAdapter = form;
            DbSet = dbContext.Subdivisions;

        }
    }
}
