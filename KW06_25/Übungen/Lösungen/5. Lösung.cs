using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW06_25.Übungen.Lösungen
{
    internal class _5
    {
        static void Main(string[] args)
        {
            int alter;
            bool istGueltigeZahl = false;

            // Schleife läuft, bis eine gültige Zahl im korrekten Bereich eingegeben wird
            do
            {
                Console.WriteLine("Bitte gib dein Alter ein (zwischen 0 und 120):");

                string eingabe = Console.ReadLine();

                // Versuche die Eingabe in eine Zahl umzuwandeln
                istGueltigeZahl = int.TryParse(eingabe, out alter);

                if (istGueltigeZahl)
                {
                    if (alter >= 0 && alter <= 120)
                    {
                        Console.WriteLine("Danke! Dein Alter wurde erfolgreich akzeptiert.");
                        break;  // Die Schleife beenden
                    }
                    else
                    {
                        Console.WriteLine("Fehler: Das Alter muss zwischen 0 und 120 liegen.");
                        istGueltigeZahl = false;  // Damit die Schleife weiterläuft
                    }
                }
                else
                {
                    Console.WriteLine("Fehler: Bitte gib eine gültige Zahl ein.");
                }

            } while (!istGueltigeZahl);

            Console.WriteLine("Programm beendet.");
            Console.ReadKey();
        }
    }
}
