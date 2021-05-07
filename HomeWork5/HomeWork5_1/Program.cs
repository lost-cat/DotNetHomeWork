using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using HomeWork5_1.mysql;

namespace HomeWork5_1
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            using (var db = new OrderContext())
            {
              
                ObservableCollection<Order> Orders= db.Orders.Local;
                // var customer = db.Customers.Find(1);
                // var order = db.Orders.Include(o => o.DetailsList).Include(o => o.DetailsList.Select(d => d.Item))
                //     .FirstOrDefault(o => o.OrderId == 2);
                // Console.WriteLine(order);
                // var observableCollection = db.Customers.Local;
                // if (order != null)
                //     foreach (var orderDetails in order.DetailsList)
                //     {
                //         Console.WriteLine(orderDetails);
                //     }
                //
                // var item = db.Items.Add(ItemFactory.GetItem(2));
                // var item1 = db.Items.Add(ItemFactory.GetItem(1));
                //
                // var orderDetails = new OrderDetails(item, 10);
                // var orderDetails1 = new OrderDetails(item1, 3);
                // orderDetails = db.Details.Add(orderDetails);
                // orderDetails1 = db.Details.Add(orderDetails1);
                // var detailsList = new List<OrderDetails> {orderDetails, orderDetails1};
                // var order = new Order(detailsList, DateTime.Now, customer);
                // db.Orders.Add(order);
                // db.SaveChanges();
            }

            Console.WriteLine("添加成功");
        }
    }
}