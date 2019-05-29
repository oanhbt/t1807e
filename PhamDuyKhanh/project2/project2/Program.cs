using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao so thu 1:");
            int num1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Nhap vao so thu 2:");
            int num2  = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("=========888=========");

            Tong(num1, num2);
            Hieu(num1, num2);
            Tich(num1, num2);
            Thuong(num1, num2);
            Console.ReadLine();
        }
        public static void Tong(int a, int b)
        {
            Console.WriteLine("Tong 2 so la: " + (a + b));   
        }

        public static void Hieu(int a, int b)
        {
            Console.WriteLine("Hieu 2 so la: " + (a - b));
        }

        public static void Tich(int a, int b)
        {
            Console.WriteLine("Tich 2 so la: " + (a * b));
        }
        public static void Thuong(int a, int b)
        {
            Console.WriteLine("Thuong 2 so la: " + (a / b));
        }
    }
}