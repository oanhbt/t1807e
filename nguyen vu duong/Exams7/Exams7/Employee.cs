using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams7
{
    class Employee
    {
        private string _empName;
        private int _empID;
        public Employee()
        {
            _empName = "duong";
            _empID = 1010;
        }
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Employee objemp = emp;
            emp = null;
            try
            {
                Console.WriteLine("Employee name :" + emp._empName);
                Console.WriteLine("Employee ID:" + emp._empID);
            }
            catch (NullReferenceException objNull)
            {
                Console.WriteLine("Error:" + objNull);
            }
            catch (Exception objEx)
            {
                Console.WriteLine("Error:" + objEx);
            }
            Console.ReadLine();
        }
    }
}
