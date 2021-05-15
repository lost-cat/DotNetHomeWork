using System;
using HomeWorkWebAPI.entities;

namespace HomeWorkWebAPI.models
{
    public class OrderDetailDto
    {
        public Guid Id { get; set; }

        public ItemDto Item { get; set; }
        public int Count { get; set; }
        public double Money => Item.Price * Count;
    }
}