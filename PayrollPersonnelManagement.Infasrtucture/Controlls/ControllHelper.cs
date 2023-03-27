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
        public ControllHelper(PayrollPersonnelManagementContext dbContext)
        {
            PhisicalFaceControll = new PhisicalFaceControll(dbContext);
            EmployeeControll = new EmployeeControll(dbContext);
            OneAccrualControll = new OneAccrualControll(dbContext);
            PostControll = new PostControll(dbContext);
            SubdivisionControll = new SubdivisionControll(dbContext);
        }
        PhisicalFaceControll PhisicalFaceControll { get; set; }
        EmployeeControll EmployeeControll { get; set; }
        OneAccrualControll OneAccrualControll { get; set; }
        PostControll PostControll { get; set; }
        SubdivisionControll SubdivisionControll { get; set; }

    }
}
