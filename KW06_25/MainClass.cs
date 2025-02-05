using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW06_25
{
    internal class MainClass
    {
        static void Main(string[] args)
        {
            Methods1 methods1 = new Methods1();

            methods1.ZeigeNachricht();



            Methods2 methods2 = new Methods2();
            methods2.Addieren();


            Methods3 methods3 = new Methods3();
            methods3.Ausgangsregel();


            MethodsParameter1 parameters1 = new MethodsParameter1();


            
           

            int ergebnis = parameters1.Addiere(10, 40);
            int ergebnis2 = parameters1.Addiere(50, 100);
            Console.WriteLine(ergebnis);
            Console.WriteLine(ergebnis2);




            MethodsParameter2 parameters2 = new MethodsParameter2();
            Console.WriteLine("Gib deinen Namen ein:");
            string name = Console.ReadLine();

            parameters2.Begrüssung(name);



            MethodReturn1 methodReturn1 = new MethodReturn1();

            int ergebnis3 = methodReturn1.Multiplizieren(4, 100);
            Console.WriteLine(ergebnis3);



            MethodReturn2 methodReturn2 = new MethodReturn2();

            Console.WriteLine("Gib eine Zahl ein");
            int zahl = int.Parse(Console.ReadLine());
            
            bool a = methodReturn2.istGerade(zahl);

            if (a)
            {
                Console.WriteLine("Die Zahl ist gerade");
            } else
            {
                Console.WriteLine("Die Zahl ist ungerade");
            }
       

        }

    }
}
