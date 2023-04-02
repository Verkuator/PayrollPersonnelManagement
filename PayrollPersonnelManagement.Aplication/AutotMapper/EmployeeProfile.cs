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
                .ForMember(c => c.Employee, c => c.MapFrom(b => b.Employee.PhisicalFace.ToString()))
                .ReverseMap()
                .ForMember(c => c.Employee, c => c.Ignore());

            CreateMap<Post, PostDto>().ReverseMap()
                .ForMember(c => c.Employee, c => c.Ignore());

            CreateMap<Subdivision, SubdivisionDto>().ReverseMap()
                .ForMember(c => c.Employee, c => c.Ignore());
        }
       
    }
}
