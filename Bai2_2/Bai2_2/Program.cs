using System;
namespace Bai2_2
{
    public class DSPhanSo
    {
        private double[] tu;
        private double[] mau;
        
        //constructor
        public DSPhanSo()
        {
            tu = new double[2];
            mau = new double[2];
        }
        
        public void Nhap()
        {
            for (int i = 0; i < tu.Length; i++)
            {
                Console.Write("Vui long nhap tu so cua phan so thu " + i + ":" );
                tu[i] = Convert.ToDouble(Console.ReadLine());
                Console.Write("Vui long nhap mau so cua phan so thu " + i + ":" );
                mau[i] = Convert.ToDouble(Console.ReadLine());
            }
        }

        public void Xuat()
        {
            for (int i = 0; i < tu.Length; i++)
            {
                Console.WriteLine(tu[i] + "/"  + mau[i]);
            }
        }

        public double Chia(double tu, double mau)
        {
            double n = tu/mau;
            return n;
        }

        public void timPhanSoLonNhat()
        {
            double n = 0;
            double maxTu = 0;
            double maxMau = 0;
            
            for (int i = 0; i < tu.Length; i++)
            {
                if (Chia(tu[i], mau[i]) > n)
                {
                    n = Chia(tu[i], mau[i]);
                    maxTu = tu[i];
                    maxMau = mau[i];
                }
            }
            
            Console.WriteLine(maxTu + "/" + maxMau);
        }

        public void SapXep()
        {
            for (int i = 0; i < tu.Length; i++)
            {
                for (int j = i; j < tu.Length; j++)
                {
                    if (Chia(tu[j], mau[j]) < Chia(tu[i], mau[i]))
                    {
                        double sav1;
                        double sav2;
                        sav1 = tu[i];
                        sav2 = mau[i];
                        tu[i] = tu[j];
                        mau[i] = mau[j];
                        tu[j] = sav1;
                        mau[j] = sav2;
                    }
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DSPhanSo ds = new DSPhanSo();
            ds.Nhap();
            ds.Xuat();
            ds.timPhanSoLonNhat();
            ds.SapXep();
        }
    }
}