using System;

namespace HomeWork3_1
{
    public class Triangle : IShape
    {
        // 三角形的三个点
        private Point _p1, _p2, _p3;

        public double SideA => Math.Sqrt((_p1.X - _p2.X) * (_p1.X - _p2.X)
                                         + (_p1.Y - _p2.Y) * (_p1.Y - _p2.Y));

        public double SideB => Math.Sqrt((_p1.X - _p3.X) * (_p1.X - _p3.X)
                                         + (_p1.Y - _p3.Y) * (_p1.Y - _p3.Y));

        public double SideC => Math.Sqrt((_p2.X - _p3.X) * (_p2.X - _p3.X)
                                         + (_p2.Y - _p3.Y) * (_p2.Y - _p3.Y));

        public Triangle(Point p1, Point p2, Point p3)
        {
            _p1 = p1;
            _p2 = p2;
            _p3 = p3;
        }


      

        //通过斜率判断三角形的三个点是否共线，从而判断三角形是否合规。
        public bool IsLegal()
        {
            return (_p2.Y - _p1.Y) * (_p3.X - _p1.X) == (_p3.Y - _p1.Y) * (_p2.X - _p1.X);
        }

        //海伦公式求三角形面积。
        public double Area
        {
            get
            {
                double p = (SideA + SideB + SideC) / 2;
                double area = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
                return area;
            }
        }
    }
}