using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW19_25
{
    internal class ToString1Main
    {
        static void Main(string[]args)
        {
            ToString1 Person1 = new ToString1("Max", 10);
            Person1.GibInfo();

            Console.WriteLine(Person1);
        }
    }
}
