using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW20_25
{
    internal class Override
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.MakeSound();

            Cat c = new Cat();
            c.MakeSound();

            Animal a = new Animal();
            a.MakeSound();
        }

    }

     class Animal
        {
        // Zum Überschreiben zuerst virtual in der Methode!
        public virtual void MakeSound()
        {
            Console.WriteLine("Animals makes Sond");
        }
        }
        
        
        // Zum Überschreiben mit override
        class Dog : Animal
        {
        public override void MakeSound()
        {
            Console.WriteLine("Dog is barking...");
        }

        }


    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat is miauing...");
        }
    }




    
}
