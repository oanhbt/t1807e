using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHoaDon
{
    class VietNamCus : Person, IElectricity
    {
        public VietNamCus()
        {

        } 

        public float invoice()
        {
            float _paid = 0;
            VietNamCus VNCu = new VietNamCus();
            QtyPrice Price = new QtyPrice();
            if (VNCu.Kw <= Price.Quota)
            {
                _paid = (float)(VNCu.Kw * Price.Price);
            }
            else
            {
                _paid = (float)((VNCu.Kw - Price.Quota) * 1.5 * Price.Price + Price.Quota * Price.Price);
            }
            return _paid;
        }

        string IElectricity.retrievePhoneNumber()
        { 
            string rePhoneNum;
            VietNamCus VNCus = new VietNamCus();
            rePhoneNum = +84 + VNCus.Phone;
            return rePhoneNum;
        }

        string IElectricity.pay() 
        {
            return "hello";
        }
    }
}
