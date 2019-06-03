using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Students;
namespace Examintion
{
    class ScoreReport
    {
        private string subject = "c-sharp";
        private int mark = 40;
        static void Main(string[] args)
        {
            Students.StudentDetail s = new Students.StudentDetail();
            ScoreReport c = new ScoreReport();
            Console.WriteLine("student subject: " + c.subject);
            Console.WriteLine("student mark: " + c.mark);
            Console.ReadLine();
        }
    }
}
