using System;

namespace Programa02_01_Sobrecarga_de_metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rInt = 0;
            double rDoub = 0.0;

            CCalculadora calcu = new CCalculadora();

            rInt = calcu.Suma(5, 3);

            Console.WriteLine("El resultado es {0}", rInt);

            rInt = calcu.Suma(5, 5, 10);

            Console.WriteLine("El resultado es {0}", rInt);

            rDoub = calcu.Suma(10.58, 23.17);

            Console.WriteLine("El resultado es {0}", rDoub);
        }
    }
}
