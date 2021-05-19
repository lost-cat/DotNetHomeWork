using AutoMapper;
using HomeWorkWebAPI.entities;
using HomeWorkWebAPI.models;

namespace HomeWorkWebAPI.profiles
{
    public class DetailProfile : Profile
    {
        public DetailProfile()
        {
            CreateMap<OrderDetailAddDto, OrderDetail>();
            CreateMap<OrderDetail, OrderDetailDto>();
        }
    }
}