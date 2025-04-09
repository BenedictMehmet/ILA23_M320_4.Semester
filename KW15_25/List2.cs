using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW15_25
{
    class List2
    {
        static void Main(string[]args)
        {

            List<string> names = new List<string>
            {
                "Deniz",
                "Bob",
                "Hadi"
            };

            names.Add("Peter");

            names.Sort();
           

            foreach(string n in names)
            {
                Console.WriteLine(n);
            }
        }
    }
}
