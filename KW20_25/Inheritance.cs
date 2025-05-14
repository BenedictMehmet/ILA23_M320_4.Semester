using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW20_25
{
    internal class Inheritance
    {
        static void Main(string[]args)
        {
            Dog1 d1 = new Dog1();
            d1.Bark();
            d1.Eat();


        }
    }


    class Animal1
    {
        public void Eat()
        {
            Console.WriteLine("Eating");
        }
    }


    class Dog1 : Animal1
    {
        public void Bark()
        {
            Console.WriteLine("Barking");
        }
    }

    class Cat1 : Animal1
    {
        public void Miau()
        {
            Console.WriteLine("Miauing");
        }
    }
}
