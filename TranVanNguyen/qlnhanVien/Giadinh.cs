using System;

namespace ThongTinGiaDinh 
{
    class GiaDinh
    {
         string _maNv{get; set;}
         string _tenNguoiThan{get; set;}
         string _qh{get; set;}
         string _namsinh{get; set;}
        
        public GiaDinh(string ma, string ten, string qh, string namsinh)
        {
            this._maNv = ma;
            this._tenNguoiThan = ten;
            this._qh = qh;
            this._namsinh = namsinh;
        }

    }
}