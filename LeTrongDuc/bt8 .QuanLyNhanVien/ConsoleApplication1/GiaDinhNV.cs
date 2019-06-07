using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ThongTinGiaDinh
{
    class GiaDinhNV 
    {
        short _MaNV;

        public short MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }
        string _TenNgThan;

        public string TenNgThan
        {
            get { return _TenNgThan; }
            set { _TenNgThan = value; }
        }
        string _QuHe;

        public string QuHe
        {
            get { return _QuHe; }
            set { _QuHe = value; }
        }
        short _NamSinh;

        public short NamSinh
        {
            get { return _NamSinh; }
            set { _NamSinh = value; }
        }

        public GiaDinhNV()
        {

        }

        public GiaDinhNV(short MaNV, string TenNgThan, string QuHe, short NamSinh)
        {
            // TODO: Complete member initialization
            this._MaNV = MaNV;
            this._TenNgThan = TenNgThan;
            this._QuHe = QuHe;
            this._NamSinh = NamSinh;
        }
    }
}
