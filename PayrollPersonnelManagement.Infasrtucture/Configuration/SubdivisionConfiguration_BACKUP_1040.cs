using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PayrollPersonnelManagement.Common;

namespace PayrollPersonnelManagement.Infasrtucture.Configuration
{
    class SubdivisionConfiguration : IEntityTypeConfiguration<Subdivision>
    {
        public void Configure(EntityTypeBuilder<Subdivision> builder)
        {
<<<<<<< HEAD
            builder.ToTable("Subdivision");
=======
            ToTable("Subdivision");
>>>>>>> fb37df099de96f13bc1072199d4ee2062d525c74

            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();

            builder.Property(c => c.Name).HasColumnName("Name").HasMaxLength(30).IsRequired();
            builder.Property(c => c.Allowance).HasColumnName("Allowance").IsRequired();
        }
    }
}
