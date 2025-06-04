using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW23_25
{
    internal class DependencyInjection
    {
        static void Main(string[]args)
        {
            Benachrichtigungsdienst emailDienst = new EMailBenachrichtigungsdienst();
            BenutzerVerwaltung verwaltungEmail = new BenutzerVerwaltung(emailDienst);

        }
    }


    // interface mit Benachritigungsdienst
    // Methode SendeNachricht
    public interface Benachrichtigungsdienst
    {
        void SendeNachricht(string nachricht);
    }

    // Klasse erstellen SMSBenachritigungsdienst und Klasse Benachritigungsdienst übergeben
    public class SMSBenachritigungsdienst : Benachrichtigungsdienst
    {
        public void SendeNachricht(string nachricht)
        {
            Console.WriteLine($"SMS wird gesendet: {nachricht}");
        }
    }

    public class EMailBenachrichtigungsdienst : Benachrichtigungsdienst
    {
        public void SendeNachricht(string nachricht)
        {
            Console.WriteLine($"E-Mail wird gesendet: {nachricht}");
        }
    }



    public class BenutzerVerwaltung
    {
        private Benachrichtigungsdienst _benachrichtigungsDienst;

        public BenutzerVerwaltung(Benachrichtigungsdienst benachrichtigungsDienst)
        {
            this._benachrichtigungsDienst = benachrichtigungsDienst;
        }

        public void RegistriereBenutzer(string name)
        {
            Console.WriteLine($"{name} wurde erfolgreich registriert.");
            _benachrichtigungsDienst.SendeNachricht("Willkommen" + name);
        }
    }





}
