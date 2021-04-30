using System.Data.Entity;

namespace HomeWork5_1
{
    public class OrderContext : DbContext
    {
        public OrderContext() : base("orderDb")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<OrderContext>());
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> Details { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Item> Items { get; set; }
        
    }
}