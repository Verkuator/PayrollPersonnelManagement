using PayrollPersonnelManagement.Common;
using PayrollPersonnelManagement.CreateSQLite;
using PayrollPersonnelManagement.Infasrtucture.Configuration;
using System.Data.Entity;

namespace PayrollPersonnelManagement.context
{
    class PayrollPersonnelManagementContext : DbContext
    {
        PayrollPersonnelManagementContext(): base(SQLiteCreateDb.ConnectionSring)
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
        }



    }
}
