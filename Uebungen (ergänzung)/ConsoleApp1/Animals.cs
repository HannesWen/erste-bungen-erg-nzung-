using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Animal 
    {
        public string Names { get; set; }
        public int Age { get; set; }
        public float Size { get; set; }
        public string LifeSpan { get; set; }
        public float Weight { get; set; }
        public bool Fur { get; set; }
        public bool Hungry { get; set; }
        public bool Thirsty { get; set; }

        public void Eating()
        {
            if (Hungry == true)
            {
                Console.WriteLine("Das Tier sollte etwas essen ?!?");
            }
        }
        public void Drinking()
        {
            if (Thirsty == true)
            {
                Console.WriteLine("Das Tier sollte etwas essen");
            }
        }
        public abstract void Noises();
    }
}
