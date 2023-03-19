using PayrollPersonnelManagement.Common;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PayrollPersonnelManagement.Infasrtucture.Configuration
{
    class PostConfiguration : EntityTypeConfiguration<Post>
    {
        public PostConfiguration()
        {
            ToTable("Post");

            HasKey(a => a.Id).Property(c => c.Id)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.Name).HasColumnName("Name").HasMaxLength(30).IsRequired();
            Property(c => c.Salary).HasColumnName("Salary").IsRequired();

        }
    }
}
