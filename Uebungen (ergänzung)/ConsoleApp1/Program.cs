using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array befüllen und mit werten befüllen
            //Random r = new Random();
            //Console.WriteLine("Wie viele Einträge möchtest du in deinem int Array?");
            //int arraygröße = Convert.ToInt32(Console.ReadLine());
            //int[] zahlen = new int[arraygröße];
            //for (int i = 0; i < arraygröße; i++)
            //{
            //    int random_zahl = r.Next(1, 100);
            //    zahlen[i] = random_zahl;
            //}
            //foreach (int zahl in zahlen)
            //{
            //    Console.WriteLine(zahl);
            //}
            //Console.ReadKey();

            //Array befüllen und summe sowie durschnitt ausgeben
            //Random r = new Random();
            // Console.WriteLine("Wie viele Einträge möchtest du in deinem int Array?");
            // int arraygröße = Convert.ToInt32(Console.ReadLine());
            // int[] zahlen = new int[arraygröße];
            // for (int i = 0; i < arraygröße; i++)
            // {
            //     int random_zahl = r.Next(1, 100);
            //     zahlen[i] = random_zahl;
            // }
            // double durchschnitt = zahlen.Average();
            // int summe = zahlen.Sum();
            //Console.WriteLine($"Die Summe ist: {summe}");
            //Console.WriteLine($"Der Durschschnitt ist: {durchschnitt}");
            //Console.ReadKey();

            //Roulette
            Random r = new Random();
            int dollar = 10000;
            int einsatz = 10;
            int runden = 0;
            do
            {
                int k = r.Next(0, 36);
                Console.WriteLine($"Du hast vor dem Spiel: {dollar} dollar.");
                Console.WriteLine($"Runde {runden}.");
                if (einsatz > dollar)
                {
                    Console.WriteLine($"Dein neuer einsatz {einsatz} ist höher als deine dollar {dollar}.");
                    Console.WriteLine($"Du setzt nun all deine verbliebenen dollar {dollar}.");
                    einsatz = dollar;
                }
                else
                {
                    Console.WriteLine($"Dein einsatz ist {einsatz}");
                }
                Console.WriteLine($"Die geworfene Zahl ist: {k}.");
                if (k % 2 != 0)
                {
                    Console.WriteLine($"Du lagst falsch. Der Einsatz {einsatz} wird dir abgebucht.");
                    dollar = dollar - einsatz;
                    einsatz = einsatz * 2;
                    if (einsatz >= 1000)
                    {
                        einsatz = 1000;
                    }
                }
                else if ((k % 2 == 0) && k > 0)
                {
                    Console.WriteLine($"Du lagst richtig. Der Einsatz {einsatz} wird dir gutgeschrieben."); 
                    dollar = dollar + einsatz;
                    if (dollar >= 10000)
                    {
                        einsatz = 10;
                    }
                }
                Console.WriteLine($"Du hast nach dem Spiel: {dollar} dollar.");
                Console.WriteLine();
                runden = runden + 1;
            } while (dollar > 0);
            Console.WriteLine($"Das Spiel ist aus. Du hast {runden} runden gespielt und all dein Geld verloren.");
            Console.WriteLine("Da siehst du mal was Glücksspiel anrichten kann. Infos und Hilfe unter www.bzga.de."); 
            Console.ReadKey();
        }
    }
}
