using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollPersonnelManagement.Aplication.AutotMapper
{
    public static class MappConfiguration
    {
        public static IMapper GetMapper()
        {
            var configuration = new MapperConfiguration(cfg => {
                cfg.AddProfile<CommonProfile>();
                cfg.AddProfile<EmployeeProfile>();
            });
            var mapper = new Mapper(configuration);
            return mapper;
        }
    }
}
