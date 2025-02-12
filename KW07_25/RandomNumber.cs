using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW07_25
{
    class RandomNumber
    {
        static void Main(string[] args)
        {

            bool isNumber;
            int number;
            int count = 0;

            Random random = new Random();
            int ZufallsZahl = random.Next(1, 11);

            do
            {

                Console.WriteLine("Gib eine Zahl von 1-10 ein:");
                string myString = Console.ReadLine();
                isNumber = int.TryParse(myString, out number);

                if (!isNumber || number < 1 || number > 10)

                {
                    Console.WriteLine("Ungültige Eingabe. Bitte gib eine Zahl zwischen" +
                        "1 und 10 ein:");
                    count++;
                    continue;
                }

                if (number == ZufallsZahl)
                {
                    Console.WriteLine("Du hast die Zahl erraten");
                }
                else
                {
                    Console.WriteLine("Du hast die Zahl falsch erraten");
                    count++;
                }


            } while (number != ZufallsZahl);

            count++;
            Console.WriteLine($"Du hattest {count} Versuch(e).");


        }
    }
}
