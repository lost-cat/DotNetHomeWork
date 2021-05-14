using System.Data.Entity.Migrations;

namespace HomeWork5_1.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<data.OrderContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
    } 
}