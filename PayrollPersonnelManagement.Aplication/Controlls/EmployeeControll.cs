using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PayrollPersonnelManagement.Aplication.Controlls;
using PayrollPersonnelManagement.Aplication.Dto;
using PayrollPersonnelManagement.Common;
using PayrollPersonnelManagement.context;
using PayrollPersonnelManagement.Infasrtucture.Controlls;

namespace PayrollPersonnelManagement.Infasrtucture.Controll
{
    public class EmployeeControll : IController<Employee, EmployeeDto>
    {
        public override string Name { get; set; } = "Сотрудники";
        public override FormAdapter FormAdapter { get; set; }
        protected override DbSet<Employee> DbSet { get; set; }
        protected override PayrollPersonnelManagementContext DbContext { get; set; }
        public override IMapper Mapper { get; set; }

        public EmployeeControll(PayrollPersonnelManagementContext dbContext, FormAdapter form, IMapper mapper)
        {
            DbContext = dbContext;
            FormAdapter = form;
            DbSet = dbContext.Employees;
            Mapper = mapper;
        }
    }
}
