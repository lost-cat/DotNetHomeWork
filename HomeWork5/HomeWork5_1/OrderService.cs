using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork5_1
{
    public class OrderService
    {
        private readonly OrderContext context = new OrderContext();


        public void AddOrder(Order order)
        {
            if (order == null)
            {
                throw new NullReferenceException("该订单为空!");
            }

            if (context.Orders.Contains(order))
                throw new Exception("该订单已存在，请不要重复添加!");

            context.Orders.Add(order);
        }


        /// <summary>
        ///     删除符合条件的order
        /// </summary>
        /// <param name="predicate">通过给定条件匹配对应的order</param>
        public void DeleteOrder(Predicate<Order> predicate)
        {
            var enumerable = context.Orders.Where(o => predicate(o));
            var orders = enumerable.ToArray();

            foreach (var t in orders)
            {
                context.Orders.Remove(t);
            }
        }

        /// <summary>
        ///     通过给定条件对符合条件的orders执行对应的操作
        /// </summary>
        /// <param name="predicate">筛选条件</param>
        /// <param name="action">对筛选后的order执行的操作</param>
        public void ModifyOrder(Predicate<Order> predicate, Action<Order> action)
        {
            foreach (var order in context.Orders.Where(order => predicate(order)))
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
        public Order QueryOrderById(int orderId)
        {
            var order = context.Orders.Find(orderId);
            if (order == null) throw new Exception("该订单不存在");

            return order;
        }

        /// <summary>
        ///     通过给定条件获取order
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public List<Order> QueryOrder(Predicate<Order> predicate)
        {
            var orders = context.Orders.Where(o => predicate(o));
            return orders.OrderBy(o => o.TotalMoney).ToList();
        }

        /// <summary>
        ///     返回所有包含指定商品的orders
        /// </summary>
        /// <param name="itemDescription"></param>
        /// <returns></returns>
        public List<Order> QueryOrderByItemName(string itemDescription)
        {
            var orders = context.Orders
                .Where(order => order.DetailsList
                    .Any(details => details.Item.Description.Equals(itemDescription)))
                .ToList();

            return orders;
        }

        // /// <summary>
        // ///     对orderList进行排序，如果不传入比较器则默认按照id排序
        // /// </summary>
        // /// <param name="comparison">带传入的比较器，可以不写</param>
        // public  void Sort(Comparison<Order> comparison = null)
        // {
        //     context.Orders.OrderBy() }

        public void AddOrderDetails(Order order, OrderDetails orderDetails)
        {
            if (order.DetailsList.Exists(o => Equals(o, orderDetails))) throw new Exception("该订单明细已存在于该订单！");

            order.DetailsList.Add(orderDetails);
        }


        public List<Order> Orders => context.Orders.ToList();

        /*
        /// <summary>
        ///     将对应的order数据导出到指定path的xml文件上.
        /// </summary>
        /// <param name="path">所要导入xml的位置</param>*/
        // public  void Export(string path)
        // {
        //     using (var stream = File.Create(path))
        //     {
        //         var xmlSerializer = new XmlSerializer(typeof(List<Order>));
        //         xmlSerializer.Serialize(stream, context.Orders);
        //     }
        // }
        //
        // /// <summary>
        // ///     载入指定xml文件中的订单
        // /// </summary>
        // /// <param name="path">指定的xml路径</param>
        // public  void Import(string path)
        // {
        //     using (var stream = File.Open(path, FileMode.Open))
        //     {
        //         var xmlSerializer = new XmlSerializer(typeof(List<Order>));
        //         var o = xmlSerializer.Deserialize(stream);
        //         var list = o as List<Order>;
        //         _orders = _orders
        //             .Union(list ?? throw new InvalidOperationException())
        //             .ToList();
        //     }
        // }
    }
}