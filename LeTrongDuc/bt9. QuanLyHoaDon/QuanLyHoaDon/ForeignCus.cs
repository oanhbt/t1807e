using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHoaDon
{
    class ForeignCus : Person, IElectricity
    {
        Int32 _nationId;

        public Int32 NationId
        {
            get { return _nationId; }
            set { _nationId = value; }
        }
        string _nation;

        public string Nation
        {
            get { return _nation; }
            set { _nation = value; }
        }

        public ForeignCus()
        {

        }

        public float invoice()
        {
            float _paid = 0;
            ForeignCus FgCu = new ForeignCus();
            QtyPrice Price = new QtyPrice();
            if (FgCu.Kw <= Price.Quota)
            {
                _paid = (float) (FgCu.Kw * 2.5 * Price.Price);
            }
            else
            {
                _paid = (float)((FgCu.Kw - Price.Quota) * 2.5 * 1.5 * Price.Price + Price.Quota * 2.5 * 1.5 * Price.Price);
            }
            return _paid;
        }
        string IElectricity.retrievePhoneNumber()
        {
            string rePhoneNum;
            ForeignCus FgCus = new ForeignCus();
            rePhoneNum = +84 + FgCus.Phone;
            return rePhoneNum;
        }

        string IElectricity.pay()
        {
            return "hello";
        }
    }
}
