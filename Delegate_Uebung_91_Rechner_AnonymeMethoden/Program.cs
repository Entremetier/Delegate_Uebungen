using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Uebung_91_Rechner_AnonymeMethoden
{
    delegate double MyDelegate(double value1, double value2);

    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate myDelegate = null;

            do
            {
                Console.Write("Ersten Wert eingeben: ");
                Double.TryParse(Console.ReadLine(), out double value1);

                Console.Write("Zweiten Wert eingeben: ");
                Double.TryParse(Console.ReadLine(), out double value2);

                Console.Write("Addieren (A), Subtrahieren (S), Multiplizieren (M), Dividieren (D): ");
                string action = Console.ReadLine();

                if (action.ToUpper() == "A") myDelegate = delegate (double val1, double val2) { return val1 + val2; };
                else if (action.ToUpper() == "S") myDelegate = delegate (double val1, double val2) { return val1 - val2; };
                else if (action.ToUpper() == "M") myDelegate = delegate (double val1, double val2) { return val1 * val2; };
                else if (action.ToUpper() == "D") myDelegate = delegate (double val1, double val2) { return val1 / val2; };
                else Console.WriteLine("Bitte einen gültigen Wert eingeben");

                double result = myDelegate(value1, value2);
                Console.WriteLine("------------------------------------------------------------------");

                Console.WriteLine("Ergebnis: " + result);

                Console.WriteLine("Zum beenden F12 drücken.");

            } while (Console.ReadKey(true).Key != ConsoleKey.F12);
        }
    }
}
