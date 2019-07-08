using System;

namespace VDmang2chieu
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] dimension = new int[4,5];
            int numOne = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    dimension [i,j] = numOne;
                    numOne++;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine(dimension[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
