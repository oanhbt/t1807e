using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exame
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] classOne = {"ALLAN","Chris","Monica" };
            string[] classTwo = {"Katie", "Niel", "Mark" };
            Console.WriteLine("Student of class I:\t Students of class II");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(classOne[i] + "\t\t\t" + classTwo[i]);
            }
            classTwo = classOne;
            Console.WriteLine("\nStudents of class II after referencing class I:");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(classOne[i] + "");
            }
            Console.WriteLine();
            classTwo[2] = "Mike";
            Console.WriteLine("Students of class I after changing the third student in class II:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(classOne[i] + "");
            }
                //int [,] dimension = new int [4,5];
                //int numOne = 0;
                //for (int i = 0; i < 4; i++)
                //{
                //    for (int j = 0; j < 5; j++)
                //    {
                //        dimension[i, j] = numOne;
                //        numOne++;
                //    }
                //}
                //for (int i = 0; i < 4; i++)
                //{
                //    for (int j = 0; j < 5; j++)
                //    {
                //        Console.WriteLine(dimension [i,j] + "");
                //    }
                //    Console.WriteLine();
                //}
                Console.ReadLine();
        }
    }
}
