using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW20_25
{
    internal class In
    {
        static void Main(string[]args)
        {
            int myValue = 10;
           
            PrintValue(in myValue);
        }

        static void PrintValue(in int number)
        {
            
            Console.WriteLine($"Der Wert ist: {number}");

            int doubleValue = number * 2;
            Console.WriteLine($"Doppelwert: {doubleValue}");

        }
    }

}
