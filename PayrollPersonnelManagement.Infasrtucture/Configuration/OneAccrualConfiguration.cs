using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using PayrollPersonnelManagement.Common;

namespace PayrollPersonnelManagement.Infasrtucture.Configuration
{
    class OneAccrualConfiguration : EntityTypeConfiguration<OneAccrual>
    {
        public OneAccrualConfiguration()
        {
            ToTable("OneAccrual");

            HasKey(a => a.Id).Property(c => c.Id)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.InDate).HasColumnName("InDate").IsRequired();
            Property(c => c.HoursMonth).HasColumnName("HoursMonth").IsRequired();
            Property(c => c.Sum).HasColumnName("Sum").IsRequired();
            HasRequired(a => a.Employee);

        }
    }
}
