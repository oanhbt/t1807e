using System;

namespace baitap
{
    class Program
    {

        public static void tong()

        {
            int num1 = checkNhapSo("thu nhat");
            int num2 = checkNhapSo("thu hai");
            int add = num1 + num2;
            Console.WriteLine("tong hai so la {0} :", add);
        }

        public static void hieu()
        {
            int num1 = checkNhapSo("thu nhat");
            int num2 = checkNhapSo("thu hai");
            int add = num1 - num2;
            Console.WriteLine("hieu hai so la {0} :", add);
        }
        public static void tich()
        {
            int num1 = checkNhapSo("thu nhat");
            int num2 = checkNhapSo("thu hai");
            int add = num1 * num2;
            Console.WriteLine("tich hai so la {0} :", add);
        }
        public static void thuong()
        {
            int num1 = checkNhapSo("thu nhat");
            int num2 = checkNhapSo("thu hai");
            if (num2 == 0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                int add = num1 / num2;
                Console.WriteLine("thuong hai so la {0} :", add);
            }
        }


        static int checkNhapSo(String index)
        {
            int number;
            bool check = true;
            while (check)
            {
                try
                {
                    Console.WriteLine("Nhap vao so " + index+ ": ");
                    number = Convert.ToInt32(Console.ReadLine());
                    check = false;
                    return number;
                }
                catch (Exception)
                {
                    Console.WriteLine("Vui long nhap so ");

                }
            }
            return 0;
        }



        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("-----MENU------");
                Console.WriteLine("1. Tong hai so ");
                Console.WriteLine("2. Hieu hai so ");
                Console.WriteLine("3. Tich hai so ");
                Console.WriteLine("4. Thuong hai so ");
                Console.WriteLine("0. Ket thuc chuong trinh ");
                Console.WriteLine("Moi ban nhap chuc nang : ");
                int chucnang = Convert.ToInt16(Console.ReadLine());
                switch (chucnang)
                {
                    case 0:
                        Console.WriteLine("Bye Bye ...");
                        return;
                    case 1:
                        tong();
                        break;
                    case 2:
                        hieu();
                        break;
                    case 3:
                        tich();
                        break;
                    case 4:
                        thuong();
                        break;
                    default:
                        Console.WriteLine("Moi ban nhap so tu(0 - 4)");
                        break;
                        
                }
            } while (true);

            Console.ReadLine();
        }
    }
}
