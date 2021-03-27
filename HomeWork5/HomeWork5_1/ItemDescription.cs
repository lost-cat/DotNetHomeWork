using System;

namespace HomeWork5_1
{
    [Serializable]
    public class ItemDescription
    {
        //商品的类型
        public int ItemType { get; }
        //商品的价格
        public int Price { get; }
        //商品的名称
        public String Name { get; }

        public ItemDescription(int itemType, int price, String name)
        {
            ItemType = itemType;
            Price = price;
            Name = name;
        }

        private bool Equals(ItemDescription other)
        {
            return ItemType == other.ItemType && Price == other.Price && Name == other.Name;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((ItemDescription) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = ItemType;
                hashCode = (hashCode * 397) ^ Price;
                hashCode = (hashCode * 397) ^ (Name != null ? Name.GetHashCode() : 0);
                return hashCode;
            }
        }

        public override string ToString()
        {
            return $"{nameof(ItemType)}: {ItemType}, {nameof(Price)}: {Price}, {nameof(Name)}: {Name}";
        }
    }
}