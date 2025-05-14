using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW20_25
{
    internal class Interface
    {
       static void Main(string[]args)
        {
            Rabbit r = new Rabbit();
            r.Flee();


        }
    }


    // Beute = Prey
    interface Prey
    {
        // Fliehen = Flee
        void Flee();
    }

    // Raubtier
    interface Predator
    {   
        // Jadg
        void Hunt();
    }

    class Rabbit : Prey
    {
        public void Flee()
        {
            Console.WriteLine("Rabbit runs away");
        }
    }

    class Bird : Predator
    {
        public void Hunt()
        {
            Console.WriteLine("Bird is searching for Food");
        }
    }


    class Fish : Prey, Predator
    {
        public void Flee()
        {
            Console.WriteLine("Fish runs away");
        }

        public void Hunt()
        {
            Console.WriteLine("Fish is searching for Food");
        }
    }


}
