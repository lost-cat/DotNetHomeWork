using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace HomeWork5_1
{
    public static class OrderService
    {
        private static List<Order> Orders = new List<Order>();

        public static void AddOrder(Order order)
        {
            if (order == null)
            {
                throw new NullReferenceException("该订单为空!");
            }

            if (Orders.Exists(o => Equals(o, order))) throw new Exception("该订单已存在，请不要重复添加!");

            Orders.Add(order);
        }


        /// <summary>
        ///     删除符合条件的order
        /// </summary>
        /// <param name="predicate">通过给定条件匹配对应的order</param>
        public static void DeleteOrder(Predicate<Order> predicate)
        {
            foreach (var order in Orders.Where(order => predicate(order))) Orders.Remove(order);
        }

        /// <summary>
        ///     通过给定条件对符合条件的orders执行对应的操作
        /// </summary>
        /// <param name="predicate">筛选条件</param>
        /// <param name="action">对筛选后的order执行的操作</param>
        public static void ModifyOrder(Predicate<Order> predicate, Action<Order> action)
        {
            foreach (var order in Orders.Where(order => predicate(order)))
            {
                action(order);
                return;
            }

            throw new Exception("该订单不存在");
        }

        /// <summary>
        ///     通过每个order的id查询
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static Order QueryOrderById(int orderId)
        {
            var order = Orders.Find(o => o.OrderId == orderId);
            if (order == null) throw new Exception("该订单不存在");

            return order;
        }

        /// <summary>
        ///     通过给定条件获取order
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public static List<Order> QueryOrder(Predicate<Order> predicate)
        {
            var orders = Orders.Where(o => predicate(o));
            return orders.OrderBy(o => o.TotalMoney).ToList();
        }

        /// <summary>
        ///     返回所有包含指定商品的orders
        /// </summary>
        /// <param name="itemDescription"></param>
        /// <returns></returns>
        public static List<Order> QueryOrderByItemName(ItemDescription itemDescription)
        {
            var orders = Orders
                .Where(order => order.DetailsList
                    .Any(details => details.Item.Description.Equals(itemDescription)))
                .ToList();

            return orders;
        }

        /// <summary>
        ///     对orderList进行排序，如果不传入比较器则默认按照id排序
        /// </summary>
        /// <param name="comparison">带传入的比较器，可以不写</param>
        public static void Sort(Comparison<Order> comparison = null)
        {
            Orders.Sort(comparison ?? ((order, order1) => order.OrderId - order1.OrderId));
        }

        public static void AddOrderDetails(Order order, OrderDetails orderDetails)
        {
            if (order.DetailsList.Exists(o => Equals(o, orderDetails))) throw new Exception("该订单明细已存在于该订单！");

            order.DetailsList.Add(orderDetails);
        }

        /// <summary>
        ///     将对应的order数据导出到指定path的xml文件上.
        /// </summary>
        /// <param name="path">所要导入xml的位置</param>
        public static void Export(string path)
        {
            var stream = File.Create(path);
            var xmlSerializer = new XmlSerializer(typeof(List<Order>));
            xmlSerializer.Serialize(stream, Orders);
        }

        /// <summary>
        ///     载入指定xml文件中的订单
        /// </summary>
        /// <param name="path">指定的xml路径</param>
        public static void Import(string path)
        {
            var stream = File.Open(path, FileMode.Open);
            var xmlSerializer = new XmlSerializer(typeof(List<Order>));
            var o = xmlSerializer.Deserialize(stream);
            var list = o as List<Order>;
            Orders = Orders.Union(list ?? throw new InvalidOperationException()).ToList();
        }
    }
}