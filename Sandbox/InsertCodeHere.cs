using System;
using System.Collections.Generic;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line


            // Add you test of the Employee class and derived classes here
            List<Employee> Employees  = new List<Employee>();

            Worker worker1 = new Worker("John", 2000, "no Skills :(");
            Worker worker2 = new Worker("John Junior", 200, "no Skills :( either");
            Worker worker3 = new Worker("John Junior the secound", 20, "not even alive yet :O");
            Employees.Add(worker1);
            Employees.Add(worker2);
            Employees.Add(worker3);

        
            Manager manager1 = new Manager("Issa",10000, 2000);
            manager1.NumOfWorkedHours = 181;  
            Manager manager2 = new Manager("Issa Junior",1000, 200);
            manager2.NumOfWorkedHours = 179;
            Employees.Add(manager1);
            Employees.Add(manager2);

            Director director1 = new Director("Zuhair", 1000000,2);
         director1.setNumOfWorkedHours(190);
            Director director2 = new Director("Zuhair Junior", 9999, 999);
           
            Employees.Add(director1);
            Employees.Add(director2);

            foreach (var employer in Employees)
                {
                    Console.WriteLine($"{employer.GetName()} has a salary of {employer.GetSalaryPerMonth()}"); 
            }
            // The LAST line of code should be ABOVE this line
        }
    }
}
