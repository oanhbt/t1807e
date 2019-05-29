using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap so thu nhat:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap so thu hai:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("moi chon chuc nang:");
            int caseSwitch = Convert.ToInt32(Console.ReadLine());     
                switch (caseSwitch)
                {
                    case 1:
                        int resultPlus = num1 + num2;
                        Console.WriteLine(resultPlus);
                        break;
                    case 2:
                        int resultMinus = num1 - num2;
                        Console.WriteLine(resultMinus);
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }
            
        }
    }
}
