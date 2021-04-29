using System;
using HomeWork5_1.mysql;

namespace HomeWork5_1
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            using (var db = new OrderContext())
            {
                db.Customers.Add(new Customer(001,"white", "武汉大学"));
                var changes = db.SaveChanges();
                Console.WriteLine(changes);
            }
        }
    }
}