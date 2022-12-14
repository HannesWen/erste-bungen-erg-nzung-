using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Rechteck : IGeometry
    {
        public float Seite1 { get; set; }
        public float Seite2 { get; set; }

        public Rechteck(float seite1, float seite2)
        {
            Seite1 = seite1;
            Seite2 = seite2;
        }
        public float Flaeche()
        {
            return Seite1 * Seite1;
        }
        public float Umfang()
        {
            return 2 * (Seite2 + Seite1);
        }
    }
}
