using System;
using HomeWork3_1;

namespace HomeWork3_2
{
    public class ShapeFactory
    {
      private  static readonly Random Rd = new Random();
        public static IShape GetShape(int shapeId)
        {
            
            switch (shapeId)
            {
                case 0:
                    return new Rectangle(
                        new Point(Rd.Next(11), Rd.Next(11)),
                        new Point(Rd.Next(11), Rd.Next(11)));
                case 1:
                    return new Square(
                        new Point(Rd.Next(11), Rd.Next(11)),
                        new Point(Rd.Next(11), Rd.Next(11)));
                case 2:
                    return new Triangle(
                        new Point(Rd.Next(11), Rd.Next(11)),
                        new Point(Rd.Next(11), Rd.Next(11)),
                        new Point(Rd.Next(11), Rd.Next(11))
                    );
                default:
                    return null;
            }
        }
    }
}