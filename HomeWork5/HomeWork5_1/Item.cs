using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeWork5_1
{
    [Serializable]
    public class Item
    {
      


        public Item()
        {
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ItemId { get; set; }

        //商品的描述信息，包括价格，名称 和对应的商品类型（代表一类商品）
        public string Description { get; set; }

        public double Price { get; set; }

        public Item(string description, double price)
        {
            Description = description;
            Price = price;
        }

        private bool Equals(Item other)
        {
            return Equals(Description, other.Description);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == this.GetType() && Equals((Item) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ItemId * 397 ^ (Description != null ? Description.GetHashCode() : 0);
            }
        }

        public override string ToString()
        {
            return $"{nameof(ItemId)}: {ItemId}, {nameof(Description)}: {Description}";
        }
    }
}