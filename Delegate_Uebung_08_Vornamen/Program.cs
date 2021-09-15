using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Übung: Vornamen                                                   Lambda-Expressions
 * ---------------
 * Erstellen Sie eine Liste mit den Vornamen Vera, Hermann, Elisabeth, Gustav,
 * Angelika, Hans und Eva.
 * 
 * Führen Sie folgende Ermittlungen mit Hilfe von Lambda-Ausdrücken durch und geben Sie
 * die zugehörigen Resultate aus:
 * 
 *    - Ermitteln Sie mit der Find-Methode von List<> das 1. Vorkommen eines Vornamens,
 *      der mit E beginnt.
 *    - Ermitteln Sie mit der Methode FindAll von List<> alle Vornamen, die mehr als
 *      6 Zeichen lang sind und geben Sie diese aus.
 *    - Ermitteln Sie mit der Methode TrueForAll von List<>, ob alle Vornamen mit einem
 *      Großbuchstaben beginnen.
 *    - Geben Sie alle Vornamen mit der ForEach-Methode von List<> großgeschrieben aus.
 * 
 * Zusatzaufgabe:
 *    - Lösen Sie die 2. Aufgabe (Vornamen mit mehr als 6 Zeichen) mit einem einzigen
 *      Statement (Hinweis: Verketten der Methoden FindAll und ForEach).
 */

namespace Delegate_Uebung_08_Vornamen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> vornamen = new List<string>
            {
                "Vera",
                "Hermann",
                "Elisabeth",
                "Gustav",
                "Angelika", 
                "Hans", 
                "Eva"
            };

            Console.WriteLine("Erster Name der mit \"E\" beginnt ist "  + vornamen.Find(name => name.StartsWith("E")));
            Console.WriteLine();


            Console.WriteLine("Alle Vornamen die mehr als 6 Zeichen lang sind 1:");
            List<string> list = vornamen.FindAll(x => x.Length > 6);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("Fangen alle mit einem Großbuchstaben an? " + vornamen.TrueForAll(x => char.IsUpper(x[0])));
            Console.WriteLine();

            Console.WriteLine("Alle Namen mit der foreach-Methode ausgeben:");
            vornamen.ForEach(name => Console.WriteLine(name));
            Console.WriteLine();

            Console.WriteLine("Alle Vornamen die mehr als 6 Zeichen lang sind 2:");
            vornamen.FindAll(x => x.Length > 6).ForEach(x => Console.WriteLine(x));
        }
    }
}
