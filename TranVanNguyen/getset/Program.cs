using System;

namespace getset
{
    class Emp
    {


        private string name {get; set;}
        public string age {get; set;}
        public string description {get; set;}

        static void Main(string[] args)
        {
            Emp objEmp = new Emp{
                name = "nguyen",
                age="27",
                description="hahahahahahaha"

        };
            
            Console.WriteLine(objEmp.name+"--"+objEmp.age+"--"+objEmp.description);
        }
    }
}
