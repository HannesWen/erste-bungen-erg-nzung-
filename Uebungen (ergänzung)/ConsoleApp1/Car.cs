using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Car
    {
        public int TypeId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string TypeName { get; set; }
        public double Ccm { get; set; }
        public int Tyres { get; set; }
        public string Color { get; set; }

        public Car(int typeId, string make, string model, string typeName, int ccm, string color, int tyres)
        {
            TypeId = typeId;
            Make = make;
            Model = model;
            TypeName = typeName;
            Ccm = ccm;
            Color = color;
            Tyres = tyres;
        }

        public static Car CarData()
        {
            int typeId = Convert.ToInt32(Console.ReadLine());
            string make = Console.ReadLine();
            string model = Console.ReadLine();
            string typeName = Console.ReadLine();
            int ccm = Convert.ToInt32(Console.ReadLine());
            string color = Console.ReadLine();
            int tyres = Convert.ToInt32(Console.ReadLine());

            Car c1 = new Car(typeId, make, model, typeName, ccm, color, tyres);
            return c1;
        }

        public void PrintCarInformation()
        {
            Console.WriteLine($"Mein Fahrzeug hat die ID {TypeId}, die Marke {Make}," +
            $" das Model {Model}, den Name {TypeName}, die ccm {Ccm}, die Farbe {Color} und {Tyres} Räder.");
        }
        
    }
}
