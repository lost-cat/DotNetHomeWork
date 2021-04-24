using System;
using SqlSugar;

namespace HomeWork5_1
{
    public class DefaultContext
    {
        public SqlSugarClient Client { get; }

        public DefaultContext(string connectString,DbType type)
        {
            Client = new SqlSugarClient(new ConnectionConfig
            {
                ConnectionString = connectString,
                DbType = type,
                IsAutoCloseConnection = true,
                InitKeyType = InitKeyType.Attribute
            });
           // Client.CodeFirst.InitTables(typeof(Customer),typeof(Item),typeof(Order),typeof(ItemDescription),typeof(OrderDetails));
            Client.Aop.OnLogExecuted = ((sql, parameters) => Console.WriteLine(sql));
        }

        public SimpleClient<T> CreateClient<T>() where T : class, new()
        {
            return Client.GetSimpleClient<T>();
        }
    }
}