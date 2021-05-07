using System;
using HomeWork5_1;
using HomeWork5_1.mysql;
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
      
         
        }

        [Test]
        public void Test()
        {
            var db = new OrderContext();
            db.Customers.Add(new Customer( "white", "武汉大学"));
            db.SaveChanges();
        }


        [Test]
        public void XmlExportTest()
        {
         //   OrderService.Export("test.xml");
        }

        [Test]
        public void XmlImportTest()
        {
          //  OrderService.Import("test.xml");
        }

        [Test]
        public void DeleteOrderTest()
        {
           //OrderService.DeleteOrder(o => o.OrderId == 1);
        }

        [Test]
        public void AddOrderTest()
        {

            Console.WriteLine(Environment.CurrentDirectory);
        }

        [Test]
        public void QueryOrderTest()
        {
           // var order = OrderService.QueryOrderById(1);
           // Assert.True(order.OrderId == 1);
        }
    }
}