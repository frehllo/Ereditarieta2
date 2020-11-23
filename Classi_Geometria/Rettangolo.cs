using System;
using System.Collections.Generic;
using System.Text;

namespace Classi_Geometria
{
    public class Rettangolo : Quadrilatero
    {
        public double Base { get; set; }
        public double Altezza { get; set; }

        public Rettangolo(int nl, double b, double h) : base(N_LATI_QUADRILATERO)
        {
            Base = b;
            Altezza = h;
        }
        public string CalcolaPerimetro()
        {
            double perimetro = (Base+Altezza)*2 ;
            return $"Il perimetro è {perimetro}";
        }

        public string CalcolaArea()
        {
            double area = Base * Altezza;
            return $"L'area è {area}";
        }
    }
}
