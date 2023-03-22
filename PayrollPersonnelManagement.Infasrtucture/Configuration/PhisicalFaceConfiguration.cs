using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PayrollPersonnelManagement.Common;

namespace PayrollPersonnelManagement.Infasrtucture.Configuration
{
    class PhisicalFaceConfiguration : IEntityTypeConfiguration<PhisicalFace>
    {

        public void Configure(EntityTypeBuilder<PhisicalFace> builder)
        {
            builder.ToTable("PhisicalFace");

            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();

            builder.Property(c => c.Surname).HasColumnName("Surname").HasMaxLength(30).IsRequired();
            builder.Property(c => c.Name).HasColumnName("Name").HasMaxLength(30).IsRequired();
            builder.Property(c => c.Patronymic).HasColumnName("Patronymic").HasMaxLength(30);
            builder.Property(c => c.DateBirth).HasColumnName("DateBirth").IsRequired();

        }
    }
}
