using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = Convert.ToInt16(Console.ReadLine());
            //String msg = "";
            //if (num < 0)
            //{
            //    msg = num + " la so nguyen am";
            //}
            //else if (num % 2 == 0)
            //{
            //    msg = num + " la so chan";
            //}
            //else
            //{
            //    msg = num + " la so le";
            //}
            //Console.WriteLine(msg);
            //Console.ReadLine();



            //Console.WriteLine("Nhap so: ");
            //int num = Convert.ToInt16(Console.ReadLine());

            //double start = Math.Pow(10, num - 1);
            //double end = Math.Pow(10, num) - 1;
            //if (num >= 1 && num <= 5)
            //{
            //    for (double i = start; i <= end; i++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            Console.WriteLine("{0} la so chan", i);
            //        }
            //        else
            //        {
            //            //Console.WriteLine("{0} la so le", i);
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Error");
            //}
            //Console.ReadLine();


            //In ra so dau va so cuoi cua 1 so nhap vao tu ban phim
            //Console.WriteLine("Nhap so: ");
            //int n = Convert.ToInt16(Console.ReadLine());
            
            
            //Console.WriteLine("So cuoi la: " + n % 10);
            //while(n/10 > 0)
            //{
            //    n = n / 10;   
            //}
            //Console.WriteLine("So dau la: " + n);
            //Console.ReadLine();


            Console.WriteLine("Nhap so thu 1: ");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Nhap so thu 2: ");
            int b = Convert.ToInt16(Console.ReadLine());
            bool check = true;
            
            while (true)
            {
                Console.WriteLine("---------MENU---------");
                Console.WriteLine("1. Cong hai so");
                Console.WriteLine("2. Tru hai so");
                Console.WriteLine("3. Nhan hai so");
                Console.WriteLine("4. Chia hai so");
                Console.WriteLine("5. Thoat!!!");

                Console.WriteLine("Moi lua chon: ");
                int choose = Convert.ToInt16(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Ket Qua: " + Cong(a, b));
                        break;
                    case 2:
                        Console.WriteLine("Ket Qua: " + Tru(a, b));
                        break;
                    case 3:
                        Console.WriteLine("Ket Qua: " + Nhan(a, b));
                        break;
                    case 4:
                        Console.WriteLine("Ket Qua: " + Chia(a, b));
                        break;
                    case 5:
                        break;
                }

                Console.WriteLine("Tiep tuc chon (Y/N): ");
                string qd = Convert.ToString(Console.ReadLine());
                if (!"Y".Equals(qd)) 
                {
                    break;
                }
            }

            Console.ReadLine();
        }
        public static int Cong(int x, int y)
        { 
            return (x + y);
        }
        public static int Tru(int x, int y)
        {
            return (x - y);
        }
        public static int Nhan(int x, int y)
        {
            return (x * y);
        }
        public static int Chia(int x, int y)
        {
            return (x / y);
        }
    }
}
