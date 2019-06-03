using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class StudentDetail
    {
        private string _stName = "duong";
        private int _stId = 29;
        public StudentDetail()
        {
            Console.WriteLine("student name: " + _stName);
            Console.WriteLine("student id :" + _stId);
        }
    }
}
