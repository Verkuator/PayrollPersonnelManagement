using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PayrollPersonnelManagement.Common;

namespace PayrollPersonnelManagement.Infasrtucture.Configuration
{
    class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {

        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee");

            builder.HasKey(a => a.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();

            builder.HasOne(a => a.PhisicalFace).WithMany(c => c.Employee).HasForeignKey(c => c.PhisicalFaceId);
            builder.HasOne(a => a.Subdivision).WithMany(c => c.Employee).HasForeignKey(c => c.SubdivisionId);
            builder.HasOne(a => a.Post).WithMany(c => c.Employee).HasForeignKey(c => c.PostId);
        }
    }
}
