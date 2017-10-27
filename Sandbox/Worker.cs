using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Worker:Employee
    {
        private string Skill { get; }
    

        public Worker(string name, int salary, string skill):base(name,salary)
        {
            Skill = skill;
            Name = name;
            SalaryPerMonth = salary;

        }

        
    }
}
