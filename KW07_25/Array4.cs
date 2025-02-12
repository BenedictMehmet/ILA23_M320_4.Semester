using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW07_25
{
    class Array4
    {
        public string Name;
        public string Nummer;

        public void KundenInformationen()
        {
            Array4[] Kunden = new Array4[]
                {
            new Array4 { Name = "Deniz", Nummer = "068767" },
            new Array4 { Name = "Peter", Nummer = "867766" }
                };

            foreach(Array4 kunde in Kunden)
            {
                Console.WriteLine($"Name: {kunde.Name}, Nummer: {kunde.Nummer}");
            }


            
        
        }



    }
}
