using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Listen
            Console.WriteLine("Bitte gib mir einen Namen, wenn deine Liste fertig sein soll schreibe - ");
            List<string> list = new List<string>();
            string eingabe = "0";

            do
            {
                eingabe = Console.ReadLine();
                list.Add(eingabe);
            } while (eingabe != "-");

            Console.WriteLine(list);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();
        }
    }
}
