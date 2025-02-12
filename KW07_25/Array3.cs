using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW07_25
{
    class Array3
    {
        static void Main(string[] args)
        {
            int[,] nummer = new int[3, 3];

            // [0] [0] [0]
            // [0] [0] [0]
            // [0] [0] [0]

            nummer[0, 1] = 5;

            Console.WriteLine(nummer[0,1]);

            string[,] TicTacToe =

            {
                {"0", "X", "0" },
                {"0", "X", "X" },
                {"X", "0", "0" }

            };

            Console.WriteLine(TicTacToe[2,1]);


            string[,] userIndex =
            {
                { "00", "01", "02"},
                { "10", "11", "12"},
                { "20", "21", "22"}
            };

            

        }
    }
}
