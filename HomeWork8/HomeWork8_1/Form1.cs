using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HomeWork5_1;

namespace HomeWork8_1
{
    public partial class Form1 : Form
    {
        private readonly OrderService service = new OrderService();

        public Form1()
        {
            var random = new Random();
            var items = new Item[10];
            for (var index = 0; index < items.Length; index++)
            {
                items[index] = ItemFactory.GetItem(random.Next(3));
            }

            var orderDetailsArray = new OrderDetails[10];
            for (var i = 0; i < orderDetailsArray.Length; i++)
            {
                orderDetailsArray[i] = new OrderDetails(
                    ItemFactory.GetItem(random.Next(3)),
                    random.Next(1, 10));
            }


           
       

            InitializeComponent();

            orderBindingSource.DataSource = service.Orders;
            DetailsView.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void CreateOrder_Click(object sender, EventArgs e)
        {
            var orderForm = new OrderForm(service);
            orderForm.ShowDialog();
        }

        private void orderBindingSource_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void OrderView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }

            if (e.RowIndex > service.Orders.Count)
            {
                return;
            }

            if (!(sender is DataGridView gridView)) return;
            var cell = gridView[0, e.RowIndex];
            var id = (int) cell.Value;
            Console.WriteLine(id);
            var order = service.QueryOrderById(id);
            DetailsView.DataSource = order;
            DetailsView.DataMember = "DetailsList";
        }

        private void DetailsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            orderBindingSource.DataSource = service.Orders.ToArray();
        }

        private void QueryOrder_Click(object sender, EventArgs e)
        {
            if (textBoxSearchContent.TextLength == 0)
            {
                return;
            }
        }
    }
}