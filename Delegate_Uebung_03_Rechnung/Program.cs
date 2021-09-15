using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Uebung_03_Rechnung
{
    public delegate void Zahlungsart(string vermerk, double value);

    //Das ist die Basis für den Bezahlvorgang, die Methoden für die Bezahlung selbst würde z.B. die Bank hinzufügen
    public class Rechnung
    {
        //Da OffenerBetrag readOnly ist muss ein Feld verwendet werden.
        private double offenerBetrag;
        public string Rechnungsnummer { get; }
        public double Rechnungsbetrag { get; }

        //Gibt offenerBetrag zurück
        public double OffenerBetrag => offenerBetrag;

        public Rechnung(string rechnungsnummer, double rechnungsbetrag)
        {
            Rechnungsnummer = rechnungsnummer;
            Rechnungsbetrag = rechnungsbetrag;
            offenerBetrag = rechnungsbetrag;
        }

        public void Bezahlen(Zahlungsart zahlungsart, string vermerk, double value)
        {
            zahlungsart(vermerk, value);
            offenerBetrag -= value;
        }

        public override string ToString()
        {
            return $"{{{nameof(Rechnungsnummer)}={Rechnungsnummer}, " +
                $"{nameof(Rechnungsbetrag)}={Rechnungsbetrag.ToString()} EUR, " +
                $"{nameof(OffenerBetrag)}={OffenerBetrag.ToString()} EUR}}";
        }
    }

    class Program
    {
        //Die Methoden kommen nicht vom Programmierer der Klasse Rechnung
        static void Kreditkartenzahlung(string vermerk, double value)
        {
            Console.WriteLine("Kreditkartenzahlung: " + vermerk + " über " + value + " EUR");
        }

        static void Ueberweisung(string vermerk, double value)
        {
            Console.WriteLine("Überweisung: " + vermerk + " über " + value + " EUR");
        }

        static void Barzahlung(string vermerk, double value)
        {
            Console.WriteLine("Barzahlung: " + vermerk + " über " + value + " EUR");
        }

        static void Main(string[] args)
        {
            Rechnung r1 = new Rechnung("1234", 450);

            Console.WriteLine(r1.ToString());

            Zahlungsart zahlungsart = Kreditkartenzahlung;

            r1.Bezahlen(zahlungsart, "Anzahlung", 250);
            Console.WriteLine(r1.ToString());

            zahlungsart = Ueberweisung;

            r1.Bezahlen(zahlungsart, "Zweite Teilzahlung", 150);
            Console.WriteLine(r1);

            zahlungsart = Barzahlung;

            r1.Bezahlen(zahlungsart, "Finale Zahlung", 50);
            Console.WriteLine(r1);

            Console.ReadKey();
        }
    }
}
