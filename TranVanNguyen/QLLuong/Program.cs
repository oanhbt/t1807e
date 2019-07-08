using System;
using System.Collections;
using VNPersonPro;
using FGPersonPro;
namespace QLLuong
{
    public class QuanLyHoaDonDien 
    {
        static void Main(string[] args)
        {
            int luachon;
            ArrayList <VNPerson> vnlist = new ArrayList();
            ArrayList <FGPerson> fglist = new ArrayList();

            Console.WriteLine("Xin chao ban den voi chuong trinh quan ly hoa don tien dien");
            showMenu();
            
            do {
                Console.WriteLine("Lua chon cua ban: ");	
                luachon = Convert.ToInt16(Console.ReadLine());
                while(luachon<0 || luachon>5) {
                    Console.WriteLine("Moi ban chon lai:");
                    luachon = Convert.ToInt16(Console.ReadLine());
                }
                
                switch(luachon) {
                    case 1:	
                            Console.WriteLine("Nhap thong tin khach hang Viet Nam");
                            Console.WriteLine("----------------------------------");
                            VNPerson vn = new VNPerson();
                            vn.id = Convert.ToInt16(Console.ReadLine());
                            vnlist.add(vn);						
                            Console.WriteLine("Khach hang da duoc nhap!");
                            showMenu();
                            break;
                            
                    // case 2:	
                    //         Console.WriteLine("Nhap thong tin khach hang Nuoc Ngoai");
                    //         Console.WriteLine("----------------------------------");
                    //         FGPerson fg = new FGPerson();
                    //         fg.addKh();
                    //         fglist.add(fg);
                    //         Console.WriteLine("Khach hang da duoc nhap!");
                    //         showMenu();
                    //         break;
                            
                    // case 3: //In thong tin kh + so tien phai thanh toan
                    //         if(vnlist.size() == 0) {
                    //             Console.WriteLine("Chua co khach hang Viet Nam trong he thong!");
                    //         }else {
                    //             Console.WriteLine("Thong tin chi tiet khach hang Viet Nam:");
                    //             Console.WriteLine("----------------------------------------");
                    //             foreach(VNPerson vn1 in vnlist) {
                    //                 Console.WriteLine("Thong tin:");
                    //                 vn1.display();
                    //                 Console.WriteLine("So tien phai thanh toan = " + vn1.invoice() + "VND");	
                                    
                    //             }
                    //         }
                            
                    //         if(fglist.size() == 0) {
                    //             Console.WriteLine("Chua co khach hang nuoc ngoai trong he thong!");
                    //         }else {
                    //             Console.WriteLine("Thong tin chi tiet khach hang Nuoc Ngoai:");
                    //             Console.WriteLine("----------------------------------------");
                    //             foreach(FGPerson fg1 in fglist) {
                    //                 Console.WriteLine("Thong tin:");
                    //                 fg1.display();
                    //                 Console.WriteLine("So tien phai thanh toan = " + fg1.invoice() + "VND");	
                    //             }
                    //         }
                                
                    //         showMenu();
                    //         break;
                            
                    // case 4: //thong bao khach hang da thanh toan
                    //         Console.WriteLine("4.Khach hang Viet Nam.");
                    //         Console.WriteLine("----------------------------------------");
                    //         foreach(VNPerson vn1 in vnlist) {
                    //             Console.WriteLine("Khach hang "+vn1.name+" da thanh toan " + vn1.invoice() + "VND");
                    //             vn1.pay(vn1.invoice());
                    //             Console.WriteLine("So tien con lai trong tai khoan = "+vn1.wallet);
                                
                    //         }
                    //         Console.WriteLine("Khach hang Nuoc Ngoai:");
                    //         Console.WriteLine("----------------------------------------");
                    //         foreach(FGPerson fg1 in fglist) {
                    //             Console.WriteLine("Khach hang "+fg1.name+" da thanh toan " + fg1.invoice() + "VND");
                    //             fg1.pay(fg1.invoice());
                    //             Console.WriteLine("So tien con lai trong tai khoan = "+fg1.wallet);
                    //         }
                    //         showMenu();
                    //         break;
                            
                    // case 5:	if(fglist.size() == 0) {
                    //             Console.WriteLine("Chua co khach hang nuoc ngoai trong he thong!");
                    //             showMenu();
                    //             break;
                    //         }else {
                    //             Console.WriteLine("5.Tinh trung binh doanh thu Khach hang nuoc ngoai.");
                    //             int slKhNuocNgoai = fglist.size();
                    //             double tong = 0;
                                
                    //             //tinh tong doanh thu cac kh nuoc ngoai
                    //             foreach(FGPerson fg1 in fglist) {
                    //                 tong = tong + fg1.invoice();
                    //             }
                    //             Console.WriteLine("Trung binh doanh thu cua 1 khach hang nuoc ngoai = "+(tong/slKhNuocNgoai)+" VND");
                    //             showMenu();
                    //             break;
                    //         }
                            
                            
                    // case 0:	
                    //         Console.WriteLine("Ban da thoat khoi chuong trinh!");
                        
                }
            }while(luachon!=0);
            
        }
        //Menu
        public static void showMenu() 
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Menu:");
            Console.WriteLine("1.Nhap thong tin khach hang Viet Nam.");
            Console.WriteLine("2.Nhap thong tin khach hang Nuoc Ngoai.");
            Console.WriteLine("3.In thong tin khach hang.");
            Console.WriteLine("4.Thu tien dien khach hang.");
            Console.WriteLine("5.Tinh trung binh doanh thu Khach hang nuoc ngoai.");
            Console.WriteLine("0.Thoat.");
            Console.WriteLine("----------------------------------");

	    }

    }
}
