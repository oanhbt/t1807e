using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    class Program : SinhVien
    {
        
        static int SoSV = Convert.ToInt16(Console.ReadLine());
        SinhVien[] MangSV = new SinhVien[SoSV];
        static void Main(string[] args)
        {
            Program pro = new Program();
            pro.Input();
            Console.WriteLine();
            pro.Display();
            Console.WriteLine();
            pro.TimKiem(1999);

        }

        public void Input()
        {
            Console.WriteLine("Nhap thong tin sinh vien");
            for (int i = 0; i < MangSV.Length; i++) 
            {
                SinhVien sv = new SinhVien();
                //Console.WriteLine("Nhap ten");
                //sv.Ten = Convert.ToString(Console.ReadLine());
                sv.Ten = "Duc" + i;
                //Console.WriteLine("Nhap dia chi");
                //sv.Diachi = Convert.ToString(Console.ReadLine());
                sv.Diachi = "HaNoi" + i;
                //Console.WriteLine("Nhap tuoi");
                //sv.Tuoi = Convert.ToInt32(Console.ReadLine());
                sv.Tuoi = 24 + i;
                //Console.WriteLine("Nhap nam sinh");
                //sv.Namsinh = Convert.ToInt32(Console.ReadLine());
                sv.Namsinh = 1995 + i;
                //Console.WriteLine("Nhap gioi tinh");
                //sv.Gioitinh = Convert.ToString(Console.ReadLine());
                sv.Gioitinh = "nam";
                //Console.WriteLine("Nhap so dien thoai");
                //sv.Sodienthoai = Convert.ToString(Console.ReadLine());
                sv.Sodienthoai = "035235480" + i;
                MangSV[i] = sv;
            }
        }

        public void Display()
        {
            Console.WriteLine("thong tin sinh vien");
            Console.WriteLine();
            for (int i = 0; i < MangSV.Length; i++)
            {
                SinhVien sv = MangSV[i];
                Console.WriteLine("Ten\tDiaChi\tTuoi\tNamSinh\t\tGioiTinh\tSoDienThoai");
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t\t{4}\t\t{5}", 
                    sv.Ten, sv.Diachi, sv.Tuoi, sv.Namsinh, sv.Gioitinh, sv.Sodienthoai);
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public void TimKiem(Int32 namsinh)
        {
            Console.WriteLine("thong tin sinh vien");
            Console.WriteLine();
            foreach (SinhVien sv in MangSV)
            {
                if(sv.Namsinh <= namsinh)
                {
                    Console.WriteLine("Ten\tDiaChi\tTuoi\tNamSinh\t\tGioiTinh\tSoDienThoai");
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t\t{4}\t\t{5}", 
                    sv.Ten, sv.Diachi, sv.Tuoi, sv.Namsinh, sv.Gioitinh, sv.Sodienthoai);
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }

        public void TimKiem(string gioitinh, Int32 tuoi)
        {
            foreach (SinhVien sv in MangSV)
            {

            }
        }
    }

    class SinhVien
    {
        string _ten, _diachi, _gioitinh, _sodienthoai;

        public string Sodienthoai
        {
            get { return _sodienthoai; }
            set { _sodienthoai = value; }
        }

        public string Gioitinh
        {
            get { return _gioitinh; }
            set { _gioitinh = value; }
        }

        public string Diachi
        {
            get { return _diachi; }
            set { _diachi = value; }
        }

        public string Ten
        {
            get { return _ten; }
            set { _ten = value; }
        }
        Int32 _tuoi;

        public Int32 Tuoi
        {
            get { return _tuoi; }
            set { _tuoi = value; }
        }
        int _namsinh;

        public int Namsinh
        {
            get { return _namsinh; }
            set { _namsinh = value; }
        }

        public SinhVien()
        { 
        
        }

        public SinhVien(string _ten, int _tuoi, Int32 _namsinh)
        {
            this._ten = _ten;
            this._tuoi = _tuoi;
            this._namsinh = _namsinh;
        }

        public SinhVien(string _ten, int _tuoi, Int32 _namsinh, string _gioitinh)
        {
            this._ten = _ten;
            this._tuoi = _tuoi;
            this._namsinh = _namsinh;
            this._gioitinh = _gioitinh;
        }

        //public string setTen(string ten) 
        //{
        //    this._ten = ten;
        //    return _ten;
        //}

        //public string setDiaChi(string diachi)
        //{
        //    this._diachi = diachi ;
        //    return diachi;
        //}

        //public string setGioiTinh(string gioitinh)
        //{
        //    this._gioitinh = gioitinh;
        //    return gioitinh;
        //}

        //public string setSoDienThoai(string sodienthoai)
        //{
        //    this._sodienthoai = sodienthoai;
        //    return sodienthoai;
        //}

        //public int setTuoi(int tuoi) 
        //{
        //    this._tuoi = tuoi;
        //    return tuoi;
        //}

        //public DateTime setNamSinh(DateTime namsinh) 
        //{
        //    this._namsinh = namsinh;
        //    return namsinh;
        //}

    }
    
    

}
