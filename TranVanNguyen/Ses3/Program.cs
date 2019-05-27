using System;

namespace Ses3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt16(Console.ReadLine());
            string msg = "";
            if(num < 0)
            {
                msg = "The number "+num+" is negative";
            }
            else if(num %2 == 0)
            {
                msg = "The number "+num+" is even";
            }
            else
            {
                msg = "The number "+num+" is odd";
            }
            if(msg != "")
                Console.WriteLine(msg);
        }
    }
}
