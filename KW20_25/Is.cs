using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW20_25
{
    internal class Is
    {
        class Animal { }

        class Dog : Animal { }

        class Cat : Animal { }

        static void Main(string[]args)
        {
            Animal a = new Dog();

            if (a is Dog)
            {
                Console.WriteLine("Das Objekt ist ein Hund");

            } else if (a is Cat)
            {
                Console.WriteLine("Das Objekt ist eine Katze");
            }
            else
            {
                Console.WriteLine("Das Objekt ist ein anderes Tier");
            }


        }
    }
}
