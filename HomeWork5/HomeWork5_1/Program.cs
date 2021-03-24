using System;
using System.Collections.Generic;

namespace HomeWork5_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var random = new Random();
            var items = new Item[10];
            for (var index = 0; index < items.Length; index++)
            {
                items[index] = ItemFactory.GetItem(random.Next(3));
            }

            var orderDetailsArray = new OrderDetails[10];
            for (var i = 0; i < orderDetailsArray.Length; i++)
            {
                orderDetailsArray[i] = new OrderDetails(
                    ItemFactory.GetItem(random.Next(3)),
                    random.Next(1, 10));
            }


            OrderService.AddOrder(new Order(
                new List<OrderDetails>(new[] {orderDetailsArray[1], orderDetailsArray[2]}),
                001,
                DateTime.Now,
                "武汉大学"));
            var order = OrderService.QueryOrderById(001);
            foreach (var details in order.DetailsList)
            {
                Console.WriteLine(details);
            }

            OrderService.ModifyOrder(o => o.OrderId == 001, o =>
            {
                foreach (var details in o.DetailsList)
                {
                    details.ItemCounts += 10;
                }
            });
            foreach (var details in order.DetailsList)
            {
                Console.WriteLine(details);
            }
            
        }
    }
}