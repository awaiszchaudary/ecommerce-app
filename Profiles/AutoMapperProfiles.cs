using AutoMapper;
using ecommerce_app.DTOs;
using ecommerce_app.Entities;

namespace ecommerce_app.Profiles
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<StoreEntity, StoreDTO>().ReverseMap();
        }
    }
}
