using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW07_25
{
    class FürÜbung1
    {
        static void Main(string[] args)
        {
           
            for (int i = 0; i <= 10; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine(i);
                
            }

            for (int i = 10; i >= 0; i--)
            {
                Thread.Sleep(500);
                Console.WriteLine("\t" +i);
            }


            
        }
    }
}
