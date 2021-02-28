using System;
using System.Globalization;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public enum CalculateMode
    {
        Add,
        Minus,
        Multi,
        Divide
    }

    public partial class Form1 : Form
    {
        private double _a, _b;
        private CalculateMode _calculateMode;


        public Form1(CalculateMode calculateMode)
        {
            _calculateMode = calculateMode;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _a = double.Parse(data1.Text);
            _b = double.Parse(data2.Text);
            switch (_calculateMode)
            {
                case CalculateMode.Add:
                    answer.Text = (_a + _b).ToString(CultureInfo.CurrentCulture);
                    break;
                case CalculateMode.Minus:
                    answer.Text = (_a - _b).ToString(CultureInfo.CurrentCulture);
                    break;
                case CalculateMode.Multi:
                    answer.Text = (_a * _b).ToString(CultureInfo.CurrentCulture);
                    break;
                case CalculateMode.Divide:
                    answer.Text = (_a / _b).ToString(CultureInfo.CurrentCulture);
                    break;
            }
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            _calculateMode = CalculateMode.Multi;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            _calculateMode = CalculateMode.Divide;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            _calculateMode = CalculateMode.Minus;
        }

        private void add_Click(object sender, EventArgs e)
        {
            _calculateMode = CalculateMode.Add;
        }

       
    }
}