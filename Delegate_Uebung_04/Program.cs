using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Übung: StringModifications3                                            Func & Action
 * ---------------------------
 * Schreiben Sie eine Methode ReplaceSpaces(), die in einem Text alle Leerzeichen durch
 * Unterstreichungszeichen ersetzt und eine Methode PrintOhneSpaces(), die einen Text
 * ausgibt, bei dem alle Leerzeichen entfernt wurden. Erstellen Sie für beide Methoden
 * Delegates mit Hilfe der vordefinierten Func- und Action-Delegate-Typen.Rufen Sie
 * beide Methoden über den jeweiligen Delegate für den Text "Das ist ein Test." auf
 * und geben Sie die Resultate aus.
 */

namespace Delegate_Uebung_04
{
    class Program
    {
        static void PrintOhneSpaces(string txt) => Console.WriteLine(txt.Replace(" ", ""));
        static string ReplaceSpaces(string txt) => txt.Replace(' ', '_');

        static void Main(string[] args)
        {
            string txt = "Hallo Welt, heute ist ein schöner Tag.";

            Func<string, string> func = ReplaceSpaces;
            string x = func(txt);
            Console.WriteLine(x);

            Action<string> action = PrintOhneSpaces;
            action(txt);



            Console.ReadKey();
        }
    }
}
