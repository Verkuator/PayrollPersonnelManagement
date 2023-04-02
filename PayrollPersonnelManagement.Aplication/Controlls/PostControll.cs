using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PayrollPersonnelManagement.Aplication.Controlls;
using PayrollPersonnelManagement.Aplication.Dto;
using PayrollPersonnelManagement.Common;
using PayrollPersonnelManagement.context;

namespace PayrollPersonnelManagement.Infasrtucture.Controlls
{
    public class PostControll : IController<Post, PostDto>
    {
        public override string Name { get; set; } = "Должности";
        public override FormAdapter FormAdapter { get; set; }
        protected override DbSet<Post> DbSet { get; set; }
        protected override PayrollPersonnelManagementContext DbContext { get; set; }
        public override IMapper Mapper { get; set; }

        public PostControll(PayrollPersonnelManagementContext dbContext, FormAdapter form)
        {
            DbContext = dbContext;
            FormAdapter = form;
            DbSet = dbContext.Posts;
        }
    }
}
