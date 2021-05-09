using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using HomeWork5_1.data;
using HomeWork5_1.entities;
using HomeWork5_1.mysql;
using HomeWork5_1.services;

namespace HomeWork5_1
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var service = new OrderService();
            var list = service.GetOrders().Result;
            foreach (var order in list)
            {
                Console.WriteLine(order.TotalMoney);
                
            }

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
                // var customer = new Customer("white", "武汉大学");
                // customer = db.Customers.Add(customer);
                // var orderDetails = new OrderDetails(item, 10);
                // var orderDetails1 = new OrderDetails(item1, 3);
                // orderDetails = db.Details.Add(orderDetails);
                // orderDetails1 = db.Details.Add(orderDetails1);
                // var detailsList = new List<OrderDetails> {orderDetails, orderDetails1};
                // var order = new Order(detailsList, DateTime.Now, customer);
                // db.Orders.Add(order);
                // db.SaveChanges();
            

            
        }
    }
}