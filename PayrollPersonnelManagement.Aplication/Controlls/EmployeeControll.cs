using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PayrollPersonnelManagement.Aplication.Dto;
using PayrollPersonnelManagement.Common;
using PayrollPersonnelManagement.context;
using PayrollPersonnelManagement.Infasrtucture.Controlls;
using System.Collections.Generic;
using System.Linq;

namespace PayrollPersonnelManagement.Infasrtucture.Controll
{
    public class EmployeeControll : ModelActions<Employee, EmployeeDto>
    {
        public override string Name { get; set; } = "Сотрудники";
        public override DbSet<Employee> DbSet { get; set; }
        protected override PayrollPersonnelManagementContext DbContext { get; set; }
        public override IMapper Mapper { get; set; }

        public EmployeeControll(PayrollPersonnelManagementContext dbContext, DbSet<Employee> dbSet,  IMapper mapper)
            : base(dbContext, dbSet, mapper)
        {

        }

        public override void NewDbContext()
        {
            base.NewDbContext();
            DbSet = DbContext.Employees;
        }

        public override List<Employee> Get()
        {
            NewDbContext();
            var res = DbSet
                .AsNoTracking()
                .Include(c => c.PhisicalFace)
                .Include(c => c.Subdivision)
                .Include(c => c.Post)
                .Where(c => !c.IsDelete)
                .ToList();

            res.ForEach(c =>
            {
                c.PhisicalFace.Employee = null;
                c.Subdivision.Employee = null;
                c.Post.Employee = null;
            });

            return res;
        }

        public ICollection<PhisicalFaceDto> GetPhisicalFaceDtos()
        {
            var res = DbContext.PhisicalFaces.AsNoTracking().Where(c => !c.IsDelete).ToList();
            return Mapper.Map<ICollection<PhisicalFaceDto>>(res);
        }

        public ICollection<PostDto> GetPostsDtos()
        {
            var res = DbContext.Posts.AsNoTracking().Where(c => !c.IsDelete).ToArray();
            return Mapper.Map<ICollection<PostDto>>(res);
        }

        public ICollection<SubdivisionDto> GetSubdivisionsDtos()
        {
            var res = DbContext.Subdivisions.AsNoTracking().Where(c => !c.IsDelete).ToArray();
            return Mapper.Map<ICollection<SubdivisionDto>>(res);
        }        
    }
}
