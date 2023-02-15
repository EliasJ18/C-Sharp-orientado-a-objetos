using System;

namespace Programa02_04_Atributos_Estáticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CCompu pc1 = new CCompu();
            CCompu pc2 = new CCompu("i5", 4, 450);
            CCompu pc3 = new CCompu("i7", 8, 670);

            pc1.TipoCambio = 15.70;

            // Mostramos
            pc1.muestraDolares();
            pc1.muestraPesos();
            Console.WriteLine("--------------");

            pc2.muestraDolares();
            pc2.muestraPesos();
            Console.WriteLine("--------------");

            pc3.muestraDolares();
            pc3.muestraPesos();
            Console.WriteLine("--------------");

            Console.WriteLine("======================");

            // Hacemos el cambio, debe de reflejarse en todos

              pc1.TipoCambio = 18.80;

            // Mostramos
            pc1.muestraDolares();
            pc1.muestraPesos();
            Console.WriteLine("--------------");

            pc2.muestraDolares();
            pc2.muestraPesos();
            Console.WriteLine("--------------");

            pc3.muestraDolares();
            pc3.muestraPesos();
            Console.WriteLine("--------------"); 
        }
    }
}
