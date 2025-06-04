using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW23_25
{
    internal class ConstructorInheritance
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public ConstructorInheritance()
        {
            Console.WriteLine("ConstructorInheritance wird aufgerufen");
        }

        public ConstructorInheritance(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {Name} / Alter: {Age}");
        }

    }


    internal class Employee : ConstructorInheritance
    {
        public string JobTitle { get; set; }
        public int EmployeeID { get; set; }

        public Employee(string name, int age, string jobTitle, int employeeID) : base(name, age)
        {
            this.JobTitle = jobTitle;
            this.EmployeeID = employeeID;
        }

        public void DisplayEmployeeInfo()
        {
            DisplayPersonInfo();
            Console.WriteLine($"Jobtitel: {JobTitle} / EmployeeID: {EmployeeID}");
        }

    }
}
