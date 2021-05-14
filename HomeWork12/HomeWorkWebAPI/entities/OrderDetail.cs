using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeWorkWebAPI.entities
{
    public class OrderDetail
    {
        [Key] public Guid Id { get; set; }

        public Item Item { get; set; }
        public int Count { get; set; }
        public double Money => Item.Price * Count;

        [ForeignKey("Item")] public Guid ItemId { get; set; }

        public Guid OrderId { get; set; }
        public Order Order { get; set; }
    }
}