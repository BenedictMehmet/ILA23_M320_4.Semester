using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW15_25.Aufgaben.Lösung.Rezeptverwaltung
{
    class Program
    {
        static void Main(string[] args)
        {
            ReceipeBook book = new ReceipeBook();
            bool running = true;

            while (running)
            {
                Console.WriteLine("==== Rezeptverwaltung ====");
                Console.WriteLine("1. Neues Rezept hinzufügen");
                Console.WriteLine("2. Alle Rezepte anzeigen");
                Console.WriteLine("3. Beenden");
                Console.Write("Wähle eine Option: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        book.AddRecipe();
                        break;
                    case "2":
                        book.ShowAllRecipes();
                        break;
                    case "3":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Ungültige Eingabe. Bitte wähle 1-3.\n");
                        break;
                }
            }
        }
    }
}
