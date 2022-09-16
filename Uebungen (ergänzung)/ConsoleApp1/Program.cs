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
            ////Seite 2, Aufgabe 5:
            //for (int i = 0; i < 100; i++)
            //{
            //    if (i % 3 == 0 && i % 5 == 0)
            //    {
            //        Console.WriteLine("FizzBuzz");
            //    }
            //    else if (i % 3 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }
            //    else if (i % 5 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.ReadKey();


            //Switch
            //string zahl = Console.ReadLine();
            //switch(zahl)
            //{
            //    case "1":
            //        Console.WriteLine("Die Zahl ist 1");
            //        break;
            //    case "2":
            //        Console.WriteLine("Die Zahl ist 2");
            //        break;
            //    case "3":
            //        Console.WriteLine("Die Zahl ist fünf");
            //        break;
            //    default:
            //        Console.WriteLine("Kein Fall trifft zu");
            //        break;
            //}
            //Console.ReadKey();

            //Taschenrechner simpel

            Console.WriteLine("Gebe mir eine Zahl");
            int zahl1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Was möchtest du mit der Zahl machen?");
            string rechenzeichen = (Console.ReadLine());

            Console.WriteLine("Gebe mir eine weitere Zahl");
            int zahl2 = Convert.ToInt32(Console.ReadLine());

            double ergebnis = 0;

            switch (rechenzeichen)
            {
                case "*":
                    ergebnis = zahl1 * zahl2;
                    Console.WriteLine(ergebnis);
                    break;
                case "/":
                    ergebnis = zahl1 / zahl2;
                    Console.WriteLine(ergebnis);
                    break;
                case "+":
                    ergebnis = zahl1 + zahl2;
                    Console.WriteLine(ergebnis);
                    break;
                case "-":
                    ergebnis = zahl1 - zahl2;
                    Console.WriteLine(ergebnis);
                    break;
            }
            Console.ReadKey();
        }
    }
}
