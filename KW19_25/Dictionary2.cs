using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW19_25
{
    internal class Dictionary2
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int Salary { get; set; }

        public Dictionary2(string name, int age, int salary)
        {
            this.Name = name;
            this.Age = age;
            this.Salary = salary;
        }
    }
}
