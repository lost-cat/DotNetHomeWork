using System.Data.Entity;
using System.Linq;

namespace HomeWork5_1
{
    public class OrderContext : DbContext
    {
        public OrderContext() : base("orderDb")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<OrderContext>());
            
            Orders.Include(o => o.DetailsList)
                .Include(o=>o.Customer)
                .Include(o => o.DetailsList.Select(d => d.Item))
                .Load();
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> Details { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Item> Items { get; set; }
    }
}