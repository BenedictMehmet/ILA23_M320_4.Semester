using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW07_25.Übungen.Lösungen
{
    class ZahlErraten
    {
        static void Main(string[]args)
        {
            string myInput = "";
            int myNumber;
            bool isZahl;
            int score = 0;

            int randomNumber;

            Random r = new Random();

            randomNumber = r.Next(1, 101);

            do
            {
                Console.WriteLine("Geben Sie eine Zahl von 1 -100 ein");
                myInput = Console.ReadLine();
                isZahl = int.TryParse(myInput, out myNumber);

                if(isZahl)
                {
                    if (myNumber > randomNumber)
                    {
                        Console.WriteLine("Gib eine kleinere Zahl ein");
                        score++;
                    }

                    if (myNumber < randomNumber)
                    {
                        Console.WriteLine("Gib eine grössere Zahl ein");
                        score++;
                    }

                    if(myNumber == randomNumber)
                    {
                        Console.WriteLine("Du hast die Zahl korrekt erraten");
                    }

                } else
                {
                    Console.WriteLine("Gib keine Sonderzeichen ein. Nur Zahlen!");
                    score++;
                    Console.WriteLine();
                }

            } while (!isZahl || myNumber != randomNumber);

            Console.WriteLine($"Du hattest {score} Versuch(e).");

        }
    }
}
