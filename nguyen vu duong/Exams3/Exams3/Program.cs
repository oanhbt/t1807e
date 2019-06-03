using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams3
{
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("every animal eats something.");
        }
    }
    class Mammal : Animal
    {
        public void Feature()
        {
            Console.WriteLine("mammal give birth to young ones.");
        }
    }


    class Program : Mammal
    {
        public void Noise()
        {
            Console.WriteLine("Dog Barks.");
        }
        static void Main(string[] args)
        {
            Program objDog = new Program();
            objDog.Eat();
            objDog.Feature();
            objDog.Noise();
            Console.ReadLine();
        }
    }
}
