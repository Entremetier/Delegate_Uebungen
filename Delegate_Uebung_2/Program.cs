using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Übung: StringModifications2                                                 Delegate
 * ---------------------------
 * Ändern Sie die Übung Delegates_Uebung_StringModifications derart, dass die Methoden
 * ReplaceSpaces(), RemoveSpaces() und StringMod() keine statischen Methoden, sondern
 * Instanzmethoden der Klasse StringOperations sind. Deklarieren Sie auch den Delegate
 * StrModification in der Klasse StringOperations (und nicht direkt im Namespace).
 * Führen Sie dieselben Tests wie in der Übung Delegates_Uebung_StringModifications
 * durch.
 * 
 * Hinweis: Ein Delegate-Typ, der in einer Klasse definiert ist, wird über den
 * Klassennamen angesprochen.
 */

namespace Delegate_Uebung_02
{
    public class StringMod
    {
        public delegate string StrModification(string txt);
        internal string UseStringDelegate(StrModification stringDelegate, string txt)
        {
            //Die als Delegate übergebene Methode ausführen.
            return stringDelegate(txt);
        }

        public string ReplaceSpaces(string txt) => txt.Replace(" ", "-");
        public string RemoveSpaces(string txt) => txt.Replace(" ", "");
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Übung 2 Delegates
            //----------------------------------------------

            string text = "Das ist ein Test.";

            StringMod stringMod = new StringMod();

            StringMod.StrModification strModification = stringMod.RemoveSpaces;

            Console.WriteLine(strModification(text));

            strModification = stringMod.ReplaceSpaces;

            string result = strModification(text);
            Console.WriteLine(result);

            Console.WriteLine(stringMod.UseStringDelegate(stringMod.RemoveSpaces, text));

            Console.ReadKey();
        }
    }
}
