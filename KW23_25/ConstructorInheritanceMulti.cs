using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW23_25
{
    internal class ConstructorInheritanceMulti
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public ConstructorInheritanceMulti()
        {
            Console.WriteLine("ConstructorInheritance wird aufgerufen");
        }

        public ConstructorInheritanceMulti(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {Name} / Age: {Age}");
        }
    }




    internal class Employee1 : ConstructorInheritanceMulti
    {
        public string JobTitle { get; set; }
        public int EmployeeID { get; set; }

        public Employee1(string name, int age, string jobTitle, int employeeID) : base(name, age)
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



    internal class Manager : Employee1
    {
        public int TeamSize { get; set; }

        public Manager(string name, int age, string jobTitle, int employeeID, int teamSize) : base(name, age, jobTitle, employeeID)
        {
            this.TeamSize = teamSize;
        }

        public void DisplayManagerInfo()
        {
            DisplayEmployeeInfo();
            Console.WriteLine($"Teamgrösse: {TeamSize}");
        }
    }
}
