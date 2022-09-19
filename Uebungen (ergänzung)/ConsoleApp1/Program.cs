using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Configuration;
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
            Dreieck d = new Dreieck(2, 4, 10);

            float dreiecksfläche = d.Flaeche();
            float dreiecksUmfang = d.Umfang();

            Circle c = new Circle(5);

            float kreisFlaeche = c.Flaeche();
            float kreisUmfang = c.Umfang();
            
            Rechteck r = new Rechteck(10, 20);

            float rechtecksFlaeche = r.Flaeche();
            float rechtecksUmfang = r.Umfang();

            List<IGeometry> geometries = new List<IGeometry>();
            geometries.Add(d);
            geometries.Add(c);
            geometries.Add(r);
            
            foreach (IGeometry g in geometries)
            {
                Console.WriteLine($"Mein {g.GetType().Name} eine Fläche " +
                    $"von {g.Flaeche()} und einen Umfang von {g.Umfang()}");
            }

            List<Vehicle> fahrzeuge = new List<Vehicle>();
            fahrzeuge.Add(new Motorcycle(523, "BMW", "GSXR 2000", "3.0", 3000, "Blau", 2));
            fahrzeuge.Add(new Motorcycle(123, "VW", "Golf V", "2.0 TDI", 1900, "Rot", 4));

            foreach (Vehicle v in fahrzeuge)
            {
                v.Starten();
                v.Beschleunigen();
                v.Beschleunigen();
                v.Bremsen();
                v.Starten();
                v.Bremsen();
                v.Bremsen();
            }

            Console.ReadKey();
        }
    }
}
