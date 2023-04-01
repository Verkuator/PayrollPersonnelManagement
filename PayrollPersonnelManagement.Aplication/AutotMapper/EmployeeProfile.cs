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
        }
       
    }
}
