using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using HomeWork5_1.data;
using HomeWork5_1.entities;

namespace HomeWork5_1.services
{
    public class OrderService
    {
        private readonly OrderContext db = new OrderContext();

        public async Task<List<Order>> GetOrders()
        {
            await db.Orders.Include(o => o.DetailsList)
                .Include(o => o.Customer)
                .Include(o => o.DetailsList.Select(d => d.Item))
                .LoadAsync();
            
            return db.Orders.ToList();
        }


        public Order AddOrder(Order order)
        {
            if (order == null)
            {
                throw new ArgumentException(nameof(order));
            }

            var add = db.Orders.Add(order);
            return add;
        }

        public async Task<int> SaveChangesAsync()
        {
            return await db.SaveChangesAsync();
        }


        /// <summary>
        ///     删除符合条件的order
        /// </summary>
        /// <param name="order"></param>
        public void DeleteOrder(Order order)
        {
            if (order == null) throw new ArgumentException(nameof(order));

            db.Orders.Remove(order);
        }

        /// <summary>
        ///     通过给定条件对符合条件的orders执行对应的操作
        /// </summary>
        /// <param name="predicate">筛选条件</param>
        /// <param name="action">对筛选后的order执行的操作</param>
        public void ModifyOrder(Predicate<Order> predicate, Action<Order> action)
        {
            foreach (var order in db.Orders.Where(order => predicate(order)))
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
        public async Task<Order> QueryOrderById(int orderId)
        {
            var order = await db.Orders.FirstOrDefaultAsync(o => o.OrderId == orderId);

            if (order == null) throw new Exception("该订单不存在");

            return order;
        }


        /// <summary>
        ///     返回所有包含指定商品的orders
        /// </summary>
        /// <param name="itemDescription"></param>
        /// <returns></returns>
        public async Task<List<Order>> QueryOrderByItemName(string itemDescription)
        {
            var orders = await db.Orders
                .Where(order => order
                    .DetailsList
                    .Any(details => details.Item.Description.Contains(itemDescription)))
                .ToListAsync();

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