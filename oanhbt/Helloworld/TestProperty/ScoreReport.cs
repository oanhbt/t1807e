using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Students ;

namespace Examination
{
    class ScoreReport
    {
        private string subject = "C-Sharp";
        private int mark = 80;

        static void Main(string[] args)
        {
            StudentDetail s = new StudentDetail();
            ScoreReport c = new ScoreReport();
            Console.WriteLine("Student subject: " + c.subject);
            Console.WriteLine("Student mark: " + c.mark);
        }
    }
}
