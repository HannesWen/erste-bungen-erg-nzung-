using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Dreieck : IGeometry
    {
        public float Seite1 { get; set; }
        public float Seite2 { get; set; }
        public float Seite3 { get; set; }
        public float Umfang()
        {
            return Seite1 + Seite2 + Seite3;
        }
        public float Flaeche()
        {
            return 2;
        }
    }
}

