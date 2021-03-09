using System;
using HomeWork3_1;

namespace HomeWork3_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IShape[] shapes = new IShape[10];
            Random rd = new Random();
            for (var i = 0; i < shapes.Length; i++)
            {
                shapes[i] = ShapeFactory.GetShape(rd.Next(3));
            }

            double totalArea = 0;
            foreach (var shape in shapes)
            {
                if (shape.IsLegal())
                {
                    Console.WriteLine($"该图形合法，面积为{shape.GetArea()}");
                    totalArea += shape.GetArea();
                }

                Console.WriteLine("该图形不合法");
            }

            Console.WriteLine($"总图形面积为{totalArea}");
        }
    }
}