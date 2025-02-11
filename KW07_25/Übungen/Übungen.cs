using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW07_25.Übungen
{
    internal class Übungen
    {
        /*
         *  
         *  1.
         *  
            Herausforderung: Raketenlandungssimulation

            In dieser Aufgabe wirst du eine unterhaltsame und interaktive Konsolenanwendung in C# erstellen,
            die eine Raketenlandung simuliert. Hier sind deine Ziele:

            Zeichenketten-Darstellung: Beginne mit einer Zeichenkette (String), die die Rakete darstellt.
            Diese Zeichenkette sollte Zeilenumbrüche und Schrägstriche enthalten, um eine einfache Raketenform zu erzeugen.

            Konsolendarstellung: Dein Ziel ist es, diese Raketen-Zeichenkette in der Konsole darzustellen 
            und es so erscheinen zu lassen, als ob die Rakete Schritt für Schritt nach unten sinkt.

            Konsole leeren: Verwende die Methode `Console.Clear()`, um die Konsole bei jedem Schritt des Abstiegs zu leeren.
            Dadurch wird die Bewegung der Rakete flüssig und kontinuierlich.

            Abstiegsmechanismus: Implementiere einen Mechanismus, der in jeder Iteration eine leere Zeile über der Rakete hinzufügt.
            Dies simuliert den Abstieg der Rakete.

            Abschlussnachricht: Sobald die Rakete gelandet ist,
            soll eine Nachricht angezeigt werden, wie zum Beispiel:
            "Die Rakete ist gelandet. Woohoo! Eine weitere erfolgreiche Landung!"

            Denke daran, dass der wichtigste Teil dieser Herausforderung darin besteht, sicherzustellen,
            dass die Rakete reibungslos absinkt, sodass es wie eine kontrollierte Landung aussieht.
            Möglicherweise musst du mit dem Hinzufügen leerer Zeilen und dem Leeren der Konsole experimentieren,
            um den gewünschten Effekt zu erzielen.

         
         *  2.
         *  
            Schreibe eine Anwendung, in der ich eine Zahl von 1 bis 100 erraten kann.
            Verwende eine `while`-Schleife und eine zufällige Zahl (`Random`).
            Zähle die Versuche.
            Falls ich einen Buchstaben wie "a" eingebe oder "hi" schreibe, 
            soll die Konsole mich warnen!
          

         *  3.
         *  
            Was wird die Konsole ausgeben? Schreibe den Code nicht aus. 
            Überlege dir die Antwort und erkläre sie mir!

               static void Main(string[] args)
               {
                    for(int i = 0; i < 4; i++)
                    {
                        Console.WriteLine(i);
                        if (i == 2)
                        {
                            continue;
                        }
                        Console.WriteLine(i);
                    }
               }

         *  4.
         *  
            Deklariere ein String-Array mit den Wochentagen von Montag bis Sonntag.

         *  5.
         *  
            Erstelle ein einfaches C#-Programm, das ein Integer-Array deklariert,
            es mit Werten initialisiert und mit einer `foreach`-Schleife
            jeden Wert in der Konsole ausgibt.

            Achtung!
            Die Ausgabe jedes Standardwertes sollte in einer neuen Zeile erfolgen:

            1
            2
            3
            4
            5

         */
    }
}
