using System;

namespace HomeWork3_1
{
    public class Rectangle : IShape
    {
        private readonly Point _p1;
        private readonly Point _p2;


        public double Height => Math.Abs(_p1.Y - _p2.Y);

        public double Width => Math.Abs(_p1.X - _p2.X);

        public Rectangle(Point p1, Point p2)
        {
            _p1 = p1;
            _p2 = p2;
        }

        public double GetArea()
        {
            return Height * Width;
        }

        //当给定的俩个点的横坐标或纵坐标相同时不会构成矩形，
        public virtual bool IsLegal()
        {
           
            return !(Math.Abs(_p1.X - _p2.X) < 0.001) && !(Math.Abs(_p1.Y - _p2.Y) < 0.001);
        }
    }
}