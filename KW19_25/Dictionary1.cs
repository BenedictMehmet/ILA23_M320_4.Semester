using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW19_25
{
    internal class Dictionary1
    {
        static void Main(string[]args)
        {
            Dictionary<int, string> Mitarbeiter = new Dictionary<int, string>();

            Mitarbeiter.Add(1, "Deniz");
            Mitarbeiter.Add(2, "Bob");
            Mitarbeiter.Add(3, "Max");

            string name = Mitarbeiter[2];
            Console.WriteLine(name);

            Mitarbeiter[3] = "Tello";

            string name1 = Mitarbeiter[3];
            Console.WriteLine(name1);

            Mitarbeiter.Remove(2);

            //foreach(KeyValuePair<int, string> m in Mitarbeiter)
            //{
            //    Console.WriteLine($"ID:  {m.Key}, Name: { m.Value}");
            //}



            int counter = 1;

            while (Mitarbeiter.ContainsKey(counter))
            {
                counter++;
            }
            Mitarbeiter.Add(counter, "Peter");


            foreach (KeyValuePair<int, string> m in Mitarbeiter)
            {
                Console.WriteLine($"ID:  {m.Key}, Name: {m.Value}");
            }



        }
    }
}
