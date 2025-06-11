using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW24_25
{
    internal class DependencyInjection
    {
        static void Main(string[]args)
        {
            Hammer h1 = new Hammer();
            Sagen s1 = new Sagen();

            Bauen b1 = new Bauen(h1, s1);
            b1.HausBauen();
        }
    }




    public class Hammer
    {
        public void Use()
        {
            Console.WriteLine("Nägel einschlagen");
        }
    }


    public class Sagen
    {
        public void Use()
        {
            Console.WriteLine("Holz sägen");
        }
    }



    public class Bauen
    {
        private Hammer _hammer;
        private Sagen _sagen;


        public Bauen(Hammer hammer, Sagen sagen)
        {
            this._hammer = hammer;
            this._sagen = sagen;
        }


        public void HausBauen()
        {
            _hammer.Use();
            _sagen.Use();
            Console.WriteLine("Haus gebaut");
        }
    }
}
