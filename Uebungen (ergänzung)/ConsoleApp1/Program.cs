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
            //Car c1 = new Car(12345, "Audi", "A3", "2.0 TDI", 1980, "Red", 4);
            //c1.PrintCarInformation();

            //Car c2 = new Car(25642, "BMW", "3", "2.2", 2200, "Black", 4);

            //c2.PrintCarInformation();

            //List<Car> cars = new List<Car>();

            //foreach (Car car in cars)
            //{
            //    car.PrintCarInformation();
            //}

            //Console.ReadLine();


            // Frage den User nach einer beliebigen Anzahl von Fahrzeugsätzen und lass sie wieder ausgeben.

            Console.WriteLine("Wie viele Fahrzeuge möchtest du anlegen?");
            int anzahl = Convert.ToInt32(Console.ReadLine());

            List<Car> fahrzeugdaten = new List<Car>();

            for (int i = 0; i < anzahl; i++)
            {
                Console.WriteLine("Bitte gib mir folgende Fahrzeugdaten: TypeId, Make, Model, TypeName, Ccm, Color, Tyres");

                fahrzeugdaten.Add(Car.CarData());
            }
            foreach (Car c in fahrzeugdaten)
            {
                c.PrintCarInformation();
            }
            Console.ReadKey();


            //List<Cars> cars = new List<Car>();
            //for (int i = 0; i < 3; i++)
            //{
            //    cars.Add(Car.AskUserForCar());
            //}

            //foreach (Car car in cars)
            //{
            //    car.PrintCarInformation();
            //}
            //Console.ReadKey();




        }
    }
}
