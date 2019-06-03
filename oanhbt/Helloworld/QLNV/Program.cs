using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV
{
    class Program
    {
        ThongTinNhanVien.NhanVien[] lsNhanVien = new ThongTinNhanVien.NhanVien[10];
        List<ThongTinNhanVien.NhanVien> lsNV = new List<ThongTinNhanVien.NhanVien>();
        int count = 0;

        void themNhanVien()
        {
            if (count >= 9)
            {
                Console.WriteLine("Ds day, ko the nhap them");
            }
            else
            {
                ThongTinNhanVien.NhanVien nv = new ThongTinNhanVien.NhanVien();
                nv.MaNV = Console.ReadLine();
                nv.TenNV = Console.ReadLine();

                lsNhanVien[count++] = nv;

                //lsNV.Add(nv);
            }
        }

        void themLuong(string maNV)
        {
        }

        void themNguoiThan(string maNV)
        {
        }

        void hienthiNhanVien()
        {
            Console.WriteLine("************ DS *****************");

            
            for (int i = 0; i < count; i++ )
            //foreach (ThongTinNhanVien.NhanVien nv in lsNhanVien)
            {
                ThongTinNhanVien.NhanVien nv = lsNhanVien[i];
                Console.WriteLine(nv.MaNV);
                Console.WriteLine(nv.TenNV);
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.themNhanVien();
            p.hienthiNhanVien();
        }
    }
}
