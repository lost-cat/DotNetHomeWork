using System;

namespace HomeWork5_1
{
    [Serializable]
    public class Item
    {
        //带表每个货物自己的编号，独一无二


        public Item()
        {
        }

        public int ItemId { get; set; }
       
        public int OrderDetailsId { get; set; }
        
        //商品的描述信息，包括价格，名称 和对应的商品类型（代表一类商品）
        public string Description { get; set; }
        
        public double Price { get; set; }

        public Item(int itemId, int orderDetailsId, string description, double price)
        {
            ItemId = itemId;
            OrderDetailsId = orderDetailsId;
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