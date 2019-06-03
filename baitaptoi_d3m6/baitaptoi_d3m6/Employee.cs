using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitaptoi_d3m6
{
    class Employee
    {
        private string manv;
        private string tennv;
        private List<EmployeeSalary> listSalary;
        private List<Nguoithan_nv> listNguoithan;

        public string Manv { get => manv; set => manv = value; }
        public string Tennv { get => tennv; set => tennv = value; }
        internal List<EmployeeSalary> ListSalary { get => listSalary; set => listSalary = value; }
        internal List<Nguoithan_nv> ListNguoithan { get => listNguoithan; set => listNguoithan = value; }
    }
}
