using AutoMapper;
using BLL.DMS.ViewModel;
using DAL.DMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DMS.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        //public AutoMapperProfiles()
        //{
        //    CreateMap<Entity, EntityViewModel>();
        //    CreateMap<EntityViewModel, Entity>();
        //}
        public static IMapper Mapper { get; private set; }

        public static void Configure()
        {
            MapperConfiguration mapperConfiguration = new MapperConfiguration(cfg => {
                cfg.CreateMap<Entity, EntityViewModel>().ReverseMap();
                cfg.CreateMap<Product, ProductViewModel>();
                cfg.CreateMap<Customer, CustomerViewModel>();
                //cfg.CreateMap<Login, ProviderLoginVM>()
            });

            Mapper = mapperConfiguration.CreateMapper();
        }
    }
}
