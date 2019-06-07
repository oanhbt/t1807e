using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHoaDon
{
    class QtyPrice
    {
        Int32 _quota;

        public Int32 Quota
        {
            get { return _quota; }
            set { _quota = value; }
        }
        float _price;

        public float Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public QtyPrice() 
        {

        }
    }
}
