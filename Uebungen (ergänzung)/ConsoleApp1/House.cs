using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class House
    {
        public double Length_house { get; set; }
        public double Width_house { get; set; }
        public double Height { get; set; }
        public string Roof { get; set; }
        public string Color{ get; set; }
        public int Floor { get; set; }
        public double Price { get; set; }
        public double Length_property { get; set; }
        public double Width_property { get; set; }
        public string Colorchange { get; set; }


        public House(double length_house, double width_house, double height, string roof, string color, int floor, double price, double length_property, double width_property)
        {
            Length_house = length_house;
            Width_house = width_house;
            Height = height;
            Roof = roof; 
            Color = color;
            Floor = floor; 
            Price = price; 
            Length_property = length_property;
            Width_property = width_property;
        }
        public static House HouseData()
        {
            double length_house = Convert.ToDouble(Console.ReadLine());
            double width_house = Convert.ToDouble(Console.ReadLine());
            double height = Convert.ToDouble(Console.ReadLine());
            string roof = Console.ReadLine();
            string color = Console.ReadLine();
            int floor = Convert.ToInt32(Console.ReadLine());
            double price = Convert.ToDouble(Console.ReadLine());
            double length_property = Convert.ToDouble(Console.ReadLine());
            double width_property = Convert.ToDouble(Console.ReadLine());

            House h1 = new House(length_house, width_house, height, roof, color, floor, price, length_property, width_property);
            return h1;
        }

        public void HouseInformation()
        {
            Console.WriteLine($"Dein Haus hat folgende Daten: Length_house = {Length_house} Width_house = {Width_house}" +
                $" Height = {Height} Roof = {Roof} Floor = {Floor} Price = {Price} Length_property = {Length_property} " +
                $" Width_property = {Width_property}");
        }
        public void GrundstückQM()
        {
            double propertyqm = Length_property * Width_property;
            Console.WriteLine($"Dein Grundstück ist {propertyqm} groß");
        }
        public void Hausfläche()
        {
            double livingarea = Length_house * Width_house * Floor;
            Console.WriteLine($"Dein Haus ist {livingarea} groß");
        }
        public void Hausverputzen(string color)
        {
            Color = color;
            Console.WriteLine($"Deine neue Hausfarbe ist {color}");
        }
    }
}
