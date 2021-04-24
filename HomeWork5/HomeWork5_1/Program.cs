using System;
using System.Collections.Generic;

namespace HomeWork5_1
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            /*
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


            for (var i = 0; i < 5; i++)
            {
                OrderService.AddOrder(new Order(
                    new List<OrderDetails>(
                        new[] {orderDetailsArray[2 * i], orderDetailsArray[2 * i + 1]}),
                    i,
                    DateTime.Now,
                    new Customer("lmk", "wuhan university")));
            }

            var order = OrderService.QueryOrderById(1);
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
            */

            
        }
    }
}