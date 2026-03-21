using System.Collections;

namespace Bai3_2
{
    public class NhanVien
    {
        private String hoTen;
        private String ngaySinh;
        
        
        //construtor default
        public NhanVien()
        {
            hoTen = "?";
            ngaySinh = "?";
        }
        
        //constructor
        public NhanVien(String hoTen, String ngaySinh)
        {
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
        }

        public String HoTen
        {
            get { return hoTen; }
            set
            {
                if(value.Length != 0) hoTen = value;
            }
        }

        public String NgaySinh
        {
            get { return ngaySinh; }
            set
            {
                if(value.Length != 0) ngaySinh = value;
            }
        }
        
        public void Nhap()
        {
            Console.Write("Vui long nhap ho ten nhan vien: ");
            hoTen = Console.ReadLine();
            Console.Write("Vui long nhap ngay sinh: ");
            ngaySinh = Console.ReadLine();
        }

        public void Xuat()
        {
            Console.Write("Ho ten: " + hoTen);
            Console.Write("Ngay sinh: " + ngaySinh);
        }
    }

    public class NhanVienSanXuat : NhanVien
    {
        private double luongCB;
        private double soSanPham;

        public NhanVienSanXuat()
        {
            luongCB = 1;
            soSanPham = 1;
        }

        public NhanVienSanXuat(String hoTen, String ngaySinh, double luongCB, double soSanPham)  : base(hoTen, ngaySinh)
        {
            this.luongCB = luongCB;
            this.soSanPham = soSanPham;
        }

        public new void Nhap()
        {
            base.Nhap();
            Console.Write("Vui long nhap luong can ban: ");
            luongCB = Convert.ToDouble(Console.ReadLine());
            Console.Write("Vui long so san pham ");
            soSanPham = Convert.ToDouble(Console.ReadLine());
        }

        public new void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Luong: " + getLuong());
        }

        public double getLuong()
        {
            return luongCB * soSanPham * 5000;
        }
    }
    public class NhanVienVanPhong : NhanVien
    {
        private double luong;
        private double ngayLamViec;
        

        public NhanVienVanPhong()
        {
            ngayLamViec = 0;
        }

        public NhanVienVanPhong(String hoTen, String ngaySinh, double ngayLamViec) : base(hoTen, ngaySinh)
        {
            this.ngayLamViec = ngayLamViec;
        }

        public new void Nhap()
        {
            base.Nhap();
            Console.Write("Vui long nhap ngay lam viec: ");
            ngayLamViec = Convert.ToDouble(Console.ReadLine());
        }
        
        public new void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Luong: " + getLuong());
        }

        public double getLuong()
        {
            return ngayLamViec * 100000;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList ds = new ArrayList();
            Console.Write("Vui long nhap n nhan vien: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Vui long chon loai nhan vien: 1 - Van Phong | 2 - SanXuat ");
                int option = Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                {
                    NhanVienVanPhong vp = new NhanVienVanPhong();
                    vp.Nhap();
                    ds.Add(vp);
                } else if (option == 2)
                {
                    NhanVienSanXuat xx =  new NhanVienSanXuat();
                    xx.Nhap();
                    ds.Add(xx);
                }
            }
        }
    }
}