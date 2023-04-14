using AutoMapper;
using PayrollPersonnelManagement.Aplication.Dto;
using PayrollPersonnelManagement.Common;

namespace PayrollPersonnelManagement.Aplication.AutotMapper
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<PhisicalFace, PhisicalFaceDto>().ReverseMap()
                .ForMember(c => c.Employee, c => c.Ignore());

            CreateMap<OneAccrual, OneAccrualDto>()
                .ForMember(c => c.EmployeeName, c => c.MapFrom(b => b.Employee.PhisicalFace.ToString()))
                .ForMember(c => c.Employee, c => c.MapFrom(b => b.Employee))
                .ReverseMap()
                .ForMember(c => c.Employee, c => c.Ignore());

            CreateMap<Employee, EmployeeDto>()
                .ForMember(c => c.SubdivisionName, c => c.MapFrom(b => b.Subdivision.ToString()))
                .ForMember(c => c.PostName, c => c.MapFrom(b => b.Post.ToString()))
                .ForMember(c => c.Fio, c => c.MapFrom(b => b.PhisicalFace.ToString()))
                .ReverseMap()
                .ForMember(c => c.OneAccrual, c => c.Ignore());

            CreateMap<Post, PostDto>().ReverseMap()
                .ForMember(c => c.Employee, c => c.Ignore());

            CreateMap<Subdivision, SubdivisionDto>().ReverseMap()
                .ForMember(c => c.Employee, c => c.Ignore());
        }
       
    }
}
