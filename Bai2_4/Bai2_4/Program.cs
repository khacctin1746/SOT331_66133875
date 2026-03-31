using System;

namespace Bai2_4
{
    // Lớp Point (nếu bạn chưa có thì dùng tạm cái này)
    public class Point
    {
        public double x;
        public double y;

        public Point(double x = 0, double y = 0)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(double dx, double dy)
        {
            x += dx;
            y += dy;
        }

        public void Print()
        {
            Console.WriteLine($"({x}, {y})");
        }
    }

    // Lớp Circle
    public class Circle
    {
        // Thuộc tính
        private double r;
        private Point c;

        // Constructor
        public Circle(double r, Point c)
        {
            this.r = r;
            this.c = c;
        }

        // Constructor mặc định
        public Circle()
        {
            r = 1;
            c = new Point(0, 0);
        }

        // Tính diện tích
        public double Area()
        {
            return Math.PI * r * r;
        }

        // Di chuyển hình tròn
        public void Move(double dx, double dy)
        {
            c.Move(dx, dy);
        }

        // In thông tin
        public void Print()
        {
            Console.Write("Tâm: ");
            c.Print();
            Console.WriteLine($"Bán kính: {r}");
            Console.WriteLine($"Diện tích: {Area():F2}");
        }
    }

    // Chương trình chính
    class Program
    {
        static void Main(string[] args)
        {
            // Tạo các hình tròn
            Circle c1 = new Circle(5, new Point(0, 0));
            Circle c2 = new Circle(3, new Point(2, 4));

            Console.WriteLine("Hình tròn 1:");
            c1.Print();

            Console.WriteLine("\nHình tròn 2:");
            c2.Print();

            // Di chuyển hình tròn
            c1.Move(2, 3);
            Console.WriteLine("\nHình tròn 1 sau khi di chuyển:");
            c1.Print();

            Console.ReadLine();
        }
    }
}