using Microsoft.EntityFrameworkCore;
using PayrollPersonnelManagement.Aplication.Controlls;
using PayrollPersonnelManagement.Common;
using PayrollPersonnelManagement.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollPersonnelManagement.Infasrtucture.Controlls
{
    public class OneAccrualControll: IController<OneAccrual>
    {

        public override string Name { get; set; }
        public override FormAdapter FormAdapter { get; set; }
        protected override DbSet<OneAccrual> DbSet { get; set; }
        protected override PayrollPersonnelManagementContext DbContext { get; set; }
        
        public OneAccrualControll(PayrollPersonnelManagementContext dbContext, FormAdapter form)
        {
            DbContext = dbContext;
            FormAdapter = form;
            DbSet = dbContext.OneAccrual;
        }

    }
}
