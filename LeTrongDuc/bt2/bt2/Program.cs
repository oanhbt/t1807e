using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//bt mảng
namespace bt2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] dimension = new int[4, 5];
            int NumOne = 0;
            for (int i = 0; i < 4; i++) 
            {
                for (int j = 0; j < 5; j++) 
                {
                    dimension[i, j] = NumOne;
                    NumOne++;
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(dimension[i, j] + " ");  
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
