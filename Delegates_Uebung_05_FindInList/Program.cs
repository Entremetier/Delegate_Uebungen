using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Übung: FindInList                                                          Predicate
 * -----------------
 * Erstellen Sie eine Liste und weisen Sie der Liste 10 zufällige Ganzzahlwerte im
 * Bereich von 1 bis 100 zu.
 * 
 * Schreiben Sie eine Methode Groesser50() die überprüft, ob ein int-Wert größer als 50
 * ist oder nicht, und die das Resultat der Überprüfung zurückgibt.
 * Schreiben Sie weiters die Methode Kleiner20() die überprüft, ob ein int-Wert kleiner
 * als 20 ist oder nicht, und die ebenfalls das Resultat der Überprüfung zurückgibt.
 * 
 * Führen Sie mit der Liste und den entsprechenden Find- und Remove-Methoden der Liste
 * folgende Aktionen durch und geben Sie das jeweilige Resultat aus:
 * 
 *    - Suchen Sie die erste Zahl in der Liste, die größer als 50 ist.
 *    - Suchen Sie die letzte Zahl in der Liste, die größer als 50 ist.
 *    - Suchen Sie den Index der ersten Zahl, die kleiner als 20 ist.
 *    - Suchen Sie den Index der letzten Zahl, die kleiner als 20 ist.
 *    - Entfernen Sie alle Zahlen in der Liste, die größer als 50 sind.
 *    - Entfernen Sie alle Zahlen in der Liste, die kleiner als 20 sind.
 */

namespace Delegates_Uebung_05_FindInList
{
    class Program
    {
        static void ListeAusgeben(List<int> liste)
        {
            for (int i = 0; i < liste.Count; i++) Console.WriteLine(i + ": " + liste[i]);
        }

        static bool GroesserFuenfzig(int value) => value > 50;

        static bool KleinerZwanzig(int value) => value < 20;

        static void Main(string[] args)
        {
            Random r = new Random();

            List<int> liste = new List<int>();

            //Liste mit Zufallszahlen befüllen
            for (int i = 0; i <= 10; i++) liste.Add(r.Next(1, 101));

            ListeAusgeben(liste);
            Console.WriteLine();


            Console.WriteLine("Erster Wert der größer als 50 ist: " + liste.Find(GroesserFuenfzig));
            Console.WriteLine();

            Console.WriteLine("Letzter Wert der größer als 50 ist: " + liste.FindLast(GroesserFuenfzig));
            Console.WriteLine();

            Console.WriteLine("Index des ersten Wertes der kleiner als 20 ist: " + liste.FindIndex(KleinerZwanzig));
            Console.WriteLine();

            Console.WriteLine("Index des letzten Wertes der kleiner als 20 ist: " + liste.FindLastIndex(KleinerZwanzig));
            Console.WriteLine();


            liste.RemoveAll(GroesserFuenfzig);
            Console.WriteLine("Liste ohne Werte die größer als 50 sind");
            ListeAusgeben(liste);
            Console.WriteLine();


            liste.RemoveAll(KleinerZwanzig);
            Console.WriteLine("Liste ohne Werte die kleiner als 20 sind");
            ListeAusgeben(liste);
            Console.WriteLine();



            //Liste mit Lambda durchgehen
            //----------------------------------------------------------

            //int y = liste.Find(x => x > 50);
            //Console.WriteLine("Erster Wert der größer als 50 ist: " + y);
            //Console.WriteLine();

            //y = liste.FindLast(x => x > 50);
            //Console.WriteLine("Letzter Wert der größer als 50 ist: " + y);
            //Console.WriteLine();

            //y = liste.FindIndex(x => x < 20);
            //Console.WriteLine("Index des ersten Wertes der kleiner als 20 ist: " + y);
            //Console.WriteLine();

            //y = liste.FindLastIndex(x => x < 20);
            //Console.WriteLine("Index des letzten Wertes der kleiner als 20 ist: " + y);
            //Console.WriteLine();

            //liste.RemoveAll(x => x > 50);
            //Console.WriteLine("Liste ohne Werte die größer als 50 sind");
            //ListeAusgeben(liste);
            //Console.WriteLine();

            //liste.RemoveAll(x => x < 20);
            //Console.WriteLine("Liste ohne Werte die kleiner als 20 sind");
            //ListeAusgeben(liste);
            //Console.WriteLine();
        }
    }
}
