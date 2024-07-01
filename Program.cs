namespace Perevantajennia_operatoriv
{
    class Square
    {
        public int Side { get; set; }
        public Square() { }
        public Square(int side)
        {
            if (side < 0)
                throw new ArgumentException("Side cannot be negative!");
            Side = side;
        }
        public static Square operator +(Square s1, Square s2)
        {
            Square res = new Square
            {
                Side = s1.Side + s2.Side
            };
            return res;
        }
        public static Square operator -(Square s1, Square s2)
        {
            Square res = new Square
            {
                Side = s1.Side - s2.Side
            };
            return res;

        }
        public static Square operator *(Square s1, Square s2)
        {
            Square res = new Square
            {
                Side = s1.Side * s2.Side
            };
            return res;
        }
        public static Square operator /(Square s1, Square s2)
        {
            Square res = new Square
            {
                Side = s1.Side / s2.Side
            };
            return res;
        }
        public static Square operator ++(Square s)
        {
            s.Side++;
            return s;
        }
        public static Square operator --(Square s)
        {
            s.Side--;
            return s;
        }
        public static bool operator <(Square s1, Square s2)
        {
            return s1.Side < s2.Side;
        }
        public static bool operator >(Square s1, Square s2)
        {
            return s1.Side > s2.Side;
        }
        public static bool operator <=(Square s1, Square s2)
        {
            return s1.Side <= s2.Side;
        }
        public static bool operator >=(Square s1, Square s2)
        {
            return s1.Side >= s2.Side;
        }
        public override int GetHashCode()
        {
            return Side.GetHashCode();
        }
        public static bool operator ==(Square s1, Square s2)
        {
            return s1.Side == s2.Side;
        }
        public static bool operator !=(Square s1, Square s2)
        {
            return !(s1 == s2);
        }
        public override string ToString()
        {
            return $"Square with side {Side}";
        }
        public static bool operator true(Square s1)
        {
            return s1.Side >= 0 && s1.Side >= 0;
        }
        public static bool operator false(Square s1)
        {
            return s1.Side < 0 || s1.Side < 0;
        }
        public static implicit operator Rectangle(Square s)
        {
            return new Rectangle(s.Side, s.Side);
        }
        public static implicit operator int(Square s)
        {
            return s.Side;
        }
    }
    class Rectangle
    {
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public Rectangle() { }
        public Rectangle(int side1, int side2)
        {
            if (side1 < 0 || side2 < 0)
                throw new ArgumentException("Sides cannot be negative!");
            Side1 = side1;
            Side2 = side2;
        }
        public static Rectangle operator +(Rectangle r1, Rectangle r2)
        {
            Rectangle res = new Rectangle
            {
                Side1 = r1.Side1 + r2.Side1,
                Side2 = r2.Side2 + r2.Side2
            };
            return res;
        }
        public static Rectangle operator -(Rectangle r1, Rectangle r2)
        {
            Rectangle res = new Rectangle
            {
                Side1 = r1.Side1 - r2.Side1,
                Side2 = r2.Side2 - r2.Side2
            };
            return res;
        }
        public static Rectangle operator *(Rectangle r1, Rectangle r2)
        {
            Rectangle res = new Rectangle
            {
                Side1 = r1.Side1 * r2.Side1,
                Side2 = r2.Side2 * r2.Side2
            };
            return res;
        }
        public static Rectangle operator /(Rectangle r1, Rectangle r2)
        {
            Rectangle res = new Rectangle
            {
                Side1 = r1.Side1 / r2.Side1,
                Side2 = r2.Side2 / r2.Side2
            };
            return res;
        }
        public static Rectangle operator ++(Rectangle r)
        {
            r.Side1++;
            r.Side2++;
            return r;
        }
        public static Rectangle operator --(Rectangle r)
        {
            r.Side1--;
            r.Side2--;
            return r;
        }
        public static bool operator <(Rectangle r1, Rectangle r2)
        {
            return r1.Side1 + r2.Side1 < r1.Side2 + r2.Side2;
        }
        public static bool operator >(Rectangle r1, Rectangle r2)
        {
            return !(r1 < r2);
        }
        public static bool operator <=(Rectangle r1, Rectangle r2)
        {
            return r1.Side1 + r2.Side1 <= r1.Side2 + r2.Side2;
        }
        public override bool Equals(object? obj)
        {
            return obj is Rectangle rectangle &&
                Side1 == rectangle.Side1 &&
                Side2 == rectangle.Side2;
        }
        public static bool operator >=(Rectangle r1, Rectangle r2)
        {
            return !(r1 <= r2);
        }
        public static bool operator ==(Rectangle r1, Rectangle r2)
        {
            return r1.Equals(r2);
        }
        public static bool operator !=(Rectangle r1, Rectangle r2)
        {
            return !(r1 == r2);
        }
        public override int GetHashCode()
        {
            return Side1.GetHashCode() ^ Side2.GetHashCode();
        }
        public override string ToString()
        {
            return $"Rectangle with sides {Side1} and {Side2}";
        }
        public static bool operator true(Rectangle r1)
        {
            return r1.Side1 >= 0 && r1.Side2 >= 0;
        }
        public static bool operator false(Rectangle r1)
        {
            return r1.Side1 < 0 || r1.Side2 < 0;
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Square s1 = new Square(3);
            Square s2 = new Square(4);

            Square sumSquares = s1 + s2;
            Square differenceSquares = s1 - s2;
            Square productSquares = s1 * s2;
            Square quotientSquares = s1 / s2;

            Console.WriteLine($"Sum of squares: {sumSquares}");
            Console.WriteLine($"Difference of squares: {differenceSquares}");
            Console.WriteLine($"Product of squares: {productSquares}");
            Console.WriteLine($"Quotient of squares: {quotientSquares}");

            ++s1;
            --s2;

            Console.WriteLine($"Incremented square: {s1}");
            Console.WriteLine($"Decremented square: {s2}");

            if (s1 > s2)
                Console.WriteLine("s1 is greater than s2");
            if (s1 < s2)
                Console.WriteLine("s1 is less than s2");

            Rectangle r1 = new Rectangle(2, 3);
            Rectangle r2 = new Rectangle(4, 5);

            Rectangle sumRectangles = r1 + r2;
            Rectangle differenceRectangles = r1 - r2;
            Rectangle productRectangles = r1 * r2;
            Rectangle quotientRectangles = r1 / r2;

            Console.WriteLine($"Sum of rectangles: {sumRectangles}");
            Console.WriteLine($"Difference of rectangles: {differenceRectangles}");
            Console.WriteLine($"Product of rectangles: {productRectangles}");
            Console.WriteLine($"Quotient of rectangles: {quotientRectangles}");

            ++r1;
            --r2;

            Console.WriteLine($"Incremented rectangle: {r1}");
            Console.WriteLine($"Decremented rectangle: {r2}");

            if (r1 > r2)
                Console.WriteLine("r1 is greater than r2");
            if (r1 < r2)
                Console.WriteLine("r1 is less than r2");

            Square s3 = new Square(5);
            Rectangle r3 = s3;

            Console.WriteLine($"Square to rectangle: {r3}");
        }
    }
}