using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Configuration;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Dreieck d = new Dreieck(2, 4, 10);

            //    float dreiecksfläche = d.Flaeche();
            //    float dreiecksUmfang = d.Umfang();

            //    Circle c = new Circle(5);

            //    float kreisFlaeche = c.Flaeche();
            //    float kreisUmfang = c.Umfang();

            //    Rechteck r = new Rechteck(10, 20);

            //    float rechtecksFlaeche = r.Flaeche();
            //    float rechtecksUmfang = r.Umfang();

            //    List<IGeometry> geometries = new List<IGeometry>();
            //    geometries.Add(d);
            //    geometries.Add(c);
            //    geometries.Add(r);

            //    foreach (IGeometry g in geometries)
            //    {
            //        Console.WriteLine($"Mein {g.GetType().Name} eine Fläche " +
            //            $"von {g.Flaeche()} und einen Umfang von {g.Umfang()}");
            //    }

            //    List<Vehicle> fahrzeuge = new List<Vehicle>();
            //    fahrzeuge.Add(new Motorcycle(523, "BMW", "GSXR 2000", "3.0", 3000, "Blau", 2));
            //    fahrzeuge.Add(new Motorcycle(123, "VW", "Golf V", "2.0 TDI", 1900, "Rot", 4));

            //    foreach (Vehicle v in fahrzeuge)
            //    {
            //        v.Starten();
            //        v.Beschleunigen();
            //        v.Beschleunigen();
            //        v.Bremsen();
            //        v.Starten();
            //        v.Bremsen();
            //        v.Bremsen();
            //    }

            //    Console.ReadKey();

            Console.WriteLine("Welcome to ZooBoring!");
            Console.WriteLine("We can show you a incredible amount of 5 animals and 2 of them are not even worth paying money for.");


            List<Animal> animals = new List<Animal>();
            Animal.Add(new Lion("Bruce", 5, 140, 15, 140, "yes"));
            Animal.Add(new Pig("Wolley", 14, 85, 18, 170, "yes"));
            Animal.Add(new Frog("Francis", 1, 4, 1, 30, "no"));
            Animal.Add(new Dog("Mr Sniffels", 7, 50, 14, 30, "yes"));
            Animal.Add(new Cat("Daisy", 3, 20, 10, 12, "yes" ))

           


            Console.ReadKey();
        }
    }
}
