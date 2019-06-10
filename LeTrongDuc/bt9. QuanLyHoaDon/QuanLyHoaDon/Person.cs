using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//* id: mã khách hàng,
//●	name: họ tên
//●	date: ngày ra hoá đơn (ngày, tháng, năm)
//●	type: đối tượng khách hàng (sinh hoạt, kinh doanh, sản xuất)
//●	kw: số lượng điện tiêu thụ
//●	price: đơn giá
//●	quota: định mức tiêu thụ.
//●	phone: phoneNumber
//●	wallet: số tiền trong ví.
namespace QuanLyHoaDon
{
    abstract class Person
    {
        Int32 _id, _date;

        public Int32 Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public Int32 Id
        {
            get { return _id; }
            set { _id = value; }
        }
        string _name, _type, _phone;

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        float _kw, _wallet, _bill;

        public float Bill
        {
            get { return _bill; }
            set { _bill = value; }
        }

        public float Wallet
        {
            get { return _wallet; }
            set { _wallet = value; }
        }

        public float Kw
        {
            get { return _kw; }
            set { _kw = value; }
        }

        public Person()
        { 
        
        }
    }
}
