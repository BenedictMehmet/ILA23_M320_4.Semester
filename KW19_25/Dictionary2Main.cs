using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW19_25
{
    internal class Dictionary2Main
    {
        static void Main(string[]args)
        {
            Dictionary<int, Dictionary2> Mitarbeiter = new Dictionary<int, Dictionary2>();

            Mitarbeiter.Add(1, new Dictionary2("Deniz", 23, 10000));
            Mitarbeiter.Add(2, new Dictionary2("Box", 30, 5000));
            Mitarbeiter.Add(3, new Dictionary2("Max", 28, 4000));


            foreach (KeyValuePair<int, Dictionary2> m in Mitarbeiter)
            {
                Console.WriteLine($"ID:  {m.Key}, Name: {m.Value.Name}, Alter: {m.Value.Age}");
            }
        }
    }
}
