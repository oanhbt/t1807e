using System;

namespace ThongTinLuong
{
    class luong{
         string _maNv{get; set;}
         string _luong{get; set;}
         int _thang{get; set;}
        
        public luong(string ma, string luong, int thang)
        {
            this._maNv = ma;
            this._luong = luong;
            this._thang = thang;
        }
    }
}