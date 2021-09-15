using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Uebung_90_Rechner_Delegate
{

    public class Calculate
    {
        public double Add(double value1, double value2) => value1 + value2;
        public double Subtract(double value1, double value2) => value1 - value2;
        public double Divide(double value1, double value2) => value1 / value2;
        public double Multiply(double value1, double value2) => value1 *value2;

        public delegate double MyDelegate(double value1, double value2);
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculate calculate = new Calculate();
            Calculate.MyDelegate myDelegate = null;

            do
            {
                Console.Write("Ersten Wert eingeben: ");
                Double.TryParse(Console.ReadLine(), out double value1);

                Console.Write("Zweiten Wert eingeben: ");
                Double.TryParse(Console.ReadLine(), out double value2);

                Console.Write("Addieren (A), Subtrahieren (S), Multiplizieren (M), Dividieren (D): ");
                string action = Console.ReadLine();

                if (action.ToUpper() == "A") myDelegate = calculate.Add;
                else if (action.ToUpper() == "S") myDelegate = calculate.Subtract;
                else if (action.ToUpper() == "M") myDelegate = calculate.Multiply;
                else if (action.ToUpper() == "D") myDelegate = calculate.Divide;
                else Console.WriteLine("Bitte einen gültigen Wert eingeben");

                double result = myDelegate(value1, value2);
                Console.WriteLine("------------------------------------------------------------------");

                Console.WriteLine("Ergebnis: " + result);

                Console.WriteLine("Zum beenden F12 drücken.");

                //Durch true im ReadKey() wird angegeben das das Zeichen nicht auf der Konsole ausgegeben werden soll.
            } while (Console.ReadKey(true).Key != ConsoleKey.F12);
        }
    }
}
