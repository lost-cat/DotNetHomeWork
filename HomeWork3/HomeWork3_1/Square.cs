namespace HomeWork3_1
{
    public class Square : Rectangle
    {
        public Square(Point p1, Point p2) : base(p1, p2)
        {
        }

        //正方形的长和宽必须相等
        public override bool IsLegal()
        {
            return base.IsLegal() && Width == Height;
        }
    }
}