using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW15_25
{
    class List3Main
    {
        static void Main(string[]args)
        {
            List<List3> products = new List<List3>
            {
                new List3 {Name = "Apfel", Price = 5},
                new List3 {Name = "Zitrone", Price = 4},
                new List3 {Name = "Schokolade", Price = 2},
                new List3 {Name = "Pfirsich", Price = 1}
            };

            products.Add(new List3 { Name = "Laptop", Price = 300 });

            products.Sort();
            foreach (List3 p in products)
            {
                Console.WriteLine($"Produktname: {p.Name} / Preis: {p.Price}");
            }
        }

        
    }
}
