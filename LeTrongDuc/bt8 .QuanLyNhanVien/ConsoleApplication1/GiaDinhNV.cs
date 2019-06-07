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
            get { return MaNV; }
            set { MaNV = value; }
        }
        string _TenNgThan;

        public string TenNgThan
        {
            get { return TenNgThan; }
            set { TenNgThan = value; }
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
    }
}
