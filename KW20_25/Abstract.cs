using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW20_25
{
    internal class Abstract
    {
        static void Main(string[] args)
        {
            Dog2 d2 = new Dog2();
            d2.MakeSound();
            d2.Sleep();
        }
    }


    abstract class Animal2
    {
        public abstract void MakeSound();

        public void Sleep()
        {
            Console.WriteLine("Sleeping");
        }
    }

    class Dog2 : Animal2
    {
        public override void MakeSound()
        {
            Console.WriteLine("Barking");
        }
    }
}
