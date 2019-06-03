using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpSalary
{
    class EmpSalary
    {
        private string _empId;

        public string EmpId
        {
            get { return _empId; }
            set { _empId = value; }
        }
        private float _salary;

        public float Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        private int _salaryMonth;

        public int SalaryMonth
        {
            get { return _salaryMonth; }
            set { _salaryMonth = value; }
        }

    }
}