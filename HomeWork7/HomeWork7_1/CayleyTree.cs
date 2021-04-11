using System;
using System.Drawing;

namespace HomeWork7_1
{
    public class CayleyTree
    {
        private readonly Graphics graphics;
        private double th1 = 30 * Math.PI / 180;


        public double Length { get; set; } = 50;

        public Pen Pen { get; set; } = Pens.Blue;

        private double th2 = 20 * Math.PI / 180;
        private double per1 = 0.6;
        private double per2 = 0.7;

        public double Th1
        {
            get => th1;
            set => th1 = value * Math.PI / 180;
        }

        public double Th2
        {
            get => th2;
            set => th2 = value * Math.PI / 180;
        }

        public double Per1
        {
            get => per1;
            set => per1 = value;
        }

        public double Per2
        {
            get => per2;
            set => per2 = value;
        }

        public int Depth { get; set; } = 10;


        public CayleyTree(Graphics graphics)
        {
            this.graphics = graphics;
        }

        public void DrawCayleyTree(int n, double x0, double y0,
            double leng, double th)
        {
            if (n == 0)
            {
                return;
            }

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            DrawLine(x0, y0, x1, y1);
            DrawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            DrawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }

        private void DrawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(Pen, (int) x0, (int) y0, (int) x1, (int) y1);
        }

        public void Clean(Color color)
        {
            graphics.Clear(color);
        }
    }
}