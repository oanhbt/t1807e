using System;
using ThongTinNhanVien;
using ThongTinLuong;
using ThongTinGiaDinh;

namespace qlnhanVien
{
    class Program
    {   
        
        
        public static void menu()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("1. Nhap thong tin nhan vien.");
            Console.WriteLine("2. Nhap luong thang 5.");
            Console.WriteLine("3. Them thong tin thanh vien gia dinh.");
            Console.WriteLine("4. Hien thi toan bo thong tin nhan vien.");
            Console.WriteLine("0. Thoat.");
            Console.WriteLine("----------------------------");
        }
        static void Main(string[] args)
        {
            Emp[] listEmp = new Emp[2];
            luong[] listLuong = new luong[12];
            GiaDinh[] listGiadinh= new GiaDinh[100];
            int luachon;
            do
            {
                menu();
                Console.WriteLine("Lua chon: ");
                luachon = Convert.ToInt16(Console.ReadLine());
                while(luachon <= 0 || luachon > 4)
                {
                    Console.WriteLine("Lua chon lai: ");
                    luachon = Convert.ToInt16(Console.ReadLine());
                }

                switch(luachon)
                {
                    case 1:
                            Console.WriteLine("Nhap ten nv: ");
                            string name = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("Nhap ma nv: ");
                            string ma = Convert.ToString(Console.ReadLine());
                            Emp objEmp = new Emp(name, ma);
                            Console.WriteLine(objEmp._id);
                            for (int i = 0; i < 2; i++)
                            {
                                if(listEmp[i] != null)
                                {
                                    listEmp[i] = objEmp;
                                }
                            }
                            
                            break;
                    case 2:
                            for (int i = 0; i < 2; i++)
                            {
                                Console.WriteLine("Nhap luong hang thang cho nv {0}: ", i+1);
                                string id = listEmp[i]._id;
                                for (int j = 0; j < 12; j++)
                                {
                                    Console.WriteLine("Nhap luong thang {0}: ", i+1);
                                    Console.WriteLine("Nhap luong: ");
                                    string luong = Convert.ToString(Console.ReadLine());
                                    luong objLuong = new luong(id, luong, i+1);
                                    listLuong[i] = objLuong;

                                }
                            }
                            break;
                    case 3:
                            for (int i = 0; i < 2; i++)
                            {
                                Console.WriteLine("Nhap danh sach nguoi than nv {0}: ", i+1);
                                string id = listEmp[i]._id;
                                Console.WriteLine("Nhap so nguoi than: ");
                                int n = Convert.ToInt16(Console.ReadLine());

                                for (int j = 0; j < n; j++)
                                {
                                    Console.WriteLine("Nhap ten nguoi than {0}: ", j+1);
                                    string name = Convert.ToString(Console.ReadLine());
                                    Console.WriteLine("Nhap quan he vs nv: ");
                                    string qh = Convert.ToString(Console.ReadLine());
                                    GiaDinh objGiaDinh = new GiaDinh(id, name, qh);
                                    for (int k = 0; k < 100; k++)
                                    {
                                        if (listGiadinh[k] != null )
                                        {
                                            listGiadinh[i] = objGiaDinh;
                                        }
                                    }

                                }
                            }

                            break;
                    case 4:
                            for (int i = 0; i < 2; i++)
                            {
                                
                            }
                            break;
                    
                }

            }while(luachon > 0 && luachon < 5);
        }
    }
}
