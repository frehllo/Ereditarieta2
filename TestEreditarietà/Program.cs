using Classi_Geometria;
using System;

namespace TestEreditarietà
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Che tipo di forma giometrica vuoi creare? 1 = rettangolo , 2 = rombo, 3 = triangolo");
            int t = int.Parse(Console.ReadLine());

            if(t == 1)
            {
                Rettangolo rettangolo = new Rettangolo(12);
            }
            if(t==2)
            {

                Rombo rombo = new Rombo(15);
            }

            FormaGeometrica forma = new FormaGeometrica(t);
            forma.CalcolaPerimetro();
            Console.ReadLine();
        }
    }
}
