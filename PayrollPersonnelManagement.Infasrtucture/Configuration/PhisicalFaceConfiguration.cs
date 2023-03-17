using PayrollPersonnelManagement.Common;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PayrollPersonnelManagement.Infasrtucture.Configuration
{
    class PhisicalFaceConfiguration : EntityTypeConfiguration<PhisicalFace>
    {
        public PhisicalFaceConfiguration()
        {
            ToTable("PhisicalFace");

            HasKey(a => a.Id).Property(c => c.Id)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.Surname).HasColumnName("Surname").HasMaxLength(30).IsRequired();
            Property(c => c.Name).HasColumnName("Name").HasMaxLength(30).IsRequired();
            Property(c => c.Patronymic).HasColumnName("Patronymic").HasMaxLength(30);
            Property(c => c.DateBirth).HasColumnName("DateBirth").IsRequired();

        }
    }
}
