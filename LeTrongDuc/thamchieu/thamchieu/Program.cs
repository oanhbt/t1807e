using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ref va out 
namespace program
{
    //class RefParameters
    //{
    //    static void Main(string[] args)
    //    {
    //        int numOne = 10;
    //        int numTwo = 20;
    //        Console.WriteLine("{0},{1}",numOne,numTwo);
    //        Calculate(ref numOne, ref numTwo);
    //        Console.WriteLine("{0},{1}",numOne,numTwo);
    //        Console.ReadLine();
    //    }
    //    static void Calculate(ref int numValOne, ref int numValTwo)
    //    {
    //        numValOne = numValOne * 5;
    //        numValTwo = numValTwo / 5;
    //    }
    //    //this đại diện cho object đang gọi đến hàm sử dụng
    //    //hàm hủy được gọi khi bộ lọc rác hoạt động
    //      //KẾ THỪA, NẠP CHỒNG, ĐA HÌNH
    //}



    class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("eat smt");
        }
        protected void DoSomething()
        {
            Console.WriteLine("do smt");
        }
    }

    class Cat : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Cat love dog");
        }
        static void Main() 
        {
            Cat objCat = new Cat();
            objCat.Eat();
            objCat.DoSomething();
            Console.ReadLine();
        }
    }
}
