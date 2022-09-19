using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Animal
    {
        public string Names { get; set; }
        public int Age { get; set; }
        public float Size { get; set; }
        public string Durability { get; set; }
        public float Weight { get; set; }
        public bool Fur { get; set; }

        public Animal(string names, int age, float size, string durability, float weight, bool fur)
        {
            Names = names;
            Age = age;  
            Size = size;
            Durability = durability;
            Weight = weight;
            Fur = fur;
        }



    }

}
