using System;

namespace exception
{
    class Emp
    {
        private string _empName;
        private int _empId;
        public Emp()
        {
            _empName= "nguyen";
            _empId = 28;
        }
        static void Main(string[] args)
        {
            Emp objEmp = new Emp();
            Emp objE = objEmp;
            objEmp = null;
            try
            {
                Console.WriteLine("emp name: "+objEmp._empName);
                Console.WriteLine("emp id: "+objEmp._empId);
            }
            catch(NullReferenceException objNull)

            {
                Console.WriteLine("Error: "+ objNull);
            }
            catch(Exception objEx)
            {
                Console.WriteLine("Error: "+objEx);
            }
        }
    }
}
