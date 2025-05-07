using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW19_25
{
    internal class ToString1
    {
        public string Name { get; set; }

        public int Age { get; set; }

       
        public ToString1(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public void GibInfo()
        {
            Console.WriteLine($"Name: {Name}, Alter: {Age}");
        }

        public override string ToString()
        {
            return $"Name:  {Name}, Alter: {Age}";
        }
    }
}
