using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HomeWork5_1;

namespace HomeWork8_1
{
    public partial class Form1 : Form
    {
        private  OrderService Service { get; set; } 

        public Form1()
        {
            InitializeComponent();
            Service = new OrderService();
            orderBindingSource.DataSource = Service.Orders;
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
            var orderForm = new OrderForm(Service);
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

            if (e.RowIndex > Service.Orders.Count)
            {
                return;
            }

            if (!(sender is DataGridView gridView)) return;
            var cell = gridView[0, e.RowIndex];
            var id = (int) cell.Value;
            Console.WriteLine(id);
            var order = Service.QueryOrderById(id);
            DetailsView.DataSource = order;
            DetailsView.DataMember = "DetailsList";
        }

        private void DetailsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            orderBindingSource.DataSource = Service.Orders.ToArray();
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