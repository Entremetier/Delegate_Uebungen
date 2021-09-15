using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Übung:
// Schreiben Sie eine Methode ReplaceSpaces(), die in einem Text alle Leerzeichen
// durch Minuszeichen ersetzt und eine Methode RemoveSpaces(), die alle Leerzeichen
// aus einem Text entfernt. Deklarieren Sie einen Delegate StrModification, über den
// Sie beide Methoden aufrufen können. Rufen Sie beide Methoden über den Delegate
// für den Text "Das ist ein Test." auf und geben Sie die Resultate aus.

namespace Delegate_Uebung_01
{
    delegate string StrModification(string txt);
    class Program
    {
        static string UseStringDelegate(StrModification stringDelegate, string txt)
        {
            //Die als Delegate übergebene Methode ausführen.
            return stringDelegate(txt);
        }

        static string ReplaceSpaces(string txt) => txt.Replace(" ", "-");
        static string RemoveSpaces(string txt) => txt.Replace(" ", "");

        static void Main(string[] args)
        {
            //Übung 1 Delegates
            //----------------------------------------------

            string text = "Das ist ein Test.";

            //Den delegate instanzieren und die Methode zuweisen
            StrModification strModification = RemoveSpaces;

            //Dem Delegaten den string übergeben und ausgeben
            Console.WriteLine(strModification(text));

            //Dem Delegaten eine neue Methode zuweisen (darum keine Klammern hinter dem Methodennamen)
            strModification = ReplaceSpaces;

            //Ausführen des Delegaten mit anderer Methode
            string result = strModification(text);
            Console.WriteLine(result);

            //Die Methode (UseStringDelegate) aufrufen und die Methode die als Delegate ausgeführt werden soll,
            //den string übergeben wird.
            Console.WriteLine(UseStringDelegate(RemoveSpaces, text));

            Console.ReadKey();
        }
    }
}
