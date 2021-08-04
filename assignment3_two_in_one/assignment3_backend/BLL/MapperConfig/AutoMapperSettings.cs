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
            CreateMap<DAL.category, categoryModel>();
            CreateMap<DAL.category, categoryDetail>();
            CreateMap<productModel, product>().ForMember(e => e.category, sm => sm.Ignore());
            CreateMap<order_user_model, order_user >();
            CreateMap<order_adminn_model, order_adminn>();

        }
    }
}
