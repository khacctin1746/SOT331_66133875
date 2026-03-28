using System.Collections;

namespace  Bai4_2
{
    class Program
    {

        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            Console.Write("Nhap n: "); int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("+ VUI LONG CHON HINH ");
                Console.WriteLine("- (1). Hinh chu nhat");
                Console.WriteLine("- (2). Hinh tron");
                Console.WriteLine("- (3). Hinh tam giac");
                Console.Write("= Nhap tai day: "); int opt =  Convert.ToInt32(Console.ReadLine());
                if (opt == 1)
                {
                    Console.WriteLine("= = = = = = = = = =");
                    Console.WriteLine("+ HINH CHU NHAT " + (i+1));
                    Console.Write("- Nhap width = "); double wi = Convert.ToDouble(Console.ReadLine());
                    Console.Write("- Nhap height = "); double hi = Convert.ToDouble(Console.ReadLine());
                    Rectangle rectangle = new Rectangle( wi, hi,"+ Hinh Chu Nhat " + (i+1));
                    list.Add(rectangle);
                } else if (opt == 2)
                {
                    Console.WriteLine("= = = = = = = = = =");
                    Console.WriteLine("+ HINH TRON");
                    Console.Write("- Vui long nhap radius = "); double rad = Convert.ToDouble(Console.ReadLine());
                    Circle circle = new Circle(rad, "Hinh Tron" + (i+1));
                    list.Add(circle);
                } else if (opt == 3)
                {
                    Console.WriteLine("= = = = = = = = = = = =");
                    Console.WriteLine("+ HINH TAM GIAC");
                    Console.Write("- Vui long nhap a = "); double a =  Convert.ToDouble(Console.ReadLine());
                    Console.Write("- Vui long nhap b = "); double b = Convert.ToDouble(Console.ReadLine());
                    Console.Write("- Vui long nhap c = "); double c = Convert.ToDouble(Console.ReadLine());
                    Triangle triangle = new Triangle("Hinh Tam Giac " + (i+1), a, b, c);
                    list.Add(triangle);
                }
                else
                {
                    Console.WriteLine("Chon gi vay bro?");
                }
            }
            
            // TIM MAX
            double max = 0;
            string nameMax = " ";
            foreach (Shape s in list)
            {
                if (s.Area() > max)
                {
                    max = s.Area();
                    nameMax = s.Name();
                }
            }
            
            foreach (object obj in list)
            {
                if (obj is Rectangle r)
                {
                    Console.WriteLine(r.Name());
                    Console.WriteLine("- Width = " + r.getWidth());
                    Console.WriteLine("- Height = " + r.getHeight());
                    Console.WriteLine("- Area = " + r.Area());
                }

                if (obj is Circle c)
                {
                    Console.WriteLine(c.Name());
                    Console.WriteLine("- Radius = " + c.getRadius());
                    Console.WriteLine("- Area = " + c.Area());
                }
                
                if (obj is Triangle tr)
                {
                    Console.WriteLine(tr.Name());
                    Console.WriteLine("- Canh a = " + tr.getA());
                    Console.WriteLine("- Canh b = " + tr.getB());
                    Console.WriteLine("- Canh c = " + tr.getC());
                    Console.WriteLine("- Area = " + tr.Area());
                }
            }
            
            // TIM MAX
            Console.WriteLine("= = = = = = = = = = ");
            Console.WriteLine("= MAX DIEN TICH");
            Console.WriteLine(nameMax);
            Console.WriteLine("- Area: " + max);
            Console.Write("= = = = = = = = = = ");
            
            // SAPXEP
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i; j < list.Count; j++)
                {
                    
                }
            }
        }
    }
}