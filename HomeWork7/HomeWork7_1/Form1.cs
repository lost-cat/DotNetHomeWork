using System;
using System.Drawing;
using System.Windows.Forms;

namespace HomeWork7_1
{
    public partial class Form1 : Form
    {
        private readonly CayleyTree cayleyTree;

        public Form1()
        {
            InitializeComponent();
            cayleyTree = new CayleyTree(graphics: CreateGraphics());
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void TrunkLength_TextChanged(object sender, EventArgs e)
        {
            if (!(sender is TextBox text)) return;
            var s = text.Text;
            if (s == "")
            {
                return;
            }

            var d = double.Parse(s);
            cayleyTree.Length = d;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!(sender is TextBox textBox)) return;
            var s = textBox.Text;
            if (s == "")
            {
                return;
            }

            var d = int.Parse(s);
            cayleyTree.Depth = d;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!(sender is TextBox textBox)) return;
            var s = textBox.Text;
            if (s == "")
            {
                return;
            }

            var d = double.Parse(s);
            cayleyTree.Per1 = d;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!(sender is TextBox textBox)) return;
            var s = textBox.Text;
            if (s == "")
            {
                return;
            }

            var d = double.Parse(s);
            cayleyTree.Per2 = d;
        }

        private void TH1_TextChanged(object sender, EventArgs e)
        {
            if (!(sender is TextBox textBox)) return;
            var s = textBox.Text;
            if (s == "")
            {
                return;
            }

            var i = int.Parse(s);
            cayleyTree.Th1 = i;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (!(sender is TextBox textBox)) return;
            var s = textBox.Text;
            if (s == "")
            {
                return;
            }

            var i = int.Parse(s);
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
                case "black":
                    cayleyTree.Pen = Pens.Black;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cayleyTree.DrawCayleyTree(cayleyTree.Depth, 20, 20, cayleyTree.Length, 30);
        }
    }
}