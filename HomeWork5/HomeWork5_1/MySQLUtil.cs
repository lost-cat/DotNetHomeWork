using System.Configuration;
using MySql.Data.MySqlClient;

namespace HomeWork5_1
{
    public class MySqlUtil
    {
        public static MySqlConnection GetConnection()
        {
            var builder = new MySqlConnectionStringBuilder
            {
                UserID = ConfigurationManager.AppSettings.Get("UserName"),
                Password = ConfigurationManager.AppSettings.Get("Password"),
                Server = ConfigurationManager.AppSettings.Get("Server"),
                Database = ConfigurationManager.AppSettings.Get("DataBase")
            };
            var connection = new MySqlConnection(builder.ConnectionString);
            return connection;
        }
    }
}