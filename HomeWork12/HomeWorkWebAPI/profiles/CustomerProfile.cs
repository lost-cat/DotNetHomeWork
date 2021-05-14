using AutoMapper;
using HomeWorkWebAPI.entities;
using HomeWorkWebAPI.models;

namespace HomeWorkWebAPI.profiles
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<Customer, CustomerDto>();
            CreateMap<CustomerAddDto, Customer>();
        }
    }
}