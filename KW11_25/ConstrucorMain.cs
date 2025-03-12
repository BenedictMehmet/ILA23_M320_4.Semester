using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW11_25
{
    class ConstrucorMain
    {
        static void Main(string[]args)
        {
            // Instanzvariablen
            Constructor person1 = new Constructor("Deniz", "Haldestrass", "000");

            Constructor person2 = new Constructor("Bob", "Inselstrasse");

            person1.ZeigePersonen();

            person2.ZeigePersonen();


        }
    }
}
