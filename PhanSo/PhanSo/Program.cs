using System;
namespace PhanSo
{
    public class PhanSo
    {
        private double TuSo;
        private double MauSo;
        private double TuSo1;
        private double MauSo2;

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