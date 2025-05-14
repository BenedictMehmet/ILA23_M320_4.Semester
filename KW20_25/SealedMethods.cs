using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW20_25
{
    internal class SealedMethods
    {
        static void Main(string[]args)
        {
            BaseClass b1 = new BaseClass();
            b1.ShowMessage();

            DerivedClass d1 = new DerivedClass();
            d1.ShowMessage();

        }
    }




    class BaseClass
    {
        public virtual void ShowMessage()
        {
            Console.WriteLine("Message from Baseclass");
        }
    }


    class DerivedClass : BaseClass
    {
        public sealed override void ShowMessage()
        {
            Console.WriteLine("Message from DerivedClass. (Sealed)");
        }
    }


    class DerivedClass2 : DerivedClass
    {

        // Kann nicht überschrieben werden, da versiegelt
        //public override void ShowMessage()
        //{
        //    Console.WriteLine("Message from DerivedClass2");
        //}
    }
}
