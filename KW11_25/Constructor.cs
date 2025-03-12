using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW11_25
{
    class Constructor
    {
        // Membervariablen

        public string name;
        public string adresse;
        public string nummer;

        private static int nextID = 0;

        private readonly int id;

            

        public Constructor(string name, string adresse, string nummer)
        {
            this.id = nextID++;
            this.name = name;
            this.adresse = adresse;
            this.nummer = nummer;
        }

        public Constructor (string name, string adresse)
        {
            this.id = nextID++;
            this.name = name;
            this.adresse = adresse;
            this.nummer = "nicht eingegeben";
        }

        public Constructor(string name)
        {
            this.id = nextID++;
            this.name = name;
            this.adresse = "nicht eingegeben";
            this.nummer = "nicht eingegeben";
        }

        public void ZeigePersonen()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Adresse: {adresse}");
            Console.WriteLine($"Nummer: {nummer}");
        }
    }
}
