using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollPersonnelManagement.context
{
    class Model1 : DbContext
    {
        public DbSet<PayrollPersonnelManagement.Common.Employee> Employees { get; set; }
    }

    class OneAccrualContext : DbContext
    {
        public DbSet<PayrollPersonnelManagement.Common.OneAccrual> Employees { get; set; }
    }

    class PhisicalFaceContext : DbContext
    {
        public DbSet<PayrollPersonnelManagement.Common.PhisicalFace> PhisicalFaces { get; set; }
    }

    class PostContext : DbContext
    {
        public DbSet<PayrollPersonnelManagement.Common.Post> Posts { get; set; }
    }

    class SubdivisionContext : DbContext
    {
        public DbSet<PayrollPersonnelManagement.Common.Subdivision> Subdivisions { get; set; }
    }
}
