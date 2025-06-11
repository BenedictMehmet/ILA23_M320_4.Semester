using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW24_25
{
    internal class Polymorphism
    {
        static void Main(string[]args)
        {
            ZahlungsAbwicklung kreditkarte = new Kreditkartenabwicklung();

            Zahlungsdienst z1 = new Zahlungsdienst(kreditkarte);

            z1.ZahlefürBestellung(100);
        }
    }


    public interface ZahlungsAbwicklung
    {
        void ZahleBetrag(decimal betrag);
    }


    public class Kreditkartenabwicklung : ZahlungsAbwicklung
    {
        public void ZahleBetrag(decimal betrag)
        {
            Console.WriteLine($"Kreditkartenzahlung {betrag} wird verarbeitet");
        }
    }


    public class PayPalAbwicklung : ZahlungsAbwicklung
    {
        public void ZahleBetrag(decimal betrag)
        {
            Console.WriteLine($"Paypalabwicklung {betrag} wird verarbeitet");
        }
    }

    public class Zahlungsdienst
    {
        private ZahlungsAbwicklung _zahlungsabwicklung;

        public Zahlungsdienst(ZahlungsAbwicklung zahlungsAbwicklung)
        {
            this._zahlungsabwicklung = zahlungsAbwicklung;
        }


        public void ZahlefürBestellung(decimal betrag)
        {
            _zahlungsabwicklung.ZahleBetrag(betrag);
        }
    }
}
