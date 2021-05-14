using HomeWorkWebAPI.entities;
using Microsoft.EntityFrameworkCore;

namespace HomeWorkWebAPI.data
{
    public sealed class OrderContext : DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> Details { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().Property(o => o.Time).IsRequired().HasMaxLength(20);
        }
    }
}