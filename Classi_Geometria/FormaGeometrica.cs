using System;

namespace Classi_Geometria
{
    public class FormaGeometrica
    {
        internal int Tipo { get; }

        public FormaGeometrica(int t)
        {
            Tipo = t;
        }

        public void CalcolaPerimetro()
        {
            if(Tipo == 1)
            {
                double CalcolcaPerimetroRettangolo(Rettangolo rettangolo)
                {
                    double p = Quadrilatero.N_LATI_QUADRILATERO * rettangolo.Lato;
                    return p;
                }
            }
            if(Tipo == 2)
            {
                double CalcolcaPerimetroRombo(Rombo rombo)
                {
                    double p = Quadrilatero.N_LATI_QUADRILATERO * rombo.Lato;
                    return p;
                }
            }
        }
    }
}
