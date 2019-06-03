using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams4
{
    class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("every animal eats something.");

        }
        protected void DoSomething()
        {
            Console.WriteLine("every enimal dose something.");
        }
    }

    class Program : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("cat love to eat the mouse.");
        }
        static void Main(string[] args)
        {

        }
    }
}
