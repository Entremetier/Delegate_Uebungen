using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Übung: Studenten                                                  Lambda-Expressions
 * ----------------
 * Erstellen Sie eine Liste mit folgenden Studenten:
 * 
 *   Vorname  Nachname  Land          Geschlecht   Geb.Datum    Studienrichtung
 *   Ida      Meier     Österreich    weiblich     22.03.2000   Jus
 *   Leo      Werner    Österreich    männlich     28.09.2002   Architektur
 *   Ali      Hofer     Österreich    männlich     07.05.2001   Raumplanung
 *   Bea      Ebner     Deutschland   weiblich     03.01.2004   Informatik
 *   Zoe      Böhm      Österreich    weiblich     16.10.1999   Soziologie
 *   Jan      Eder      Österreich    männlich     11.08.2002   Biologie
 *   Ken      Wolf      Schweiz       männlich     04.06.2003   Informatik
 *   Eva      Fuchs     Österreich    weiblich     09.09.2003   Mathematik
 *   Max      Huber     Österreich    männlich     24.07.2001   Informatik
 *   Ben      Egger     Deutschland   männlich     12.02.2002   Statistik
 * 
 * Führen Sie folgende Ermittlungen mit Hilfe von Lambda-Ausdrücken durch und geben Sie
 * die zugehörigen Resultate aus:
 * 
 *    - Ermitteln Sie alle Studenten aus Österreich.
 *    - Ermitteln Sie alle weiblichen Studentinnen.
 *    - Ermitteln Sie alle Studenten der Studienrichtung Informatik.
 *    - Ermitteln Sie alle Studenten der Studienrichtung Informatik,
 *      die älter als 20 Jahre sind.
 *    - Ermitteln Sie alle österreichischen Studenten, die vor dem 01.01.2002 geboren
 *      sind.
 */

namespace Delegate_Uebung_09_Studenten
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentYear = DateTime.Now.Date.Year;

            List<Student> students = new List<Student>
            {
                new Student("Ida", "Meier", Land.Österreich, Geschlecht.weiblich, new DateTime(2002, 09, 28), "Jus"),
                new Student("Leo", "Werner", Land.Österreich, Geschlecht.männlich, new DateTime(2000, 03, 22), "Architektur"),
                new Student("Ali", "Hofer", Land.Österreich, Geschlecht.männlich, new DateTime(2001, 05, 07), "Raumplanung"),
                new Student("Bea", "Ebner", Land.Deutschland, Geschlecht.weiblich, new DateTime(2004, 01, 03), "Informatik"),
                new Student("Zoe", "Böhm", Land.Österreich, Geschlecht.weiblich, new DateTime(1999, 10, 16), "Soziologie"),
                new Student("Jan", "Eder", Land.Österreich, Geschlecht.männlich, new DateTime(2002, 08, 11), "Biologie"),
                new Student("Ken", "Wolf", Land.Schweiz, Geschlecht.männlich, new DateTime(2003, 06, 04), "Informatik"),
                new Student("Eva", "Fuchs", Land.Österreich, Geschlecht.weiblich, new DateTime(2003, 09, 09), "Mathematik"),
                new Student("Max", "Huber", Land.Österreich, Geschlecht.männlich, new DateTime(2001, 07, 24), "Informatik"),
                new Student("Ben", "Egger", Land.Deutschland, Geschlecht.männlich, new DateTime(2002, 02, 12), "Statistik"),
            };

            Console.WriteLine("Alle Studenten aus Österreich:");
            students.FindAll(x => x.Land.Equals("Österreich")).ForEach(x => Console.WriteLine(x));
            Console.WriteLine();

            Console.WriteLine("Alle Studentinnen:");
            students.FindAll(x => x.Geschlecht.Equals(Geschlecht.weiblich)).ForEach(x => Console.WriteLine(x));
            Console.WriteLine();

            Console.WriteLine("Alle Studenten mit Fachrichtung Informatik und älter als 20 Jahre:");
            students.FindAll(x => x.Studienrichtung.Equals("Informatik")).FindAll(x => (currentYear - x.Geburtstag.Year) > 20).ForEach(x => Console.WriteLine(x));
            Console.WriteLine();

            Console.WriteLine("Alle Studenten aus Österreich die vor dem 01.01.2002 geboren wurden:");
            students.FindAll(x => x.Land.Equals("Österreich")).FindAll(x => x.Geburtstag < new DateTime(2002, 01, 01)).ForEach(x => Console.WriteLine(x));


            Console.ReadKey();
        }
    }

    internal class Student
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public Land Land { get; set; }
        public Geschlecht Geschlecht { get; set; }
        public DateTime Geburtstag { get; set; }
        public string Studienrichtung { get; set; }

        public Student(string vorname, string nachname, Land land, Geschlecht geschlecht,
            DateTime geburtstag, string studienrichtung)
        {
            Vorname = vorname;
            Nachname = nachname;
            Land = land;
            Geschlecht = geschlecht;
            Geburtstag = geburtstag;
            Studienrichtung = studienrichtung;
        }

        public override string ToString()
        {
            return $"{{{nameof(Vorname)}={Vorname}, {nameof(Nachname)}={Nachname}, {nameof(Land)}={Land}, {nameof(Geschlecht)}={Geschlecht}, " +
                $"{nameof(Geburtstag)}={Geburtstag.ToShortDateString()}, {nameof(Studienrichtung)}={Studienrichtung}}}";
        }
    }

    public enum Geschlecht
    {
        weiblich, männlich
    }

    public enum Land
    {
        Österreich, Deutschland, Schweiz
    }
}
