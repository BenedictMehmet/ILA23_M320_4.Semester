using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW15_25
{
    class List
    {
        static void Main(string[]args)
        {
            List<int> numbers = new List<int>();

            numbers.Add(10);
            numbers.Add(5);

            numbers.Sort();

            foreach (int n in numbers)
            {

                Console.WriteLine(n);
            }

            List<string> names = new List<string>();

            names.Add("Hadi");
            names.Add("Deniz");

            Console.WriteLine("Erste Liste");
            foreach(string n in names) {

                Console.WriteLine(n);
            }

            names.Remove("Hadi");

            Console.WriteLine("Zweite Liste");
            foreach (string n in names)
            {

                Console.WriteLine(n);
            }

        }
    }
}
