using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams5
{
    interface IAnimal
    {
        void Habitat();
    }
    //abstract class Animal
    //{
    //    public void Eat()
    //    {
    //        Console.WriteLine("Every animal eats food in order to suvive.");
    //    }
    //    public abstract void AnimalSound();
    //}
    class Program : IAnimal//Animal
    {
        public void Habitat()
        {
            Console.WriteLine("can be housed with human begins");
        }
        //public override void AnimalSound()
        //{
        //    Console.WriteLine(" Lion roars");
        //}
        static void Main(string[] args)
        {
            Program p = new Program();
            //p.AnimalSound();
            //p.Eat();
            Console.WriteLine(p.GetType().Name);
            p.Habitat();
            Console.ReadLine();
        }
    }
}
