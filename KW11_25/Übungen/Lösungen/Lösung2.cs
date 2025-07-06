using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW11_25.Übungen.Lösungen
{
    internal class Lösung2
    {
        static void Main(string[]args)
        {
            Auto auto1 = new Auto("Audi", "A3", 1950);
            Auto auto2 = new Auto("BMW", "X3", 2010);

            auto1.AutoInfos();
            auto2.AutoInfos();
        }
    }


    class Auto
    {
        public string Marke { get; set; }
        public string Modell { get; set; }
        private int _baujahr;

        public int Baujahr
        {
            get { return _baujahr; }
            set
            {
                if (value >= 1990 && value <= 2025)
                {
                    _baujahr = value;
                }
                else
                {
                    _baujahr = 2020;
                }
            }
        }

        public Auto(string marke, string modell, int baujahr)
        {
            this.Marke = marke;
            this.Modell = modell;
            this.Baujahr = baujahr;
        }

        public void AutoInfos()
        {
            Console.WriteLine($"Marke: {Marke} / Modell: {Modell} / Baujahr: {Baujahr}");
        }
    }
}
