using Microsoft.EntityFrameworkCore;
using PayrollPersonnelManagement.Aplication.Controlls;
using PayrollPersonnelManagement.Common;
using PayrollPersonnelManagement.context;
using PayrollPersonnelManagement.Infasrtucture.Controlls;
using PayrollPersonnelManagement.Infasrtucture.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollPersonnelManagement.Infasrtucture.Controll
{
    public class PhisicalFaceControll : IController<PhisicalFace>
    {
        public override string Name { get; set ; }
        public override FormAdapter FormAdapter { get; set; }
        protected override DbSet<PhisicalFace> DbSet { get; set; }
        protected override PayrollPersonnelManagementContext DbContext { get; set; }
        
        public PhisicalFaceControll(PayrollPersonnelManagementContext dbContext, FormAdapter form)
        {
                    DbContext = dbContext;
                    FormAdapter = form;
                    DbSet = dbContext.PhisicalFaces;
        }
    }
}
