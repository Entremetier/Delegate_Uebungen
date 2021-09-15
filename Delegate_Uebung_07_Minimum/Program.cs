using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* Übung: Minimum                                                    Lambda-Expressions
 * --------------
 * Erstellen Sie einen Delegatetyp mit dem Namen Minimum, der 2 int-Parameter und einen
 * Rückgabetyp int besitzt. Erstellen Sie mit Hilfe eines Lambda-Ausdrucks eine
 * Delegate-Instanz, die das Minimum von 2 Integer-Werten ermittelt und zurückgibt.
 * Erstellen Sie 2 Varianten für den Lambda-Ausdruck: Eine Variante mit Codeblock und
 * eine 2. Variante ohne Codeblock.
 * 
 * Testen Sie die Delegate-Instanzen mit den Wertepaaren 7 und 21 sowie 38 und -19.
 */

namespace Delegate_Uebung_07_Minimum
{
    delegate int Minimum(int value1, int value2);

    class Program
    {
        static void Main(string[] args)
        {
            //Mit Codeblock
            Minimum minimum1 = (val1, val2) =>
            {
                if (val1 < val2) return val1;
                else return val2;
            };

            Console.WriteLine($"Das minimum von 7 und 21 = {minimum1(7,21)} ");
            Console.WriteLine($"Das minimum von 38 und -19 = {minimum1(38,-19)} ");
            Console.WriteLine();


            //Ohne Codblock
            Func<int, int, int> minimum2 = (val1, val2) => val1 < val2 ? val1 : val2;

            Console.WriteLine($"Das minimum von 7 und 21 = {minimum2(7, 21)} ");
            Console.WriteLine($"Das minimum von 38 und -19 = {minimum2(38, -19)} ");

            Console.ReadKey();
        }
    }
}
