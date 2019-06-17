using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHoaDon
{
    interface IElectricity
    {
         float invoice();
         string pay();
         string retrievePhoneNumber();
    }
}
