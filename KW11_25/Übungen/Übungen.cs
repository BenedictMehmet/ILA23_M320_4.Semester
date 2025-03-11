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
         *   2. Erstelle eine Klasse Auto, die folgende Eigenschaften (Properties) hat:

                Marke (z. B. "BMW", "Audi")
                Modell (z. B. "A4", "3er")
                Baujahr (Muss zwischen 1990 und 2025 liegen, sonst Standardwert 2000)
                In Main() soll ein Auto-Objekt erstellt werden, und die Werte sollen mit Console.WriteLine() ausgegeben werden.
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
         * 
    }
}
