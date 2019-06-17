using System;

namespace sochan
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do{
                Console.WriteLine("Nhap so chu so: ");
                n = Convert.ToInt16(Console.ReadLine());
            } while(n <= 0 || n > 5);
            
            double min = Math.Pow(10, n-1);
            double max = Math.Pow(10, n);
            for (double i = min; i < max; i++)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        
        
    }
}
