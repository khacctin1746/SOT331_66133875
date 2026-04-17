using System;
using System.Collections;
using System.Collections.Generic;
namespace Bai1
{
    public class SinhVien
    {
        private string tenSV;
        private string maSV;
        private string gioiTinh;
        private int tuoi;
        private double diemToan;
        private double diemLy;
        private double diemHoa;

        //properties | PHẦN FIELDS/PROPERTIES
        public string TenSV{get => tenSV; set => tenSV = value;}
        public string MaSV{get => maSV; set => maSV = value;}
        public string GioiTinh{get => gioiTinh; set => gioiTinh = value;}
        public int Tuoi{get => tuoi; set => tuoi = value;}
        public double DiemToan{get => diemToan; set => diemToan = value;}
        public double DiemLy{get => diemLy; set => diemLy = value;}
        public double DiemHoa{get => diemHoa; set => diemHoa = value;}

        //constructor | PHẦN HÀM KHỞI TẠO
        public SinhVien()
        {
            this.tenSV = "";
            this.maSV = "";
            this.gioiTinh = "";
            this.tuoi = 0;
            this.diemToan = 0;
            this.diemLy = 0;
            this.diemHoa = 0;
        }

        public SinhVien(string tenSV, string maSV, string gioiTinh, int tuoi, double diemToan, double diemHoa, double diemLy)
        {
            this.tenSV = tenSV;
            this.maSV = maSV;
            this.gioiTinh = gioiTinh;
            this.tuoi = tuoi;
            this.diemToan = diemToan;
            this.diemHoa = diemHoa;
            this.diemLy = diemLy;
        }

        //methods | PHẦN HÀM XỬ LÍ
        public double diemTrungBinh()
        {
            return(diemToan + diemHoa + diemLy)/3;
        }

        public void HienThiThongTin()
        {
            Console.WriteLine("- Ma: " + maSV);
            Console.WriteLine("- Ten " + tenSV);
            Console.WriteLine("- Gioi tinh:" + gioiTinh);
            Console.WriteLine("- Tuoi: " + tuoi);
            Console.WriteLine("- Diem toan: " + diemToan);
            Console.WriteLine("- Diem ly: " + diemLy);
            Console.WriteLine("- Diem hoa: " + diemHoa);
            Console.WriteLine("- Diem TB: " + diemTrungBinh());
        }
        
        //getter/setter
        public string getMaSV()
        {
            return maSV;
        } 

        public string getTenSV()
        {
            return tenSV;
        }

    }
    public class Program
    {
        // KHAI BÁO LỚP SINH VIÊN DẠNG LIST ĐỂ MỖI PHẦN TỬ TRONG MỘT LIST ĐỀU LÀ LỚP SINH VIÊN RIÊNG
        private static List<SinhVien> ds = new List<SinhVien>();
        public static void Main(string[] args)
        {
            // du lieu cho truoc de test
            ds.Add(new SinhVien("Pham Van Tin", "66133875", "Nam", 19, 8, 8, 8));
            ds.Add(new SinhVien("Nguyen Khac Tin", "66133875", "Nam", 18, 5, 5, 5));
            ds.Add(new SinhVien("Le Thanh Tin", "66133875", "Nam", 19, 6, 6, 6));
            ds.Add(new SinhVien("Le Thanh Dat", "66133875", "Nam", 19, 2, 2, 1));
            while(true)
            {
                // Console.Clear();
                Menu();
                int luaChon = Convert.ToInt32(Console.ReadLine());
                switch(luaChon)
                {
                    case 1:
                        ThemSinhVien();
                        break;
                    case 2:
                        XoaSinhVien();
                        break;
                    case 3:
                        TimTheoTen();
                        break;
                    case 4:
                        HienThiFull();
                        break;
                    case 5:
                        TimTheoDTB();
                        break;
                    case 6:
                        SapXepSinhVien();
                        break;
                }
            }
        }

        public static void Menu()
        {
            Console.WriteLine("= = QUAN LI SINH VIEN = =");
            Console.WriteLine("1. Them sinh vien");
            Console.WriteLine("2. Xoa sinh vien theo ma");
            Console.WriteLine("3. Tiem kiem theo ten");
            Console.WriteLine("4. Hien thi tat ca sinh vien");
            Console.WriteLine("5. Hien thi sinh vien kha gioi (ĐTB >= 7.0)");
            Console.WriteLine("6. Sap xep sinh vien theo DTB giam dan");
            Console.WriteLine("0. Thoat");
            Console.Write("= Vui long nhap: ");
        }

        // PHẦN NỘI DUNG TẠO NHẬP
        public static void ThemSinhVien()
        {
            SinhVien sv = new SinhVien();
            Console.WriteLine("+ THEM SINH VIEN");
            Console.Write("- Vui long nhap ten sinh vien: ");
            sv.TenSV = Console.ReadLine();
            Console.Write("- Vui long nhap ma sinh vien: ");
            sv.MaSV = Console.ReadLine();
            Console.Write("- Vui long nhap gioi tinh sinh vien: ");
            sv.GioiTinh = Console.ReadLine();
            Console.Write("- Vui long nhap tuoi sinh vien: ");
            sv.Tuoi = int.TryParse(Console.ReadLine(), out int t) ? t : 0;
            Console.Write("- Vui long nhap diem toan: ");
            sv.DiemToan = double.TryParse(Console.ReadLine(), out double dt) ? dt : 0;
            Console.Write("- Vui long nhap diem hoa: ");
            sv.DiemHoa = double.TryParse(Console.ReadLine(), out double dh) ? dh : 0;
            Console.Write("- Vui long nhap diem ly: ");
            sv.DiemLy = double.TryParse(Console.ReadLine(), out double dl) ? dl : 0;
            ds.Add(sv);
            Console.WriteLine("= Nhap sinh vien thanh cong! Quay tro lai menu...");
        }

        // PHẦN NỘI DUNG XÓA
        public static void XoaSinhVien()
        {
            Console.Write("- Vui long nhap ma sinh vien can xoa: ");
            string maSV = Console.ReadLine();
            foreach(SinhVien sv in ds)
            {
                if(sv.getMaSV().Equals(maSV))
                {
                    sv.HienThiThongTin();
                    ds.Remove(sv);
                    Console.WriteLine("= Xoa thanh cong: " + maSV);
                    break;
                }
            }
        }

        // PHẦN NỘI DUNG TÌM KIẾM
        public static void TimTheoTen()
        {
            Console.Write("- Vui long nhap ten sinh vien: ");
            string tenSV = Console.ReadLine();
            foreach(SinhVien sv in ds)
            {
                if(sv.getTenSV().Contains(tenSV))
                {
                    Console.WriteLine();
                    sv.HienThiThongTin();
                    Console.WriteLine();
                }
            }
        }

        public static void TimTheoDTB()
        {
            foreach(SinhVien sv in ds)
            {
                if(sv.diemTrungBinh() >= 7.0)
                {
                    Console.WriteLine();
                    sv.HienThiThongTin();
                    Console.WriteLine();
                }
            }
        }

        // PHẦN DUYỆT DANH SÁCH HIỂN THỊ FULL THÔNG TIN
        public static void HienThiFull()
        {
            foreach(SinhVien sv in ds)
            {
                Console.WriteLine();
                sv.HienThiThongTin();
                Console.WriteLine();
            }
        }

        // PHẦN SẮP XẾP
        // Ở ĐÂY DÙNG SORT LIST, b.diemTrungBinh().CompareTo(a...) là sắp xếp giảm dần | a.diemTrungBinh().CompareTo(b...) là sắp xếp giảm dần

        public static void SapXepSinhVien()
        {
            ds.Sort((a, b) => b.diemTrungBinh().CompareTo(a.diemTrungBinh()));
            Console.WriteLine("= Sap xep sinh vien thanh cong! Quay tro lai menu...");
        }
    }

}