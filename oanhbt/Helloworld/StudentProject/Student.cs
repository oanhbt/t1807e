using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProject
{
    class Student
    {
        private string _fullname;

        public string Fullname
        {
            get { return _fullname; }
            set { _fullname = value; }
        }

        


        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        private string gender;

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        private string fblink;

        public string Fblink
        {
            get { return fblink; }
            set { fblink = value; }
        }


    }
}
