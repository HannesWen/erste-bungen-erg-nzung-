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
            Dreieck d = new Dreieck();
            d.Seite1 = 2;
            d.Seite2 = 4;
            d.Seite3 = 10;

            float dreiecksfläche = d.Flaeche();
            float dreiecksUmfang = d.Umfang();

            Circle c = new Circle();
            c.Radius = 5;
            float kreisFlaeche = c.Flaeche();
            float kreisUmfang = c.Umfang();
            
            Rechteck r = new Rechteck();
            r.Seite1 = 10;
            r.Seite2 = 20;

            float rechtecksFlaeche = r.Flaeche();
            float rechtecksUmfang = r.Umfang();

            Console.WriteLine($"Mein {d.GetType().Name} hat eine Fläche von {dreiecksfläche} und Umfang von {dreiecksUmfang}.");
            Console.WriteLine($"Mein {d.GetType().Name} hat eine Fläche von {kreisFlaeche} und Umfang von {kreisUmfang}.");
            Console.WriteLine($"Mein {d.GetType().Name} hat eine Fläche von {rechtecksFlaeche} und Umfang von {rechtecksUmfang}.");

            List<IGeometry> geometries = new List<IGeometry>();
            geometries.Add(d);
            geometries.Add(c);
            geometries.Add(r);
            
            foreach (IGeometry g in geometries)
            {
                Console.WriteLine($"Mein {g.GetType().Name} eine Fläche " +
                    $"von {g.Flaeche()} und einen Umfang von {g.Umfang()}");
            }
            Console.ReadKey();
        }
    }
}
