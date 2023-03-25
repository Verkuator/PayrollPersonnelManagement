using PayrollPersonnelManagement.Common;
using PayrollPersonnelManagement.context;
using System.Collections.Generic;
using System.Linq;

namespace PayrollPersonnelManagement.Infasrtucture.Controll
{
    public class EmployeeControll
    {
        public static List<Employee> GetEmployeeList()
        {
            using (PayrollPersonnelManagementContext db = new PayrollPersonnelManagementContext())
            {
                var employees = db.Employees.ToList();
                return employees;
            }
        }
    }
}
