using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThongTinLuong
{
    class LuongNV
    {
        short _MaNV;

        public short MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }
        double _LuongNhVien;

        public double LuongNhVien
        {
            get { return _LuongNhVien; }
            set { _LuongNhVien = value; }
        }

        int _Thang;
        
        public int Thang
        {
            get { return _Thang; }
            set { _Thang = value; }
        }

        public LuongNV(short MaNV, int Thang, double Luong) 
        {
            this._MaNV = MaNV;
            this._Thang = Thang;
            this._LuongNhVien = LuongNhVien;
        }

        public LuongNV()
        {
            
        }
    }
}
