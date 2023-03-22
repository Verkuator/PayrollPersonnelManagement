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

            builder.HasOne(a => a.PhisicalFace);
            builder.HasOne(a => a.Subdivision);
            builder.HasOne(a => a.Post);
        }
    }
}
