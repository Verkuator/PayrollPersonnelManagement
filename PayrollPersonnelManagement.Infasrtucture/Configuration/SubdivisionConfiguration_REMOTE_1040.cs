using PayrollPersonnelManagement.Common;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PayrollPersonnelManagement.Infasrtucture.Configuration
{
    class SubdivisionConfiguration : EntityTypeConfiguration<Subdivision>
    {
        public SubdivisionConfiguration()
        {
            ToTable("Subdivision");

            HasKey(a => a.Id).Property(c => c.Id)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.Name).HasColumnName("Name").HasMaxLength(30).IsRequired();
            Property(c => c.Allowance).HasColumnName("Allowance").IsRequired();
        }
    }
}
