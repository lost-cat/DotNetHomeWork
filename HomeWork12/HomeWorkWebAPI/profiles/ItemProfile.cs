using AutoMapper;
using HomeWorkWebAPI.entities;
using HomeWorkWebAPI.models;

namespace HomeWorkWebAPI.profiles
{
    public class ItemProfile: Profile
    {

        public ItemProfile()
        {
            CreateMap<ItemAddDto, Item>();
            CreateMap<Item, ItemDto>();
        }
    }
}