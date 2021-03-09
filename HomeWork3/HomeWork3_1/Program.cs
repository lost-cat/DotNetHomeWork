using System;

namespace HomeWork3_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var p1 = new Point(1, 1);
           // var p2 = new Point(2, 2);
            var p3 = new Point(3, 4);
            Rectangle rectangle = new Square(p1, p3);
            Rectangle rt = new Rectangle(p1, p3);
            Console.WriteLine(rectangle.IsLegal());
            Console.WriteLine(rt.IsLegal());
           

        }
    }
}