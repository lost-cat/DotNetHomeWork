using System;
using System.Collections.Generic;
using HomeWork5_1;
using NUnit.Framework;

namespace orderTest
{
    [TestFixture]
    public class Tests
    {
        private readonly Random random = new Random();

        [OneTimeSetUp]
        public void Init()
        {
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
        }


        [Test]
        public void XmlExportTest()
        {
            OrderService.Export("test.xml");
        }

        [Test]
        public void XmlImportTest()
        {
            OrderService.Import("test.xml");
        }

        [Test]
        public void DeleteOrderTest()
        {
            OrderService.DeleteOrder(o => o.OrderId == 1);
        }

        [Test]
        public void QueryOrderTest()
        {
            var order = OrderService.QueryOrderById(1);
            Assert.True(order.OrderId==1);
        }
    }
}