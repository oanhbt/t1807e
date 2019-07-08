using System;
using System.Collections;

namespace AddStudent
{
    class Student
    {
        private string name;
        private string gender;
        private string born;

        public string getName() {
            return this.name;
        }

        public void setName(string name) {
            this.name = name;
        }

        public string getGender() {
            return this.gender;
        }

        public void setGender(string gender) {
            this.gender = gender;
        }

        public string getBorn() {
            return this.born;
        }

        public void setBorn(string born) {
            this.born = born;
        }
        Student()
        {
            
        }
   

    }
    class Program
    {
        

       
        static void Main(string[] args)
        Student[] listStudent = new Student[5];
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Nhap vao sinh vien thu nhat: ");
                string name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Nhap ten: ");
                string gender = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Nhap gioi tinh: ");
                string born = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Nhap nam sinh: ");
                Student stu = new Student(name, gender, born);

            }
        }
    }
}
