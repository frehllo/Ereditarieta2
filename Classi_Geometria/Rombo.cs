using System;
using System.Collections.Generic;
using System.Text;

namespace Classi_Geometria
{
    public class Rombo : Quadrilatero
    {
        public double Lato { get; set; }
        public double Dmax { get; set; }
        public double Dmin { get; set; }

        public Rombo(int nl, double l, double dmin, double dmax) : base(N_LATI_QUADRILATERO)
        {
            Lato = l;
            Dmax = dmax;
            Dmin = dmin;
        }
        public string CalcolaPerimetro()
        {
            double perimetro = Lato * N_LATI_QUADRILATERO;
            return $"Il perimetro è {perimetro}";
        }

        public string CalcolaArea()
        {
            double area = Dmax * Dmax / 2;
            return $"L'area è {area}";
        }
    }
}
