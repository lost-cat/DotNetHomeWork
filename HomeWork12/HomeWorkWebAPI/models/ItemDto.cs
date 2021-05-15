using System;

namespace HomeWorkWebAPI.models
{
    public class ItemDto
    {
        public Guid Id { get; set; }
        
        public string Description { get; set; }
        public double Price { get; set; }
    }
}