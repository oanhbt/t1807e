using System;

namespace StaticMethod
{
    class RefProgram
    {
        static void Calculate(ref int numValueOne, ref int numValueTwo)
        {
            numValueOne = numValueOne *2;
            numValueTwo = numValueTwo / 2;
            
        }
        static void Main(string[] args)
        {
            int numOne = 10;
            int numtwo = 20;
            Console.WriteLine("value of Num1 and Num2 before calling method "+ numOne+", "+numtwo);
            Calculate(ref numOne, ref numtwo);
            Console.WriteLine("value of Num1 and Num2 after calling method "+ numOne+", "+numtwo);
        }
    }
}
