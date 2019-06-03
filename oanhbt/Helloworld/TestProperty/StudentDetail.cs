using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class StudentDetail
    {
        private string _stuName = "Bui Oanh";
        private int _stId = 30;

        public StudentDetail()
        {
            Console.WriteLine("Student name: " + _stuName);
            Console.WriteLine("Student id: " + _stId);
        }
    }
}
