using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Configuration;
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

            // Der User gibt uns Daten für X Häuser welche wir wiedergeben.
            // Erstelle eine Klasse Huas.
            // Die Häuser haben folgende Eigenschaften
            // Laenge Haus flieskommazahl, Breite Haus flieskommazahl, Laenge Grundstück flieskommazahl, Breite Grundstück flieskommazahl, Höhe flieskommazahl, Dachart string, Putzfarbe string, Etagen int, Preis flieskommazahl

            // Methoden
            // Grundstück QM
            // Hauswohlfläcke (länge * breite + etage)
            // Hausverputzen (Farbe des putzes Ändern)
            // PrintEigenschaften

            Console.WriteLine("Wie viele Häuser möchtest du anlegen?");
            int anzahl = Convert.ToInt32(Console.ReadLine());

            List<House> housedata = new List<House>();

            for (int i = 0; i < anzahl; i++)
            {
                Console.WriteLine("Bitte gib mir folgende Hausdaten: length_house, width_house, height, roof, color, floor, price, length_property, width_property ");
                housedata.Add(House.HouseData());
            }
            foreach (House h in housedata)
            {
                h.HouseInformation();
                h.GrundstückQM();
                h.Hausfläche();
            }
            Console.WriteLine("Möchtest du die Farbe eines Hauses Ändern ja / nein ?");
            string ändern = Console.ReadLine();
            if (ändern == "ja")
            {
                Console.WriteLine("Bei welchem Haus möchtest du die Farbe ändern ?");
                int welcheshaus = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Welche Farbe soll es haben ?");
                string color = Console.ReadLine();
                housedata[welcheshaus].Hausverputzen(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}
