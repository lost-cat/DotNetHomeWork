using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork5_1
{
    public class Order
    {
        public override string ToString()
        {
            return $"{nameof(OrderId)}: {OrderId}, {nameof(OrderTIme)}: {OrderTIme}, {nameof(DetailsList)}: {DetailsList}, {nameof(DeliverAddress)}: {DeliverAddress}, {nameof(TotalMoney)}: {TotalMoney}";
        }

        //该订单的id
        public int OrderId { get; }

        //该订单的订购时间
        public DateTime OrderTIme { get; }

        //具体的订单明细表 
        public List<OrderDetails> DetailsList { get; }

        //派送地址
        public String DeliverAddress { get; }

        public int TotalMoney
        {
            get { return DetailsList.Sum(details => details.OrderDetailPrice); }
        }

        public Order(
            List<OrderDetails> detailsList,
            int orderId,
            DateTime orderTIme,
            string deliverAddress)
        {
            DetailsList = detailsList;
            OrderId = orderId;
            OrderTIme = orderTIme;
            DeliverAddress = deliverAddress;
        }

     
    }
}