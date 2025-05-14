using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW20_25
{
    class Person1
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person1(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }




    sealed class Sealed2 : Person1
    {
        public string JobTitel { get; set; }
        public int EmployeID { get; set; }

        public Sealed2(string name, int age, string jobTitle, int employeID) : base(name, age)
        {
            this.JobTitel = jobTitle;
            this.EmployeID = employeID;
        }
    }

    // Ist nicht möglich, da die Klasse versiegelt ist.
    //class Manager : Sealed2
    //{

    //}

}
