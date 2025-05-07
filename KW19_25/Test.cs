using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW19_25
{
    internal class Test
    {
        static void Main(string[]args)
        {
            int result;

            Console.WriteLine("Gib eine Zahl ein");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = 2;

            result = num2 / num1;

            Console.WriteLine(result);
        }
    }
}
