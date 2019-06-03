using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpFamily
{
    class EmpFamily
    {
        private string _empId;

        public string EmpId
        {
            get { return _empId; }
            set { _empId = value; }
        }
        private string _nameFamily;

        public string NameFamily
        {
            get { return _nameFamily; }
            set { _nameFamily = value; }
        }
        private string _empRelationship;

        public string EmpRelationship
        {
            get { return _empRelationship; }
            set { _empRelationship = value; }
        }
        private int _birthday;

        public int Birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }
    }
}
