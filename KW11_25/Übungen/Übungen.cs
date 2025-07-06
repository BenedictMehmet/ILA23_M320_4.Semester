using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW11_25.Übungen
{
    class Übungen
    {
        /*
         *  1. Erkläre mir den Unterschied zwischen Properties und Member
         *     Variable in einem Text. Erstelle eine MainKlasse und eine
         *     andere Klasse und zeige mir ein Beispiel!
         * 
         *   2. Erstelle ein Programm in C#, das eine Klasse Auto definiert. Diese Klasse soll die wichtigsten Eigenschaften eines Autos abbilden und bestimmte Bedingungen für das Baujahr überprüfen. Danach soll das Programm ein oder mehrere Auto-Objekte erstellen und deren Informationen auf der Konsole ausgeben.
​
​
Erstelle eine Klasse Auto mit folgenden Eigenschaften (Properties):
Marke (z. B. "BMW", "Audi")
Modell (z. B. "A4", "3er")
Baujahr
Das Baujahr muss zwischen 1990 und 2025 liegen.
Falls ein ungültiges Baujahr übergeben wird, soll automatisch der Standardwert 2020 verwendet werden.
Konstruiere einen passenden Konstruktor, der alle drei Eigenschaften (Marke, Modell, Baujahr) übernimmt.
Erstelle eine Methode AutoInfos(), welche die Fahrzeugdaten mit Console.WriteLine() in folgendem Format ausgibt:
Marke: Audi / Modell: A3 / Baujahr: 2020
Erstelle in der Main()-Methode mindestens zwei Auto-Objekte mit verschiedenen Werten.
Eines davon soll ein ungültiges Baujahr enthalten (z. B. 1950), um zu testen, ob der Standardwert 2020 korrekt gesetzt wird.
Gib die Informationen beider Autos mithilfe der Methode AutoInfos() auf der Konsole aus.
         * 
         * 
         * 
         *   3. Erstelle eine Klasse Bankkonto, die folgende Eigenschaften enthält:

                Kontoinhaber (Nur lesen, kann nicht nachträglich geändert werden)
                Kontostand (Kann nur innerhalb der Klasse geändert werden)
                Einzahlen() und Abheben() Methoden, um Geld auf das Konto zu setzen oder zu entnehmen.
                Abheben sollte nur gehen, wenn auch genug Geld im Konto vorhanden ist!
         * 
         * 
         * 
         *   4. Erstelle eine Klasse Temperatur, die folgende Eigenschaften enthält:

                Grad (Speichert den Temperaturwert in Celsius)
                Einheit (Automatische Erkennung: "Kalt", "Warm" oder "Heiss")
                Methode InFahrenheit(), die den Wert von Celsius in Fahrenheit umrechnet.

                Die Property Grad speichert die Temperatur in Celsius.
                Die Property Einheit wird automatisch gesetzt:
                <= 10°C → "Kalt"
                > 10°C und < 25°C → "Warm"
                >= 25°C → "Heiss"
                Die Methode InFahrenheit() berechnet Fahrenheit = (Celsius * 1.8) + 32.
         */
    }
}
