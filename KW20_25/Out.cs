using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW20_25
{
    internal class Out
    {
        static void Main(string[]args)
        {
            int myValue;
            GetValues(out myValue);
            Console.WriteLine(myValue);

            Console.WriteLine();

            // out kann überschrieben werden
            myValue = 100;
            Console.WriteLine(myValue);

            Console.WriteLine();

            int resultSum, resultDiff;
            Calculate(10, 5, out resultSum, out resultDiff);
            Console.WriteLine($"Sum:{resultSum} / Diff: {resultDiff}");
            
        }


        // Result muss einer Variable zugeordnet werden. Einen Wert bekommen!
        static void GetValues(out int result)
        {
          
           result = 42;
        }

        static void Calculate(int a, int b, out int sum, out int difference)
        {
            sum = a + b;
            difference = a - b;
        }
    }
}
