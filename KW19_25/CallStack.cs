using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW19_25
{
    internal class CallStack
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Applikation startet bevor Try-Block");

            try
            {
                LevelOne();
            } catch (Exception ex)
            {
                Console.WriteLine("Exception caught in Main" + ex.Message);
            }
            Console.WriteLine("Applikation ist am laufen");

            Console.ReadKey();
            
        }


        static void LevelOne()
        {
            LevelTwo();
        }

        static void LevelTwo()
        {
            Console.WriteLine("Level two before throw");
            throw new Exception("Something went wrong");
            Console.WriteLine("Level two after throw");
        }
    }
}
