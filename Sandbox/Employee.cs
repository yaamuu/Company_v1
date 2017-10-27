using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Employee
    {
        public String Name;
        public int SalaryPerMonth;

        public Employee(String name, int salaryPerMonth)
        {
            this.Name = name;
            this.SalaryPerMonth = salaryPerMonth;
        }

        public String GetName()
        {
            return Name;
        }

        public virtual int GetSalaryPerMonth()
        {
            return SalaryPerMonth;
        }
    }
}
