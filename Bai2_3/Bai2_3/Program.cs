using System;
using System.Security.Cryptography;

namespace Bai2_3
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        
        //Ham Move
        public void Move(int dx, int dy)
        {
            this.X += dx;
            this.Y += dy;
        }
        
        //Ham tinh khoang cach
        public double tinhKhoangCach()
        {
            double S = Math.Sqrt(Math.Pow(X - 0, 2) + Math.Pow(Y - 0, 2));
            return S;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Point> list = new List<Point>();
            Console.Write("Vui long nhap n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                list.Add(new Point(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
            }
            
            //In toa do
            foreach(Point p in list)
            {
                Console.WriteLine(p.X + " " + p.Y);
            }
            
            //Tim diem xa goc toa do nhat
            double max = 0;
            double maxX = 0;
            double maxY = 0;
            foreach (Point p in list)
            {
                if (p.tinhKhoangCach() > max)
                {
                    max = p.tinhKhoangCach();
                    maxX = p.X;
                    maxY = p.Y;
                }
            }
            Console.WriteLine(maxX + " "  + maxY);
            
            //Tim 2 diem gan goc toa do nhat
            Double tinhMinKC(double x1, double y1, double x2, double y2)
            {
                double kc = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
                return kc;
            }
            
            double min = tinhMinKC(list[0].X, list[0].Y, list[1].X, list[1].Y);
            double minX1 = 0;
            double minY1 = 0;
            double minX2 = 0;
            double minY2 = 0;
            for (int i = 0; i < list.Count; i++)
            {
                Point p1 = list[i];
                for (int j = i + 1; j < list.Count; j++)
                {
                    Point p2 = list[j];
                    if (tinhMinKC(p1.X, p1.Y, p2.X, p2.Y) < min)
                    {
                        min = tinhMinKC(p1.X, p1.Y, p2.X, p2.Y);
                        Console.WriteLine(tinhMinKC(p1.X, p1.Y, p2.X, p2.Y));
                        minX1 = p1.X;
                        minY1 = p1.Y;
                        minX2 = p2.X;
                        minY2 = p2.Y;
                    }
                }
            }
            Console.WriteLine(minX1 + " "  + minY1 + " "  + minX2 + " "  + minY2);
        }
    }
}