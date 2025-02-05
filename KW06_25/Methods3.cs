using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW06_25
{
    internal class Methods3
    {
        public void Ausgangsregel()
        {
            Console.WriteLine("Gib ein, wie alt du bist");
            int alter = Convert.ToInt32(Console.ReadLine());

            if (alter < 15)
            {

                Console.WriteLine("Du bist noch zu jung, um raus zu gehen");
            }
            else
            {
                Console.WriteLine("Du darfst raus gehen");
            }
        }
    }
}
