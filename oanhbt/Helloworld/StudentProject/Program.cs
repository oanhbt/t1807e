//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentProject;

namespace StudentProjectA
{
    class Program
    {
        Student[] lsStudent = new Student[10];

        public void input()
        {
            for (int i = 0; i < 10; i++ )
            {
                Student s = new Student();
                s.Fullname = "Oanh" + i;
                s.Year = 1990 + i;
                s.Gender = i % 2 == 0 ? "Male" : "Female";
                lsStudent[i] = s;
            }
            
        }

        public void display()
        {
            for (int i = 0; i < 10; i++)
            {
                Student s = lsStudent[i];
                System.Console.WriteLine(s.Fullname);
            }
        }

        public void search(int year, string gender)
        {
            System.Console.WriteLine("========**************============");
            for (int i = 0; i < 10; i++)
            {
                Student s = lsStudent[i];
                if (s.Year >= year
                    && (gender == null || (gender != null && s.Gender == gender)))
                {
                    System.Console.WriteLine(s.Fullname);
                    System.Console.WriteLine(s.Year);
                }
            }
        }


        static void Main(string[] args)
        {
            Program p = new Program();
            p.input();
            p.display();
            p.search(1993, null);
            p.search(1995, "Male");
            System.Console.ReadLine();
        }
    }
}
