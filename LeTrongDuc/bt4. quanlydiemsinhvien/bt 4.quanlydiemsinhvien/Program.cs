using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt_4.quanlydiemsinhvien
{
    class Program
    {
        static void Main(string[] args)
        {
            Program ChiTietSV = new Program();
            ChiTietSV.ChitietSv();
        }
        void ChitietSv()
        { 
            Console.WriteLine("Nhap so Sinh vien");
            int SoSv = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so bai thi");
            int SoBaiThi = Convert.ToInt32(Console.ReadLine());

            string[] TenSv = new string[SoSv];
            string[,] ChiTiet = new string[SoSv, SoBaiThi];

            for (int i = 0; i < SoSv; i++ )
            {
                Console.WriteLine();
                Console.WriteLine("Nhap ten SV :");
                TenSv[i] = Convert.ToString(Console.ReadLine());
                for (int j = 0; j < SoBaiThi; j++)
                {
                    Console.WriteLine("Nhap diem cua sinh vien " + (j + 1));
                    ChiTiet[i, j] = Convert.ToString(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.WriteLine("Chi tiet diem cua SV :");
            Console.WriteLine("----------------------");
            Console.WriteLine();
            Console.WriteLine("Sinh vien\t\tDiem");
            Console.WriteLine("Sinh vien\t\tDiem");
            for ( int i = 0; i < TenSv.Length; i++)
            {
                Console.WriteLine(TenSv[i]);
                for ( int j = 0; j < SoBaiThi; j++)
                {
                    Console.WriteLine("\t\t" + ChiTiet[i,j]);
                }
               
               
            }
            Console.ReadLine();
        }
    }
}
