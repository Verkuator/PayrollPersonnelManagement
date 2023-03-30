using Microsoft.EntityFrameworkCore;
using PayrollPersonnelManagement.Aplication.Controlls;
using PayrollPersonnelManagement.Common;
using PayrollPersonnelManagement.context;
using PayrollPersonnelManagement.Infasrtucture.Controlls;
using System.Collections.Generic;
using System.Linq;

namespace PayrollPersonnelManagement.Infasrtucture.Controll
{
    public class EmployeeControll: IController<Employee>
    {
        public override string Name { get; set; }
        public override FormAdapter FormAdapter { get; set; }
        protected override DbSet<Employee> DbSet { get; set; }
        protected override PayrollPersonnelManagementContext DbContext { get; set; }
        
        public EmployeeControll(PayrollPersonnelManagementContext dbContext, FormAdapter form)
        {
            DbContext = dbContext;
            FormAdapter = form;
            DbSet = dbContext.Employees;
        }
    }
}
