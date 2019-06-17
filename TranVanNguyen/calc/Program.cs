using System;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,m, chon;
            Console.WriteLine("Nhap so thu nhat: ");
            n = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("Nhap so thu hai: ");
            m = Convert.ToUInt16(Console.ReadLine());


            do
            {
                menu();
                Console.WriteLine("Chon: ");
                chon = Convert.ToUInt16(Console.ReadLine());
                while(chon <0 || chon > 4)
                {
                    Console.WriteLine("Chon lai: ");
                    chon = Convert.ToUInt16(Console.ReadLine());
                }
                switch (chon)
                {
                    case 1:
                        Console.WriteLine("KQ phep cong: {0} ", n+m);
                        
                        break;
                    case 2:
                        Console.WriteLine("KQ phep tru: {0} ", n-m);
                        
                        break;
                    case 3:
                        if (m == 0)
                        {
                            Console.WriteLine("Error");
                        }else
                        {
                            Console.WriteLine("KQ phep chia: {0} ", n/m);
                        }
                        
                        break;
                    case 4:
                        Console.WriteLine("KQ phep nhan: {0} ", n*m);
                        
                        break;

                }
            }while(chon >0 && chon < 5);




        
        }
        static void menu(){
            Console.WriteLine("------------------------------");
            Console.WriteLine("1.Cong");
            Console.WriteLine("2.Tru");
            Console.WriteLine("3.Chia");
            Console.WriteLine("4.Nhan");
            Console.WriteLine("-------------------------------");
        }
    }
}
