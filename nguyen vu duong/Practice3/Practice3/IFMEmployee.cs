using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFMEmployee
{
    class IFMEmployee
    {
        private string _empId;

        public string EmpId
        {
            get { return _empId; }
            set { _empId = value; }
        }
        private string _empName;

        public string EmpName
        {
            get { return _empName; }
            set { _empName = value; }
        }
    }
}
