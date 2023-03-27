using PayrollPersonnelManagement.Common;
using PayrollPersonnelManagement.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollPersonnelManagement.Infasrtucture.Controlls
{
    public class OneAccrualControll
    {
        private readonly PayrollPersonnelManagementContext _dbContext;

        public OneAccrualControll(PayrollPersonnelManagementContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<OneAccrual> GetOneAccrualsList()
        {
            var accrualList = _dbContext.OneAccrual.ToList();
            return accrualList;
        }
    }
}
