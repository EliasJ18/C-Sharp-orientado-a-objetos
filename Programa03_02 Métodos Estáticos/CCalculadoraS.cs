using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa03_02_Métodos_Estáticos
{
    internal class CCalculadoraS

        // El modificador static en un metodo nos va a permitir
        // invocar ese metodo sin tener una instanciacion de esa clase
    {
        public static double suma(double a, double b)
        {
            return a + b;
        }

        public static double resta(double a, double b)
        {
            return a - b;
        }

        public void Saludo()
        {
            Console.WriteLine("Hola");
        }
    }
}
