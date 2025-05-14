using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW20_25
{
    internal class Ref
    {
        static void Main(string[]args)
        {
            int myNumber = 10;
            ModifyValue(myNumber);

            ModifyValue(30);

            Console.WriteLine();

            int myNumber1 = 5; // Ursprüglicher Wert
            ModifyValue1(ref myNumber1); // Wert aus der Methode
            Console.WriteLine(myNumber1);



        }

        static void ModifyValue(int number)
        {
            number += 10;
            Console.WriteLine(number);
        }

        static void ModifyValue1(ref int number)
        {
            number = 10;
            number += 10;
        }
    }
}
