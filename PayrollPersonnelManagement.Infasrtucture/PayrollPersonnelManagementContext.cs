using Microsoft.EntityFrameworkCore;
using PayrollPersonnelManagement.Common;
using PayrollPersonnelManagement.Infasrtucture.Configuration;

namespace PayrollPersonnelManagement.context
{
    public class PayrollPersonnelManagementContext : DbContext
    {
        public PayrollPersonnelManagementContext()
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<OneAccrual> OneAccrual { get; set; }
        public DbSet<PhisicalFace> PhisicalFaces { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Subdivision> Subdivisions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=D:\\PayrollPersonnelManagement.sqlite");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new PhisicalFaceConfiguration());
            modelBuilder.ApplyConfiguration(new OneAccrualConfiguration());
            modelBuilder.ApplyConfiguration(new PostConfiguration());
            modelBuilder.ApplyConfiguration(new SubdivisionConfiguration());
        }



    }
}
