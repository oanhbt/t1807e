using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt3
{
    class StudentReferences
    {
        static void Main(string[] args)
        {
            string[] classOne = { "Allan", "Chris", "Monica"};
            string[] classTwo = { "Allan", "Chris", "Monica" };
            Console.WriteLine("Students of Class I:\tStudents of Class II");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(classOne[i] + "\t\t\t" + classTwo[i]);
            }
            classTwo = classOne;
            Console.WriteLine("\nStudents of Class II after referencing Class I:");
            for (int i = 0; i < 3; i++ )
            {
                Console.WriteLine(classTwo[i] + " ");
            }
            Console.WriteLine();
            classTwo[2] = "Mike";
            Console.WriteLine("Students of Class I after changing the 3rd student in Class II ");
            for (int i = 0; i < 3; i++ )
            {
                Console.WriteLine(classOne[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
