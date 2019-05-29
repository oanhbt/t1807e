using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exame2
{
    class Students
    {
        string _studName = "James Anderson";
        int _studAge = 27;
        void display()
        {
            Console.WriteLine("Student Name:" + _studName);
            Console.WriteLine("Student Age:" + _studAge);
        }
    }
    class Program
    {
        void StudentDetails()
        {
            Console.Write("Enter the number of Student:");
            int noOfStds = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number exams :");
            int exams = Convert.ToInt32(Console.ReadLine());
            string[] stdName = new String [noOfStds];
            string[,] details = new string [noOfStds, exams];
            for (int i = 0; i < noOfStds;i++ )
            {
                Console.WriteLine();
                Console.Write("Enter the name student:");
                stdName[i] = Convert.ToString(Console.ReadLine());
                for (int y = 0; y < exams; y++)
                {
                    Console.Write("Enter score in exams" + y+1 +":");
                    details[i, y] = Convert.ToString(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.WriteLine("Student exam Details");
            Console.WriteLine("=====================");
            Console.WriteLine();
            Console.WriteLine("Student\t\tMarks:");
            Console.WriteLine("=====\t\t========");
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
            Students stud = new Students();
            stud.display();
            //Program e = new Program();
            //e.StudentDetails();
            Console.ReadLine();
        }
    }
}
