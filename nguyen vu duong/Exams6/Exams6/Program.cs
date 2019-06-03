using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams6
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            int [] a = new int [4];
            for (int i=0; i < 4; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

                int dau = a[i];
                int cuoi = a[i];
                for (int i = 0; i <= cuoi; i++)
                {
                    if (a[i] % 10 == cuoi)
                    {
                        Console.WriteLine("so cuoi la:" + cuoi);
                    }
                }
            }

            //for (int j = 0; j <= cuoi; j++)
            //{

            //}
            
        }
    }
}
