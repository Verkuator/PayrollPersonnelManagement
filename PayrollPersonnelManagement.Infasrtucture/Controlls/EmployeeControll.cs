using PayrollPersonnelManagement.Common;
using PayrollPersonnelManagement.context;
using System.Collections.Generic;
using System.Linq;

namespace PayrollPersonnelManagement.Infasrtucture.Controll
{
    public class EmployeeControll
    {
        private readonly PayrollPersonnelManagementContext _dbContext;

        public EmployeeControll(PayrollPersonnelManagementContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Employee> GetEmployeeList()
        {
            var employees = _dbContext.Employees.ToList();
            return employees;
        }
    }
}
