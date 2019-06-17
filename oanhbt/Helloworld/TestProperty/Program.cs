using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProperty
{
    class Program
    {
        private string _empName;

        public string EmpName
        {
            get { return _empName; }
            set { _empName = value; }
        }


        /*static void Main(string[] args)
        {
            Program p = new Program();
            p.EmpName = "Oanh";
            Console.WriteLine(p.EmpName);
        }*/
    }
}
