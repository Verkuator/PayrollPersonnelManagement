using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PayrollPersonnelManagement.Aplication.AutotMapper
{
    public class CommonProfile : Profile
    {
        public CommonProfile()
        {
            CreateMap(typeof(Task<>), typeof(Task<>));
            CreateMap(typeof(List<>), typeof(List<>));
        }
    }
}
