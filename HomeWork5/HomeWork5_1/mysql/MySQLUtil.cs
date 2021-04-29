using System;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace HomeWork5_1.mysql
{
    public class MySqlUtil
    {
        private static MySqlConnection GetConnection()
        {
            var map = new ExeConfigurationFileMap();
            Console.WriteLine(Environment.CurrentDirectory);

            
            var configuration = ConfigurationManager.OpenMappedExeConfiguration(map, ConfigurationUserLevel.None);

            var builder = new MySqlConnectionStringBuilder
            {
                UserID = "root",
                Password = "123456",
                Server = "121.4.110.57",
                Database = "orderDb"
            };
            var connection = new MySqlConnection(builder.ConnectionString);
            connection.Open();
            return connection;
        }

        public static void QueryDb(string query)
        {
            using (var connection = GetConnection())
            {
                
                
                
                
                
            }
        }
    }
}