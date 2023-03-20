using PayrollPersonnelManagement.Common;
using PayrollPersonnelManagement.CreateSQLite;
using PayrollPersonnelManagement.Infasrtucture.Configuration;
using System.Data.Entity;

namespace PayrollPersonnelManagement.context
{
    class PayrollPersonnelManagementContext : DbContext
    {
        public PayrollPersonnelManagementContext(): base("Data Source=" + "PayrollPersonnelManagement.sqlite" + ";")
        {
        }


        public DbSet<Employee> Employees { get; set; }
        public DbSet<OneAccrual> OneAccrual { get; set; }
        public DbSet<PhisicalFace> PhisicalFaces { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Subdivision> Subdivisions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EmployeeConfiguration());
            modelBuilder.Configurations.Add(new PhisicalFaceConfiguration());
            modelBuilder.Configurations.Add(new OneAccrualConfiguration());
            modelBuilder.Configurations.Add(new PostConfiguration());
            modelBuilder.Configurations.Add(new SubdivisionConfiguration());
        }



    }
}
