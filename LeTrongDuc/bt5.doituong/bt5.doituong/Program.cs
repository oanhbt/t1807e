using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt5.doituong
{
    class Student
    {
        string _TenSv = "Duc"; // Có gạch dưới để xác định là properties của class
        int _Tuoi = 27;
        void Display()
        {
            Console.WriteLine("Ten cua SV : " + _TenSv);
            Console.WriteLine("Tuoi cua SV : " + _Tuoi);
        }
        void Display(String firstName, String lastName) 
        {
            Console.WriteLine("Ten la {0}, Ho la {1} ", firstName, lastName);
        }
        static void Main(string[] args)
        {
            Student sinhvien = new Student();
            sinhvien.Display();
            sinhvien.Display(lastName : "Le", firstName : "Duc");
            Console.ReadLine();
        }

    }

    class Object1
    { 
        
    }
}
