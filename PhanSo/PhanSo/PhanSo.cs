using System;
namespace PhanSo
{
    public class PhanSo
    {
        private double TuSo;
        private double MauSo;
        private double TuSo1;
        private double MauSo2;
        
        //constructor default
        public PhanSo()
        {
            TuSo = 1;
            MauSo = 1;
            TuSo1 = 1;
            MauSo2 = 1;
        }
        
        //constructor
        public PhanSo(double tuSo, double mauSo, double tuSo1, double mauSo2)
        {
            this.TuSo = tuSo;
            this.setMauSo(mauSo);
            this.TuSo1 = tuSo1;
            this.setMauSo1(mauSo2);
        }
        //getter
        public double getTuSo()
        {
            return TuSo;
        }

        public double getMauSo()
        {
            return MauSo;
        }

        public double getTuSo1()
        {
            return TuSo1;
        }

        public double getMauSo1()
        {
            return MauSo2;
        } 
        
        //setter
        public void setTuSo(double tuSo)
        {
            this.TuSo = tuSo;
        }

        public void setMauSo(double MauSo)
        {
            if (!(MauSo == 0))
            {
                this.MauSo = MauSo;
            }
            else
            {
                Console.WriteLine("Mau so khong duoc be hon khong");
            }
        }

        public void setMauSo1(double MauSo2)
        {
            if (!(MauSo2 == 0))
            {
                this.MauSo2 = MauSo2;
            }
            else
            {
                Console.WriteLine("Mau so khong duoc be hon khong");
            }
        }
        public void Nhap()
        {
            TuSo = Convert.ToDouble(Console.ReadLine());
            MauSo = Convert.ToDouble(Console.ReadLine());
            TuSo1 = Convert.ToDouble(Console.ReadLine());
            MauSo2 = Convert.ToDouble(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("Phan so 1: " + TuSo + "/" + MauSo);
            Console.WriteLine("Phan so 2: " + TuSo1 + "/" + MauSo2);
        }

        public void ToiGian()
        {
            double gcd(double n1, double n2)
            {
                if (n2 == 0)
                {
                    return n1;
                }
                return gcd(n2, n1 % n2);
            }
            
            double tu = TuSo * MauSo2 + TuSo1 * MauSo;
            double mau = MauSo * MauSo2;
            double n = gcd(tu, mau);
            tu /= n;
            mau /= n;
            Console.WriteLine(tu + "/" + mau);
        }

        public void CongPhanSo()
        {
            double tu = TuSo * MauSo2 + TuSo1 * MauSo;
            double mau = MauSo * MauSo2;
            
            Console.WriteLine(tu + "/" + mau);
        }

        public void TruPhanSo()
        {
            double tu = TuSo * MauSo2 - TuSo1 * MauSo;
            double mau = MauSo * MauSo2;
            Console.WriteLine(tu + "/" + mau);
        }
    }
    
    class Program   
    {
        static void Main(string[] args)
        {
            PhanSo p = new PhanSo();
            p.Nhap();
            p.Xuat();
            p.ToiGian();
            p.CongPhanSo();
            p.TruPhanSo();
        }
    }
}