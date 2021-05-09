using HomeWork5_1;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HomeWork5_1.entities;
using HomeWork5_1.services;

namespace HomeWork8_1
{
    public partial class OrderForm : Form
    {
        private readonly List<OrderDetails> details;
        private readonly OrderService orderService;

        public OrderForm(OrderService o)
        {
            InitializeComponent();
            ComBoxInit();
            orderService = o;
            details = new List<OrderDetails>();
        }

        private void ComBoxInit()
        {
            comboBoxDetail1.Items.Add("龙虾");
            comboBoxDetail1.Items.Add("牛肉");
            comboBoxDetail1.Items.Add("猪肉");
        
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            
            var customer = new Customer(TextBoxCustomerName.Text, textBoxAddress.Text);
            var order = new Order(new List<OrderDetails>(details),
                DateTime.Now,customer);
            orderService.AddOrder(order);
            Close();
        }

        private void CheckStatus()
        {
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddDetail_Click(object sender, EventArgs e)
        {
            if (comboBoxDetail1.SelectedItem == null)
            {
                return;
            }
            details.Add(new OrderDetails(ItemFactory.GetItem(comboBoxDetail1.SelectedIndex),
                (int)numericUpDownCount1.Value));
            detailView.DataSource = details.ToArray();
        }
    }
}