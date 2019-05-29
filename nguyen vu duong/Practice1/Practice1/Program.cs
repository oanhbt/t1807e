using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class Program
    {
        static void add(int num1,int num2)
        {
            int num3;
            num3 = num1 + num2;
            Console.WriteLine("tong hai so la {0}", num3);
        }
        static void sub(int num1, int num2)
        {
            int num3;
            num3 = num1 - num2;
            Console.WriteLine("hieu hai so la {0}", num3);
        }
        static void mul(int num1, int num2)
        {
            int num3;
            num3 = num1 + num2;
            Console.WriteLine("tich hai so la {0}", num3);
        }
        static void div(int num1, int num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("khong ton tai phep chia:");
            }
            else
            {
            int num3;
            num3 = num1 + num2;
            Console.WriteLine("thuong hai so la {0}", num3);
            }

            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("nhap hai so:");
            Console.WriteLine("==============");
            Console.WriteLine("nhap so thu nhat:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap so thu hai:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("xin lua chon chuc nang:");
            Console.WriteLine("========================");
            Console.WriteLine("1: tinh tong hai so");
            Console.WriteLine("2: tinh hieu hai so");
            Console.WriteLine("3: tinh tich hai so");
            Console.WriteLine("4: tinh thuong hai so");
            Console.WriteLine("0: thoat chung trinh");
            int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        add(a, b);
                        break;
                    case 2:
                        sub(a, b);
                        break;
                    case 3:
                        mul(a, b);
                        break;
                    case 4:
                        div(a, b);
                        break;
                    case 0:
                        break;
                    default:
                        break;
                }
                Console.ReadLine();
        }
    }
}
