using System;
using HomeWork3_1;

namespace HomeWork3_2
{
    public class ShapeFactory
    {
        public static IShape GetShape(int shapeId)
        {
            Random rd = new Random();
            switch (shapeId)
            {
                case 0:
                    return new Rectangle(
                        new Point(rd.Next(11), rd.Next(11)),
                        new Point(rd.Next(11), rd.Next(11)));
                case 1:
                    return new Square(
                        new Point(rd.Next(11), rd.Next(11)),
                        new Point(rd.Next(11), rd.Next(11)));
                case 2:
                    return new Triangle(
                        new Point(rd.Next(11), rd.Next(11)),
                        new Point(rd.Next(11), rd.Next(11)),
                        new Point(rd.Next(11), rd.Next(11))
                    );
                default:
                    return null;
            }
        }
    }
}