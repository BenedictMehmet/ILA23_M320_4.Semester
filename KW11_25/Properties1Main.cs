using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW11_25
{
    class Properties1Main
    {
        static void Main(string[]args)
        {
            Properties1 p1 = new Properties1();

            p1.ChangeSpeed(500);

            p1.Drive();


            p1.Speed = 300;

            p1.Drive();
        }

        
    }
}
