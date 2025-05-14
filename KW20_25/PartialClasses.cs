using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW20_25
{
    internal class PartialClasses
    {
        static void Main(string[]args)
        {
            Person p1 = new Person();
            p1.Name = "Deniz";
            p1.Age = 35;
            p1.JobTitle = "Informatiker";
            p1.Salary = 5000;

            Console.WriteLine($"Name {p1.Name}, {p1.Age}, {p1.JobTitle}, {p1.Salary}");

            //p1.AssignedJob(p1.jobTitle)

        }

    }


    partial class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        partial void OnJobAssigned();
    }

    partial class Person
    {
        public string JobTitle { get; set; }
        public int Salary { get; set; }
    }

    partial class Person
    {
        public void AssignedJob(string jobTitle)
        {
            this.JobTitle = jobTitle;
            OnJobAssigned();
        }
    }


}
