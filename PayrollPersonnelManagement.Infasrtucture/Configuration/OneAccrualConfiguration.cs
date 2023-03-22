using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PayrollPersonnelManagement.Common;

namespace PayrollPersonnelManagement.Infasrtucture.Configuration
{
    class OneAccrualConfiguration : IEntityTypeConfiguration<OneAccrual>
    {

        public void Configure(EntityTypeBuilder<OneAccrual> builder)
        {
            builder.ToTable("OneAccrual");

            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();

            builder.Property(c => c.InDate).HasColumnName("InDate").IsRequired();
            builder.Property(c => c.HoursMonth).HasColumnName("HoursMonth").IsRequired();
            builder.Property(c => c.Sum).HasColumnName("Sum").IsRequired();
            builder.HasOne(a => a.Employee);
        }
    }
}
