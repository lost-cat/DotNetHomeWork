using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HomeWork7_1
{
    public partial class Form1 : Form
    {
        private readonly CayleyTree cayleyTree;

        public Form1()
        {
            InitializeComponent();
            cayleyTree = new CayleyTree(background.CreateGraphics());
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            deepth.DataBindings.Add("Text", cayleyTree, "Depth");
            TrunkLength.DataBindings.Add("Text", cayleyTree,"Length");
            rightScale.DataBindings.Add("Text", cayleyTree, "Per1");
            leftScale.DataBindings.Add("Text", cayleyTree, "Per2");
            rightAngle.DataBindings.Add("Text", cayleyTree, "Th1");
           leftAngle.DataBindings.Add("Text", cayleyTree, "Th2");


        }

        private void TrunkLength_TextChanged(object sender, EventArgs e)
        {
            if (!(sender is TextBox text)) return;
            if (!Regex.IsMatch(text.Text, @"^[1-9]\d*$"))
            {
                info.Text = "长度数据不合法";
                info.Visible = true;
                return;
            }
            info.Visible = false;
            var d = double.Parse(text.Text);
            cayleyTree.Length = d;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!(sender is TextBox textBox)) return;
            if (!Regex.IsMatch(textBox.Text, @"^[1-9]\d*$"))
            {
                info.Text = "递归深度数据不合法";
                info.Visible = true;
                return;
            }
            info.Visible = false;
            var d = int.Parse(textBox.Text);
            cayleyTree.Depth = d;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!(sender is TextBox textBox)) return;
            if (!Regex.IsMatch(textBox.Text, @"^(0.\d+|0|1)$")) {
                info.Text = "右分支长度比数据不合法";
                info.Visible = true;
                return; }
            info.Visible = false;
            var d = double.Parse(textBox.Text);
            cayleyTree.Per1 = d;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!(sender is TextBox textBox)) return;
            if (!Regex.IsMatch(textBox.Text, @"^(0.\d+|0|1)$"))
            {
                info.Text = "左分支长度比数据不合法";
                info.Visible = true;
                return;
            }
            info.Visible = false;
            var d = double.Parse(textBox.Text);
            cayleyTree.Per2 = d;
        }

        private void TH1_TextChanged(object sender, EventArgs e)
        {
            if (!(sender is TextBox textBox)) return;
            if (!Regex.IsMatch(textBox.Text, @"^[1-9]\d*$"))
            {
                info.Text = "右分支角度数据不合法";
                info.Visible = true;
                return;
            }
            info.Visible = false;
            var i = int.Parse(textBox.Text);
            cayleyTree.Th1 = i;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (!(sender is TextBox textBox)) return;
            if (!Regex.IsMatch(textBox.Text, @"^[1-9]\d*$"))
            {
                info.Text = "左分支角度数据不合法";
                info.Visible = true;
                return;
            }
            info.Visible = false;
            var i = int.Parse(textBox.Text);
            cayleyTree.Th2 = i;
        }

        private void Color_CheckedChanged(object sender, EventArgs e)
        {
            if (!(sender is RadioButton button)) return;

            switch (button.Name)
            {
                case "blue":
                    cayleyTree.Pen = Pens.Blue;
                    break;
                case "red":
                    cayleyTree.Pen = Pens.Red;
                    break;
                case "aqua":
                    cayleyTree.Pen = Pens.Aqua;
                    break;
                case "green":
                    cayleyTree.Pen = Pens.Green;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cayleyTree.DrawCayleyTree(cayleyTree.Depth, background.Width / 2, background.Height, cayleyTree.Length,
                30);
        }

        private void clean_Click(object sender, EventArgs e)
        {
            cayleyTree.Clean(background.BackColor);
        }
    }
}