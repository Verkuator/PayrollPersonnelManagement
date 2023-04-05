using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PayrollPersonnelManagement.Aplication.Dto;
using PayrollPersonnelManagement.Common;
using PayrollPersonnelManagement.context;

namespace PayrollPersonnelManagement.Infasrtucture.Controlls
{
    public class PostControll : ModelActions<Post, PostDto>
    {
        public override string Name { get; set; } = "Должности";
        public override DbSet<Post> DbSet { get; set; }
        protected override PayrollPersonnelManagementContext DbContext { get; set; }
        public override IMapper Mapper { get; set; }

        public PostControll(PayrollPersonnelManagementContext dbContext,
            DbSet<Post> dbSet,
            IMapper mapper)
            : base(dbContext, dbSet, mapper)
        {
        }
    }
}
