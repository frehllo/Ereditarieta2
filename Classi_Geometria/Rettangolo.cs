using System;
using System.Collections.Generic;
using System.Text;

namespace Classi_Geometria
{
    public class Rettangolo : Quadrilatero
    {
        public double Lato { get;}

        public Rettangolo(double l)
        {
            Lato = l;
        }
    }
}
