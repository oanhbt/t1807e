using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Nhap 1 so: ");
            //int num = Convert.ToInt16(Console.ReadLine());
            //String msg = "";
            //if (num < 0)
            //{
            //    msg = num + "la so nguyen";
            //}
            //else if (num % 2 == 0)
            //{
            //    msg = num + "la so chan";
            //}
            //else
            //{
            //    msg = num + "la so le";
            //}
            //Console.WriteLine(msg);
            //Console.ReadLine();

            //Nhap vao 1 so nguyen duong tu 1 - 5, hien thi tat ca
            //    so chan co so chu so = so nguyen duong vua nhap
            //vi du: nhap 1, hien thi : 2,4,6,8
            // nhap 2: hien thi: 10.12.14.56.88.99

            Console.WriteLine("Nhap vao 1 chu so: ");
            int num = Convert.ToInt16(Console.ReadLine());

            double start = Math.Pow(10,num -1);
            double end = Math.Pow(10, num) -1;

            for (double i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0} la so chan", i);
                }
                else
                {
                    //Console.WriteLine("{0} la so chan", i);
                }
            }
            //dung while
            double j = start;
            while (j <= end);
            {
                j++;
            }
            Console.ReadLine();
        }
    }
}
