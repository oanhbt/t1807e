using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            Int32 num1 = 0;
            Int32 num2 = 0;


            while (flag)
            {

                Console.WriteLine("--------Menu--------");
                Console.WriteLine("1.Cong");
                Console.WriteLine("2.Tru");
                Console.WriteLine("3.Nhan");
                Console.WriteLine("4.Chia");
                Console.WriteLine("5.Thoat");
                Console.WriteLine("Moi Chon phuong an :");
                int choice = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("--------------------");
                Program pro = new Program();
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Nhap so thu nhat :");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Nhap so thu hai :");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ket qua phep cong la : {0}", pro.cong(num1, num2));
                        break;
                    case 2:
                        Console.WriteLine("Nhap so thu nhat :");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Nhap so thu hai :");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ket qua phep tru la : {0}", pro.tru(num1, num2));
                        break;
                    case 3:
                        Console.WriteLine("Nhap so thu nhat :");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Nhap so thu hai :");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ket qua phep nhan la : {0}", pro.nhan(num1, num2));
                        break;
                    case 4:
                        Console.WriteLine("Nhap so thu nhat :");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Nhap so thu hai :");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ket qua phep chia la : {0}", pro.chia(num1, num2));
                        break;
                    case 5:
                        Console.WriteLine("Bye...");
                        flag = false;
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Nhap lai");
                        break;
                }
            }
        }

        public Int32 cong(Int32 num1, Int32 num2)
        {
            return num1 + num2;
        }

        public Int32 tru(Int32 num1, Int32 num2)
        {
            return (num1 - num2);
        }

        public Int32 nhan(Int32 num1, Int32 num2)
        {
            return (num1 * num2);
        }

        public Double chia(Int32 num1, Int32 num2)
        {
            if (num2 == 0)
            {
                return 0;
            }
            else
            {
                return num1 / num2;
            }
        }
    }
}
