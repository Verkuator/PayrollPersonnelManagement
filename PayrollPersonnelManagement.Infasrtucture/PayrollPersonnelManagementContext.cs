using Microsoft.EntityFrameworkCore;
using PayrollPersonnelManagement.Common;
using PayrollPersonnelManagement.Infasrtucture.Configuration;
using System.Configuration;
using System.IO;

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
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = "Data Source="+ Directory.GetCurrentDirectory()+ "\\PayrollPersonnelManagement.sqlite";
                optionsBuilder.UseSqlite(connectionString);
            }
        }


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
