using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThongTinNhanVien;
using ThongTinGiaDinh;
using ThongTinLuong;

//Quản nhân viên Gồm có: 
//1. Thông tin nhân viên: Mã NV, Tên NV 
//2. Thông tin lương: Mã nhân viên, Lương, Tháng 
//3. Thông tin gia đình: Mã nhân viên, Tên người thân, Quan hệ, Năm sinh 
//Tổ chức code:
//•	Thông tin nhân viên đặt trong namespace: QLNV.ThongTinSinhVien
//•	Thông tin lương đặt trong namespace: QLNV.ThongTinLuong
//•	Thông tin gia đình đặt trong namespace: QLNV.ThongTinGiaDinh 
//Chức năng:
//•	Thêm mới 1 nhân viên
//•	Cập nhật lương tháng 5 cho nhân viên
//•	Thêm mới thông tin thành viên gia đình của nhân viên
//•	Hiển thị toàn bộ thông tin nhân viên(Thông tin cơ bản, thông tin lương tháng 5, thông tin gia đình)
//Đánh index giúp việc tìm kiếm nhanh hơn trang 40 ses 9
namespace QuanLyNhanVien
{
    class Program
    {
        List<NhanVien> MangNV = new List<NhanVien>();
        List<LuongNV> MangLuongNV = new List<LuongNV>();
        List<GiaDinhNV> MangGiaDinhNV = new List<GiaDinhNV>();
        
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so Nhan vien :");
            short SoNv = Convert.ToInt16(Console.ReadLine());
            Program pro = new Program();
            bool flag = true;
            int choice = 0;
            while(flag)
            {
                Console.WriteLine("-------***------");
                Console.WriteLine("1.Them Nhan Vien");
                Console.WriteLine("2.Cap nhat luong Nhan Vien theo thang");
                Console.WriteLine("3.Them moi thong tin gia dinh nhan vien");
                Console.WriteLine("4. Hien thi thong tin Nhan Vien");
                Console.WriteLine("5. Thoat");
                Console.WriteLine("-------***------");
                choice = Convert.ToInt16(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        pro.ThemNV(SoNv);
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        pro.Show();
                        break;
                    case 5:
                        flag = false;
                        break;
                }
            }
        }

        public void ThemNV(short SoNv)
        {
            for (int i = 0; i < SoNv; i++)
            {
                Console.WriteLine("Nhap ID NhanVien :");
                short MaNV = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Nhap Ten NhanVien :");
                string TenNV = Convert.ToString(Console.ReadLine());
                NhanVien Nvien = new NhanVien(MaNV, TenNV);
                MangNV.Add(Nvien);

                for (int j = 0; j < 12; j++)
                {
                    int Thang = j + 1;
                    double luong = (j+1)*10000000;
                    LuongNV Luongnvien = new LuongNV(MaNV, Thang, luong);
                    MangLuongNV.Add(Luongnvien);
                }
                
            }
        }

        public void ThemLuongNV(short SoNv)
        {
            if (MangNV != null)
            {
                for (int i = 0; i < SoNv; i++)
                {
                    Console.WriteLine("Nhap ID NhanVien :");
                    short MaNV = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Nhap Ten NhanVien :");
                    string TenNV = Convert.ToString(Console.ReadLine());
                    LuongNV LuongNvien = new LuongNV();
                    MangLuongNV.Add(LuongNvien);
                }
            }
            else
            {
                Console.WriteLine("Non nhan vien");
            }
        }

        public void Show()
        { 
            foreach(NhanVien nv in MangNV)
            {
                Console.WriteLine("Ma So Nhan Vien la {0}, ten nhan vien la {1}",nv.MaNV,nv.TenNV );
                
            }
            foreach (LuongNV lg in MangLuongNV)
            {
                Console.WriteLine("thang {0}, luong {1}", lg.Thang, lg.LuongNhVien);
            }
            Console.ReadLine();
        }
    }

}
