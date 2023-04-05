using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PayrollPersonnelManagement.Aplication.Dto;
using PayrollPersonnelManagement.Common;
using PayrollPersonnelManagement.context;
using PayrollPersonnelManagement.Infasrtucture.Controlls;

namespace PayrollPersonnelManagement.Infasrtucture.Controll
{
    public class EmployeeControll : ModelActions<Employee, EmployeeDto>
    {
        public override string Name { get; set; } = "Сотрудники";
        protected override DbSet<Employee> DbSet { get; set; }
        protected override PayrollPersonnelManagementContext DbContext { get; set; }
        public override IMapper Mapper { get; set; }

        public EmployeeControll(PayrollPersonnelManagementContext dbContext, DbSet<Employee> dbSet,  IMapper mapper)
            : base(dbContext, dbSet, mapper)
        {

        }
    }
}
