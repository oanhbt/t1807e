using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d27m5
{
    class Program
    {
        public static void bai1()
        {
            int num = Convert.ToInt16(Console.ReadLine());

            for (int i = (int)Math.Pow(10, num - 1); i < (int)Math.Pow(10, num); i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0}, ", i);
                }
            }
        }
        public static void bai2()
        {
            int num = Convert.ToInt16(Console.ReadLine());
            int sodu = num % 10;
            Console.WriteLine("So cuoi : " + sodu);

            num = num / 10;
            do
            {
                sodu = num % 10;
                num = num / 10;
            } while (num > 0);

            Console.WriteLine("So dau : " + sodu);
        }
        public static void bai3()
        {
            Console.Write("Nhap vao so thu nhat: ");
            int so1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vao so thu hai: ");
            int so2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1: cong");
            Console.WriteLine("2: tru");
            Console.WriteLine("3: nhan");
            Console.WriteLine("4: chia");
            Console.WriteLine("0: end");
            
            while (true)
            {
                String menu = Console.ReadLine();

                if (menu == "1")
                {
                    Console.WriteLine(so1 + " + " + so2 + " = " + (so1 + so2));
                    break;
                }else if(menu == "2")
                {
                    Console.WriteLine(so1 + " - " + so2 + " = " + (so1 - so2));
                    break;
                }else if(menu == "3")
                {
                    Console.WriteLine(so1 + " * " + so2 + " = " + (so1 * so2));
                    break;
                }else if(menu == "4")
                {
                    if(so2 == 0)
                    {
                        Console.WriteLine("ko the chia cho 0");
                    }
                    else
                    {
                        Console.WriteLine(so1 + " / " + so2 + " = " + (so1 / so2));
                        break;

                    }                   
                }else if(menu == "0")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Nhap sai roi hay nhap lai");
                }
            }
        }
        static void Main(string[] args)
        {
            //laysoschan
            //bai1();

            //in số đầu và số cuối của 1 số
            //bai2();

            //menu chon math
            bai3();
            Console.ReadKey(); 
        }
    }
}
