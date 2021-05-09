
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

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