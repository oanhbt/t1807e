using System;

namespace overrideGHIDE
{
    class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("Every animal eats sth.");
        }
        protected void DoSth()
        {
            Console.WriteLine("Every animal does sth.");
        }
    }
    class Cat : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Cats loves to eat the Jerry");
        }
        static void Main(string[] args)
        {
            Cat objCat = new Cat();
            objCat.Eat();
            base.Eat();
     
        }
    }
}
