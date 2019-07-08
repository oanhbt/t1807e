using System;

namespace thamchieu
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] classOne = {"Nguyen","Allan","John"};
            string[] classTwo = {"Katie","Niel","Mark"};

            Console.WriteLine("Student of class I:\tStudent of class II:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(classOne[i] + "\t\t\t" + classTwo[i]);

            }
            classTwo = classOne;
            Console.WriteLine("\nStudents of class II after referencing Class I:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(classTwo[i]+" ");
            }
            Console.WriteLine();
            classTwo[2] = "Mike";
            Console.WriteLine("\nStudents of class I after changing the third student in Class II:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(classOne[i]+" ");
            }
            
        }
    }
}
