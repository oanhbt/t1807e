using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThongTinNhanVien
{
    class NhanVien
    {
        short _MaNV;

        public Int16 MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }
        string _TenNV;

        public string TenNV
        {
            get { return _TenNV; }
            set { _TenNV = value; }
        }

        public NhanVien(short MaNV, string TenNV)
        {
            // TODO: Complete member initialization
            this._MaNV = MaNV;
            this._TenNV = TenNV;
        }
    }
}
