using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Xây dựng chương trình quản lý danh sách hoá đơn tiền điện của khách hàng.
//1) Khách hàng Việt Nam:
//●	id: mã khách hàng,
//●	name: họ tên
//●	date: ngày ra hoá đơn (ngày, tháng, năm)
//●	type: đối tượng khách hàng (sinh hoạt, kinh doanh, sản xuất)
//●	kw: số lượng điện tiêu thụ
//●	price: đơn giá
//●	quota: định mức tiêu thụ.
//●	phone: phoneNumber
//●	wallet: số tiền trong ví.
//Phương thức: invoice() sử dụng để tính tiền cước điện của KH được tính theo công thức:
//●	Nếu số lượng <= định mức thì thành tiền = số lượng x đơn giá.
//●	Ngược lại, thì thành tiền = đơn giá x định mức + số lượng kw vượt định mức x đơn giá x 1.5
//2) Khách hàng nước ngoài:
//Ngoài các thông tin được quy định ở Khách hàng Việt Nam, còn có các thông tin khác.
//●	nation: quốc tịch.
//●	nationalId: mã đa quốc gia được tham chiếu.
//Phương thức: invoice() được tính theo công thức:
//●	Nếu số lượng <= định mức thì thành tiền = số lượng x đơn giá x 2.5
//●	Ngược lại, thì thành tiền = đơn giá x định mức x 2.5 + số lượng kw vượt định mức x đơn giá x 2,5 x 1.5
//●	
//3) Cả khách hàng Việt Nam và nước ngoài đều phải tuân thủ quy định Electricity của Việt Nam.
//[Bắt buộc]
//●	retrievePhoneNumber(): Trả ra số điện thoại,
//nếu là KH Việt Nam thì sẽ theo format +84[phoneNumber]
//nếu là KH nước ngoài thì sẽ theo format +00[phoneNumber]
//●	pay(): Trả tiền điện.
//Sẽ thực hiện bằng cách trừ số tiền điện vào lượng tiền trong tài khoản của khách.
//Các công việc cần làm:
//1) Xây dựng các Class, Interface với thông tin, chức năng theo yêu cầu.
//2) Nhập khách hàng từ bàn phím.
//●	Nếu bắt đầu bằng việc nhập số 1, thì sẽ yêu cầu nhập thông tin của KH Việt Nam.
//●	Nếu bắt đầu bằng việc nhập số 2, thì sẽ yêu cầu nhập thông tin của KH nước ngoài.
//●	Nếu bắt đầu bằng việc nhập số 0, thì sẽ kết thúc bước nhập và chuyển sang công việc 3.
//3) Sau khi nhập xong thì thông báo lại cho người dùng đã nhập xong.
//4) In thông tin chi tiết Khách hàng và thông tin hoá đơn tiền điện.
//5) Gọi điện và thu 1 loạt tiền điện của Khách hàng
//6) Thống kê: Tính trung bình doanh thu từ Khách hàng nước ngoài sau bước 5.

//Gọi ý: Tạo abstract class Person, class VNPerson và FGPerson kế thừa từ Person, Interface IElectricity gồm 2 method: invoice và pay (đầu vào là giá trị invoice).

namespace QuanLyHoaDon
{
    class Program
    {
        List<VietNamCus> VNCuArr = new List<VietNamCus>();
        List<ForeignCus> FGCuArr = new List<ForeignCus>();
        QtyPrice qtyprice = new QtyPrice();

        static void Main(string[] args)
        { 
            Program pro = new Program();
            bool flag = true;
            int choice = 0;
            while (flag) 
            {
                Console.WriteLine("--------Menu-------");
                Console.WriteLine("1.Nhap thong tin KH");
                Console.WriteLine("2.Hien thi thong tin KH va Hoa Don");
                Console.WriteLine("3.Nhan tin thu tien");
                Console.WriteLine("4.Thong ke doanh thu tu KH");
                Console.WriteLine("5.Thoat");
                Console.WriteLine("Moi nhap lua chon");
                choice = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("--------Menu-------");
                switch (choice) 
                {
                    case 1:
                        pro.InsertData();
                        break;
                    case 2:
                        pro.Show();
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        flag = false;
                        Console.WriteLine("Bye..");
                        break;
                    default:
                        Console.WriteLine("Bye..");
                        break;
                }
            }
        }

        public void InsertData()
        {
            int choice = 0;
            bool flag = true;
            int count = 1;
            while (flag)
            {
                Console.WriteLine("--------Case 1-------");
                Console.WriteLine("1.Nhap thong tin KH Viet Nam");
                Console.WriteLine("2.Nhap thong tin KH Nuoc Ngoai");
                Console.WriteLine("3.Ket thuc");
                choice = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("--------Case 1-------");
                switch (choice)
                {
                    case 1:
                        VietNamCus VNcu = new VietNamCus();
                        VNcu.Id = count;
                        VNcu.Name = "Duc" + count;
                        VNcu.Phone = "035235480" + count;
                        VNcu.Wallet = 100000;
                        VNcu.Type = "VN";
                        VNcu.Kw = count * 10;
                        VNcu.Date = 05022019;
                        VNcu.Bill = String.Format("{0:#.##} ", VNcu.invoice());
                        VNCuArr.Add(VNcu);
                        break;
                    case 2:
                        ForeignCus FGcu = new ForeignCus();
                        FGcu.Id = count;
                        FGcu.Name = "My" + count;
                        FGcu.Phone = "333333333" + count;
                        FGcu.Wallet = 100000;
                        FGcu.Type = "FG";
                        FGcu.Kw = count * 10;
                        FGcu.Date = 05022019;
                        FGCuArr.Add(FGcu);
                        break;
                    case 3:
                        flag = false;
                        Console.WriteLine("Bye");
                        break;
                    default:
                        Console.WriteLine("Bye..");
                        break;
                }
                count++;
            }
        }
        public void Show()
        { 
            foreach(VietNamCus VNcu in VNCuArr)
            {
                Console.WriteLine("Id\tName\tPhoneNumber\tWallet\tType\tTieuthu\tNgay\tThanhtoan");
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t", 
                        VNcu.Id,
                        VNcu.Name,
                        VNcu.Phone,
                        VNcu.Wallet,
                        VNcu.Type,
                        VNcu.Kw,
                        VNcu.Date,
                        VNcu.Bill
                    );
            }
            Console.ReadLine();
        }
    }
}

