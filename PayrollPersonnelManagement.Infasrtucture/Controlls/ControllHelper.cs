using Microsoft.EntityFrameworkCore;
using PayrollPersonnelManagement.context;
using PayrollPersonnelManagement.Infasrtucture.Controlls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollPersonnelManagement.Infasrtucture.Controll
{
    public class ControllHelper
    {
        public static PhisicalFaceControll PhisicalFaceControll { get; set; }
        public static EmployeeControll EmployeeControll { get; set; }
        public static OneAccrualControll OneAccrualControll { get; set; }
        public static PostControll PostControll { get; set; }
        public static SubdivisionControll SubdivisionControll { get; set; }

        public ControllHelper (PayrollPersonnelManagementContext dbContext)
        {
            PhisicalFaceControll = new PhisicalFaceControll(dbContext);
            EmployeeControll = new EmployeeControll(dbContext);
            OneAccrualControll = new OneAccrualControll(dbContext);
            PostControll = new PostControll(dbContext);
            SubdivisionControll = new SubdivisionControll(dbContext);
        }        

    }
}
