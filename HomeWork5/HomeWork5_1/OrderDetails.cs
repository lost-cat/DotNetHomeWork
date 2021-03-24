namespace HomeWork5_1
{
    public class OrderDetails
    {
        //对应的商品
        public Item Item { get; }

        //该商品的数量
        public int ItemCounts { get; set; }

        //该订单明细的总价格（未打折扣前）
        public int OrderDetailPrice => Item.Description.Price * ItemCounts;

        //代表该订单明细的折扣
        public double DisCount { get; }

        public OrderDetails(Item item, int itemCounts, double disCount = 1.0)
        {
            Item = item;
            ItemCounts = itemCounts;
            DisCount = disCount;
        }

        private bool Equals(OrderDetails other)
        {
            return Equals(Item, other.Item) && ItemCounts == other.ItemCounts && DisCount.Equals(other.DisCount);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((OrderDetails) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (Item != null ? Item.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ ItemCounts;
                hashCode = (hashCode * 397) ^ DisCount.GetHashCode();
                return hashCode;
            }
        }

        public override string ToString()
        {
            return $"{nameof(Item)}: {Item}, {nameof(ItemCounts)}: {ItemCounts}, {nameof(OrderDetailPrice)}: {OrderDetailPrice}, {nameof(DisCount)}: {DisCount}";
        }
    }
}