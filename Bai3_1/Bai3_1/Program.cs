using System.Collections;
namespace Bai3_1
{
    public class Xe
    {
        private String bienSo;
        private int namSX;
        private double gia;
        
        //constructor co tham so
        public Xe()
        {
            bienSo = "000-00000";
            namSX = 2026;
            gia = 0;
        }
        //constructor khong co tham so
        public Xe(String bienSo, int namSX, double gia)
        {
            this.bienSo = bienSo;
            this.namSX = namSX;
            this.gia = gia;
        }
        
        //getter - setter
        public string BienSo
        {
            get { return bienSo; }
            set
            {
                if(value.Length >= 9) bienSo = value;
            }
        }

        public int NamSX
        {
            get { return namSX; }
            set
            {
                if(value >= 2000) namSX = value;
            }
        }
        
        public double Gia 
        {
            get { return gia; }
            set
            {
                if(value >= 0) gia = value;
            }
        }

        public double getGia()
        {
            return gia;
        }

        public String getBienSo()
        {
            return bienSo;
        }

        public int getNamSX()
        {
            return namSX;
        }
        
        //nhap thong tin
        public virtual void Nhap()
        {
            Console.Write("Vui long nhap bien so xe: ");
            bienSo = Console.ReadLine();
            Console.Write("Vui long nhap nam san xuat: ");
            namSX = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vui long nhap gia xe thu: ");
            Gia = Convert.ToDouble(Console.ReadLine());
            
        }
        
        //xuat thong tin
        public virtual void Xuat()
        {
            Console.WriteLine("Bien so: " + BienSo);
            Console.WriteLine("Nam san xuat: " + NamSX);
            Console.WriteLine("Gia: " + gia);
            
        }
    }

    public class XeCon : Xe
    {
        private int soChoNgoi;
        private String loaiXe;
        
        // constructor co tham so
        public XeCon()
        {
            soChoNgoi = 0;
            loaiXe = "NONE";
        }
        
        // constructor khong co tham so
        public XeCon(String bienSo, int namSX, double gia, int soChoNgoi, String loaiXe) : base(bienSo, namSX, gia)
        {
            this.soChoNgoi = soChoNgoi;
            this.loaiXe = loaiXe;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Vui long nhap so cho ngoi: ");
            soChoNgoi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vui long nhap loai xe: ");
            loaiXe = Console.ReadLine();
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("So cho ngoi: " + soChoNgoi);
            Console.WriteLine("Loai xe: " + loaiXe);
        }
        
        public double getGia()
        {
            return base.getGia();
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList ds = new ArrayList();
            Console.Write("Bai3_1 | Vui long nhap n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                XeCon xe = new XeCon();

                Console.WriteLine("NHAP THONG TIN XE THU " + (i+1) + ": ");
                xe.Nhap();
                ds.Add(xe);
            }
            
            //tim min max
            double min = 10000000000;
            double max = 0;
            int pmin = 0;
            int pmax = 0;
            for (int i = 0; i < ds.Count; i++)
            {
                XeCon xeCon = (XeCon)ds[i];
                if (xeCon.getGia() < min)
                {
                    pmin = i;
                    min = xeCon.getGia();
                    
                } else if (xeCon.getGia() > max)
                {
                    pmax = i;
                    max =  xeCon.getGia();
                }
            }
            XeCon xmin = (XeCon)ds[pmin];
            XeCon xmax = (XeCon)ds[pmax];
            Console.WriteLine("XE CO GIA THAP NHAT LA: ");
            xmin.Xuat();
            Console.WriteLine("XE CO GIA CAO NHAT LA: ");
            xmax.Xuat();
            
            //Tim bien so xe
            String bsXeDau;
            Console.Write("Vui long nhap bien can tim kiem: ");
            bsXeDau = Console.ReadLine();
            Console.Write("Cac xe co bien so " + bsXeDau + " la: ");
            for (int i = 0; i < ds.Count; i++)
            {
                XeCon xeCon = (XeCon)ds[i];
                if (xeCon.getBienSo().StartsWith(bsXeDau))
                {
                    Console.Write(xeCon.getBienSo() + " ");
                }
            }
            
            //sort
            for (int i = 0; i < ds.Count; i++)
            {
                for (int j = i + 1; j < ds.Count; j++)
                {
                    XeCon a = (XeCon)ds[i];
                    XeCon b = (XeCon)ds[j];
                    if (a.getNamSX() > b.getNamSX())
                    {
                        ds[i] = b;
                        ds[j] = a;
                    }
                }
            }
            //DEBUG SORT
            Console.WriteLine("XE SAU KHI SAP XEP THEO NAM (THAP -> CAO): ");
            foreach (XeCon xe in ds)
            {
                xe.Xuat();
            }
        }
    }
}