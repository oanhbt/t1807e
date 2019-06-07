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
                Console.Write("Moi nhap lua chon : ");
                choice = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("-------***------");
                switch(choice)
                {
                    case 1:
                        pro.ThemNV();
                        break;
                    case 2:
                        pro.SuaLuongNV();
                        pro.Show();
                        break;
                    case 3:
                        pro.ThemTTGiaDinh();
                        break;
                    case 4:
                        pro.Show();
                        break;
                    case 5:
                        flag = false;
                        break;
                    default :
                        break;
                }
            }
        }

        public void ThemNV()
        {
            Console.Write("Nhap so Nhan vien can them : ");
            short SoNv = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("----------------");
            for (int i = 0; i < SoNv; i++)
            {
                Console.WriteLine("Nhap ID NhanVien :");
                short MaNV = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Nhap Ten NhanVien :");
                string TenNV = Convert.ToString(Console.ReadLine());
                NhanVien Nvien = new NhanVien(MaNV, TenNV);
                MangNV.Add(Nvien);
                Console.WriteLine("----------------");
                for (int j = 0; j < 12; j++)
                {
                    int Thang = j + 1;
                    double luong = (double)(i+j+1)*11;
                    LuongNV Luongnvien = new LuongNV(MaNV, Thang, luong);
                    MangLuongNV.Add(Luongnvien);
                }
                
            }
        }

        public void SuaLuongNV()
        {
                Console.WriteLine("Nhap Ma so nhan vien ");
                short IdNv = Convert.ToInt16(Console.ReadLine());
                
                Console.WriteLine("Nhap thang muon sua");
                short thang = Convert.ToInt16(Console.ReadLine());
               
                for (int i = 0; i < MangLuongNV.Count; i++ )
                {

                    if (IdNv == MangLuongNV[i].MaNV && thang == MangLuongNV[i].Thang)
                    {
                        Console.WriteLine("Nhap luong moi");
                        Console.WriteLine("{0}");
                        //MangLuongNV[i].GetType().GetProperty("LuongNhVien").SetValue( MangLuongNV[i], Convert.ToInt16(Console.ReadLine()));
                        MangLuongNV[i].LuongNhVien = Convert.ToInt16(Console.ReadLine());
                        break;
                    } 
                } 
        }

        public void ThemTTGiaDinh()
        {
            Console.Write("Nhap so nhan vien : ");
            short SoNv = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("----------------");
            for (int i = 0; i < SoNv; i++)
            {
                Console.WriteLine("Nhap ID NhanVien :");
                short MaNV = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Nhap Ten Nguoi than :");
                string TenNgThan = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Nhap quan he :");
                string QuHe = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Nhap nam sinh :");
                short NamSinh = Convert.ToInt16(Console.ReadLine());
                GiaDinhNV FamilyStaff = new GiaDinhNV(MaNV, TenNgThan, QuHe, NamSinh);
                MangGiaDinhNV.Add(FamilyStaff);
                Console.WriteLine("----------------");
            }
            Console.WriteLine("So element {0}", MangGiaDinhNV.Count);
        }

        public void Show()
        {
            Console.WriteLine("TenNV\tLuong   T1 T2 T3 T4 T5 T6 T7 T8 T9 T10 T11 T12");
            for (int i = 0; i < MangNV.Count; i++)
            {
                NhanVien nv = MangNV[i];
                Console.Write("{0}\t\t", nv.TenNV);
                for (int j = i*12; j < (i + 1) * 12; j++)
                {
                    LuongNV lgNv = MangLuongNV[j];
                    
                    Console.Write(String.Format("{0:#.##} ", lgNv.LuongNhVien));
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------");
            for (int m = 0; m < MangGiaDinhNV.Count; m++)
            {
                Console.WriteLine("Thong tin nguoi than : ");
                Console.WriteLine("MaNV\tTen\tQuanHe\tNamSinh");
                GiaDinhNV NgThanNv = MangGiaDinhNV[m];
                Console.WriteLine("{0}\t{1}\t{2}\t{3}",NgThanNv.MaNV, NgThanNv.TenNgThan, NgThanNv.QuHe, NgThanNv.NamSinh);
            }
            //foreach (LuongNV lg in MangLuongNV)
            //{
            //    Console.WriteLine("thang {0}, luong {1}",lg.Thang, lg.LuongNhVien);
            //}
            Console.ReadLine();
        }
    }

}
