using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitaptoi_d3m6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listEmployee = new List<Employee>();
            int i = 0;
            while (true)
            {
                Console.WriteLine("Nhap thong tin nhan vien thu " + i++ + ":");

                Employee empl = new Employee();

                Console.Write("Nhap ma nhan vien: ");
                empl.Manv = Convert.ToString(Console.ReadLine());
                Console.Write("Nhap ten nhan vien: ");
                empl.Manv = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Nhap so luong tung thang cua nhan vien: ");
                int sothang = 1;
                List<EmployeeSalary> listSalary = new List<EmployeeSalary>();
                while(sothang <= 12)
                {
                    EmployeeSalary empSalary = new EmployeeSalary();
                    empSalary.Month = sothang;
                    Console.Write("Luong thang " + sothang + ": ");
                    empSalary.Salary = Convert.ToDouble(Console.ReadLine());
                    listSalary.Add(empSalary);
                    sothang++;
                }
                empl.ListSalary = listSalary;

                Console.WriteLine("Nhap so nguoi than cua nhan vien");
                List<Nguoithan_nv> Listngthannv = new List<Nguoithan_nv>();
                int songthan = 0;
                int snt = 1;
                songthan = Convert.ToInt32(Console.ReadLine());
                while(snt <= songthan){
                    Nguoithan_nv ngthannv = new Nguoithan_nv();
                    Console.WriteLine("Nhap ngu than thu " + snt + " cua nhan vien: ");

                    Console.Write("Nhap ten nguoi than: ");
                    ngthannv.Tenngthan = Convert.ToString(Console.ReadLine());
                    Console.Write("Nhap nam sinh: ");
                    ngthannv.Namsinh = Convert.ToString(Console.ReadLine());
                    Console.Write("Moi quan he: ");
                    ngthannv.Quanhe = Convert.ToString(Console.ReadLine());

                    Listngthannv.Add(ngthannv);
                    snt++;
                }

                empl.ListNguoithan = Listngthannv;

                listEmployee.Add(empl);

                Console.WriteLine("Ban co muon nhap them nhan vien ko ?Y/N: ");
                string sn = Convert.ToString(Console.ReadLine());
                if(sn.Equals("y") || sn.Equals("Y"))
                {
                    break;
                }
            }

            //cap nhan luong
            Console.Write("Nhap ma nhan vien can cap nhat thang luong: ");
            string manv = Convert.ToString(Console.ReadLine());
            Boolean xntimNV = false;
            for(int stt = 0; stt < listEmployee.Count; stt++)
            {
                if (listEmployee[stt].Manv.Equals(manv))
                {
                    Console.WriteLine("Nhap lai so luong thang 5: ");
                    listEmployee[stt].ListSalary[4].Salary = Convert.ToDouble(Console.ReadLine());
                    xntimNV = true;break;
                }
            }

            if(xntimNV == false)
            {
                Console.WriteLine("Ko tim thay nhan vien");
            }

            Console.WriteLine("Thong tin nhan vien");
            foreach(Employee val in listEmployee)
            {
                Console.Write("Ten ma nhan vien: " + val.Manv);
                Console.Write("Ten nhan vien: " + val.Tennv);
                Console.Write("Luong thang 5 cua nhan vien: " + val.ListSalary[4].Salary);
                Console.WriteLine("Danh sach va thong tin gia dinh cua nhan vien:");
                foreach(Nguoithan_nv val_ngthan in val.ListNguoithan)
                {
                    Console.WriteLine("ten: " + val_ngthan.Tenngthan);
                    Console.WriteLine("quan he: " + val_ngthan.Quanhe);
                    Console.WriteLine("nam sinh: " + val_ngthan.Namsinh);
                    Console.WriteLine("-------");
                }
                Console.WriteLine("------------------------------");
            }
            Console.ReadKey();
        }
    }
}
