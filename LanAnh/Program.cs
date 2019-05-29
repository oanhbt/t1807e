using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài1
{
    class Program
    {
        static void Main(string[] args) {

        
            int a, b;
                
            Console.WriteLine(" Nhap gia tri a");
            a = int.Parse( Console.ReadLine());
            Console.WriteLine(" Nhap gia tri b");
            b = int.Parse(Console.ReadLine());

            int Cong = a + b;
            int Tru = a - b;
            int Nhan = a * b;
            int Chia = a / b;
            Console.Write(" 1: tong 2 so\n");
            Console.Write(" 2: Hieu 2 so\n");
            Console.Write(" 3: tich 2 so\n");
            Console.Write(" 4: thuong 2 so\n");
            int lua_chon = Convert.ToInt32(Console.ReadLine());

            switch(lua_chon)
            {
                case 1:
                    Console.WriteLine(" Tong 2 so la" +Cong);,
                    break;
                case 2:
                    Console.WriteLine(" Hieu 2 so la" +Tru);
                    break;
                case 3:
                    Console.WriteLine(" Tich 2 so la" +Nhan);
                    break;
                case 4:
                    Console.WriteLine(" Thuong 2 so la" +Chia);
                    break;
                default:
                    Console.WriteLine(" moi bn nhap lai");
                    break;


            }

            Console.ReadLine();

            
            





        }
    }
}

    
