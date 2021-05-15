using AutoMapper;
using HomeWorkWebAPI.entities;
using HomeWorkWebAPI.models;

namespace HomeWorkWebAPI.profiles
{
    public class OrderProfile: Profile
    {
        public OrderProfile()
        {
            CreateMap<Order, OrderDto>();
            CreateMap<OrderAddDto, Order>();
        }
    }
}