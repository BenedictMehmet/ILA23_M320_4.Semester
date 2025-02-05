using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW06_25
{
    internal class RückblickReadLine1
    {

        static void Main(string[] args) {

            string myString;

            int zahl1 = 0;

            string zahl2 = "5.5";

            Console.WriteLine("Gib etwas ein, damit das in myString gespeichert wird.");

            myString = Console.ReadLine();

            Console.WriteLine("Das hast du geschrieben: " + myString);


            Console.WriteLine();

            Console.WriteLine("Gib eine Zahl ein");

            zahl1 = int.Parse(Console.ReadLine());
            
            zahl1 = Convert.ToInt32(Console.ReadLine());


            int zahl3 = int.Parse(zahl2);
            Console.WriteLine(zahl3);


        }
    }
}
