using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester
{
    internal class RückblickReadLine2
    {
        static void Main(string[] args)
        {

            // Diese Methode ist sehr speziell und kann nur
            // angewedent werden, wenn int, string und bool vorhanden sind.

            string myString;
            int zahl;
            bool istZahl;

            do
            {
                Console.WriteLine("Gib mir eine Zahl ein:");
                myString = Console.ReadLine();

                istZahl = int.TryParse(myString, out zahl);

                if (istZahl)
                {
                    Console.WriteLine("Korrekt, du hast eine Zahl eingegeben");
                } else
                {
                    Console.WriteLine("Fehler, du solltest eine gültige Zahl eingeben");
                }

            } while (!istZahl);

            Console.WriteLine("Das Programm wird beendet. Du hast die Zahl eingegeben" + zahl);

            Console.ReadKey();
        }
    }
}
