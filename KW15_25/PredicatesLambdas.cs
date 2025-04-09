using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW15_25
{
    class PredicatesLambdas
    {
        static void Main(string[]args)
        {
            List<int> numbers = new List<int>() { 34, 55, 10, 8, 9, 66, 88, 4 };


            Predicate<int> isGreaterThen10  = x => x > 10;

            List<int> higher10 = numbers.FindAll(isGreaterThen10);

            foreach(int n in higher10)
            {
                Console.WriteLine(n);
            }
        }
    }
}
