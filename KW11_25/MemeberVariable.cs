using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW11_25
{
    class MemeberVariable
    {
        static void Main(string[]args)
        {
            memberVariable m1 = new memberVariable();

            m1.setName("Deniz");

            Console.WriteLine(m1.getName());




            memberVariable m2 = new memberVariable();

            
        }
    }


    class memberVariable
    {
       

        public string adresse { get; }



        private string name;

        public void setName(string n)
        {
            name = n;
        }

        public string getName()
        {
            return name;
        }
    }


}
