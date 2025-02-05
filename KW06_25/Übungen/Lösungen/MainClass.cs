using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW06_25.Übungen.Lösungen
{
    internal class MainClass
    {
        static void Main(string[] args)
        {
            _1 nachricht = new _1();
            nachricht.ZeigeNachricht();  // Methode aufrufen



            _2 zahlen = new _2();
            zahlen.ZeigeZahlen();  // Methode aufrufen
            Console.ReadKey();



            _3 rechner = new _3();
            rechner.Addiere(10, 15);  // Methode aufrufen mit zwei Zahlen



            _4 begruessung = new _4();

            Console.WriteLine("Gib deinen Namen ein:");
            string name = Console.ReadLine();

            begruessung.Begruesse(name);  // Methode aufrufen mit dem Namen









            _6 rechner1 = new _6();

            // Benutzer auffordern, eine Temperatur einzugeben
            Console.WriteLine("Gib eine Temperatur in Grad Celsius ein:");
            string eingabe = Console.ReadLine();

            // Versuche, die Eingabe in eine Zahl umzuwandeln
            if (double.TryParse(eingabe, out double celsius))
            {
                // Die Methode aufrufen und das Ergebnis speichern
                double fahrenheit = rechner1.CelsiusInFahrenheit(celsius);

                // Ergebnis ausgeben
                Console.WriteLine("Die Temperatur in Fahrenheit beträgt: " + fahrenheit);
            }
            else
            {
                Console.WriteLine("Fehler: Bitte gib eine gültige Zahl ein.");
            }


            Console.ReadKey();

        }
    }
}
