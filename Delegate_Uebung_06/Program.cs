using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Übung: StringModifications4                                         Anonyme Methoden
 * ---------------------------
 * Erstellen Sie eine Delagate-Instanz mit einer anonymen Methode, die in einem Text
 * alle Leerzeichen durch Unterstreichungszeichen ersetzt und diesen Text auf der
 * Konsole ausgibt. Erstellen Sie eine weitere Delegate-Instanz mit einer anonymen
 * Methode, die aus einem Text alle Leerzeichen entfernt, diesen Text auf der Konsole
 * ausgibt und die Anzahl der Zeichen im neuen Text zurückgibt.
 * 
 * Verwenden Sie für beide Delegate-Instanzen einen vordefinierten Func- oder Action-
 * Delegate-Typ. Rufen Sie beide Methoden über die jeweilige Delegate-Instanz für einen
 * beliebigen Text auf und geben Sie den Rückgabewert der 2. anonymen Methode aus.
 */

namespace Delegate_Uebung_06
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello =  "Hallo Welt";

            Action<string> replace = delegate (string txt)
            {
                Console.WriteLine(txt.Replace(" ", "_"));
            };

            replace(hello);

            Func<string, int> remove = delegate (string txt)
            {
                string newTxt = txt.Replace(" ", "");
                Console.WriteLine(newTxt);

                return newTxt.Length;
            };

            int x = remove(hello);
            Console.WriteLine(x);


            Console.ReadKey();
        }
    }
}
