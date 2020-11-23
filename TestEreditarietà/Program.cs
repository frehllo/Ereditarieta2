using Classi_Geometria;
using System;

namespace TestEreditarietà
{
    class Program
    {
        static void Main(string[] args)
        {
            //scegliere forma geometrica
            Console.WriteLine("Che tipo di forma geometrica vuoi creare ? 1 = rettangolo , 2 = rombo, 3 = triangolo");
            int t = int.Parse(Console.ReadLine());

            if(t == 1)
            {
                Rettangolo rettangolo = new Rettangolo(Quadrilatero.N_LATI_QUADRILATERO,10,12);
                Console.WriteLine("Vuoi calcolare area(1), perimetro(2) o entrambi(3)?");

                //scegli cosa calcolare
                int r = int.Parse(Console.ReadLine());
                if(r == 1)
                {
                    Console.WriteLine(rettangolo.CalcolaArea());
                }
                if (r == 2)
                {
                    Console.WriteLine(rettangolo.CalcolaPerimetro());
                }
                if (r == 3)
                {
                    Console.WriteLine(rettangolo.CalcolaArea());
                    Console.WriteLine(rettangolo.CalcolaPerimetro());
                }
            }
            if(t == 2)
            {
                Rombo rombo = new Rombo(Quadrilatero.N_LATI_QUADRILATERO, 10, 5, 5);

                //scegli cosa calcolare
                int r = int.Parse(Console.ReadLine());
                if (r == 1)
                {
                    Console.WriteLine(rombo.CalcolaArea());
                }
                if (r == 2)
                {
                    Console.WriteLine(rombo.CalcolaPerimetro());
                }
                if (r == 3)
                {
                    Console.WriteLine(rombo.CalcolaArea());
                    Console.WriteLine(rombo.CalcolaPerimetro());
                }
            }

            Console.ReadLine();

        }
    }
}
