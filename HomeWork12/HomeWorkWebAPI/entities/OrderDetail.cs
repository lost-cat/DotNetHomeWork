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
        
        public Guid OrderId { get; set; }
    }
}