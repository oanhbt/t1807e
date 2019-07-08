using System;

namespace ThongTinNhanVien
{
    class Emp{
        string _name {get; set;}
        string _id{get; set;}
        public Emp()
        {   
        }
        public Emp(string name, string id)
        {
            this._name = name;
            this._id = id;
        }
    }
}