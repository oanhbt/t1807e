using System;

namespace chudauvacuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong n;
            do{
                Console.WriteLine("Nhap so nguyen duong: ");
                n = Convert.ToUInt64(Console.ReadLine());
            } while(n <= 0);
            string a = Convert.ToString(n);
            Console.WriteLine(a[0] +"-----"+a[a.Length-1]);
            
            
            
        }
    }
}
