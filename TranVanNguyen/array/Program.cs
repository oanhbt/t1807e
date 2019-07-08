using System;

namespace array
{
    class Program
    {
        void StudentDetails()   
        {
            Console.WriteLine("Enter the num of Students: ");
            int noOfStds = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the num of exams: ");
            int exams = Convert.ToInt32(Console.ReadLine());

            string[] stdName = new string[noOfStds];
            string[,] details = new string[noOfStds, exams];

            for (int i = 0; i < noOfStds; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Enter the student name: ");
                stdName[i] = Convert.ToString(Console.ReadLine());
                for (int j = 0; j < exams; j++)
                {
                    Console.WriteLine("Enter score in Exam "+(j+1)+": ");
                    details[i, j] = Convert.ToString(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.WriteLine("Student exam details");
            Console.WriteLine("--------------------------");
            Console.WriteLine();
            Console.WriteLine("Student\t\tMarks");
            Console.WriteLine("-------\t\t-----");
            for (int i = 0; i < stdName.Length; i++)
            {
                Console.WriteLine(stdName[i]);
                for (int j = 0; j < exams; j++)
                {
                    Console.WriteLine("\t\t" + details[i,j]);
                }
                Console.WriteLine();
            }
            
        }
        static void Main(string[] args)
        {
            Program objStudentScore = new Program();
            objStudentScore.StudentDetails();
            Console.WriteLine();
            
        }
    }
}
