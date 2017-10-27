using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Manager :Employee
    {
        public int MonthlyBonus { get; set; }
       public int NumOfWorkedHours { get; set; }
        public Manager(string name, int salaryPerMonth, int monthlyBonus) : base(name, salaryPerMonth)
        {
            MonthlyBonus = monthlyBonus;
            NumOfWorkedHours = 0;
        }

        public void setNumOfWorkedHours(int hours)
        {
           NumOfWorkedHours = hours;
        }

        public override int GetSalaryPerMonth()
        {
            if (NumOfWorkedHours > 180)
            {
                return SalaryPerMonth + MonthlyBonus;
            }
            else
            {
                return SalaryPerMonth;
            }
          

        }
    }
}
