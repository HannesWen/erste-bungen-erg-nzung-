using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gib mir bitte zwei Zahlen()");
            double zahl1 = Convert.ToDouble.(Console.ReadLine());
            double zahl2 = Convert.ToDouble.(Console.ReadLine());

            double ergebnis = Add(zahl1, zahl2);
            Console.WriteLine("Das Ergebnis der addition lautet " + ergebnis);

            double ergebnis1 = Multiply(zahl1, zahl2);
            Console.WriteLine("Das Ergebnis der multiplikation lautet " + ergebnis1);

            double ergebnis2 = subtract(zahl1, zahl2);
            Console.WriteLine("Das Ergebnis der subtraktion lautet " + ergebnis2);

            double ergebnis3 = divide(zahl1, zahl2);
            Console.WriteLine("Das Ergebnis der division lautet " + ergebnis3);

            Console.ReadKey();
        }

        static double Add(double z1, double z2)
        {
            double summe = z1 + z2;
            return summe;
        }

        static double Multiply(double z1, double z2)
        {
            double summe = z1 * z2;
            return summe;
        }

        static double subtract(double z1, double z2)
        {
            double summe = z1 - z2;
            return summe;
        }

        static double divide(double z1, double z2)
        {
            double summe = z1 / z2;
            return summe;
        }




        ////static Rückgabetyp MethodenName (Parameter)
        //static List<string> Number()
        //{
        //    List<string> name = new List<string>();
        //    name.Add("ABC");

        //    //Rückgabevariable
        //    return name;
    }
}
