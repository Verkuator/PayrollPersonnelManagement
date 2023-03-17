using PayrollPersonnelManagement.Common;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PayrollPersonnelManagement.Infasrtucture.Configuration
{
    class EmployeeConfiguration : EntityTypeConfiguration<Employee>
    {
        public EmployeeConfiguration()
        {
            ToTable("Employee");

            HasKey(a => a.Id).Property(c => c.Id)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasRequired(a => a.PhisicalFace);

            HasRequired(a => a.Subdivision);

            HasRequired(a => a.Post);

        }
    }
}
