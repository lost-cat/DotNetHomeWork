using System;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace HomeWork5_1.mysql
{
    public class MySqlUtil
    {
        public static MySqlConnection GetConnection()
        {
            ExeConfigurationFileMap map = new ExeConfigurationFileMap();
            Console.WriteLine(Environment.CurrentDirectory);

            map.ExeConfigFilename =
                @"C:\Users\white\RiderProjects\DotNetHomeWork\HomeWork5\HomeWork5_1\mysql\mysql.config";
            var configuration = ConfigurationManager.OpenMappedExeConfiguration(map, ConfigurationUserLevel.None);

            var builder = new MySqlConnectionStringBuilder
            {
                UserID = configuration.AppSettings.Settings["UserName"].Value,
                Password = configuration.AppSettings.Settings["Password"].Value,
                Server = configuration.AppSettings.Settings["Server"].Value,
                Database = configuration.AppSettings.Settings["DataBase"].Value
            };
            var connection = new MySqlConnection(builder.ConnectionString);
            return connection;
        }
    }
}