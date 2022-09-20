using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Lion : Animal
    {
        public Lion(string names, int age, float size, int liveSpan, float weight, bool fur)
        {
            Names = names;
            Age = age;
            Size = size;
            LiveSpan = liveSpan;
            Weight = weight;
            Fur = fur;
        }
        public override void Noises()
        {
            Console.WriteLine("Howl");
        }
    }
}
