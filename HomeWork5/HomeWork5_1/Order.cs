using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork5_1
{
    [Serializable]
    public class Order
    {
        //该订单的id
        public int OrderId { get; set; }

        //该订单的订购时间
        public DateTime OrderTIme { get; set; }

        //具体的订单明细表 
        public List<OrderDetails> DetailsList { get; set; }

        //该订单对应的用户
        public Customer Customer { get; set; }

        public int TotalMoney => DetailsList.Sum(details => details.OrderDetailPrice);

        public Order(
            List<OrderDetails> detailsList,
            int orderId,
            DateTime orderTIme,
            Customer customer)
        {
            DetailsList = detailsList;
            OrderId = orderId;
            OrderTIme = orderTIme;
            Customer = customer;
        }

        private bool Equals(Order other)
        {
            return OrderId == other.OrderId;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == this.GetType() && Equals((Order) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = OrderId;
                hashCode = (hashCode * 397) ^ OrderTIme.GetHashCode();
                hashCode = (hashCode * 397) ^ (DetailsList != null ? DetailsList.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Customer != null ? Customer.GetHashCode() : 0);
                return hashCode;
            }
        }

        public Order()
        {
        }

  

        public override string ToString()
        {
            return
                $"{nameof(OrderId)}: {OrderId}," +
                $" {nameof(OrderTIme)}: {OrderTIme}, {nameof(DetailsList)}: {DetailsList}, {nameof(Customer)}: {Customer}, {nameof(TotalMoney)}: {TotalMoney}";
        }
    }
}