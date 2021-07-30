using AutoMapper;
using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.MapperConfig
{
    public class AutoMapperSettings : Profile
    {
        public AutoMapperSettings()
        {
            CreateMap<DEPARTMENT, DEPARTMENTMODEL>();
            CreateMap<DEPARTMENT, DEPARTMENTDETAIL>();
            CreateMap<STUDENTMODEL, STUDENT>().ForMember(e => e.DEPARTMENT, sm => sm.Ignore());

        }
    }
}
