using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01_01
{
    // Esta clase es definida por nosotros
    internal class CCalculadora
    {
        // Declaramos los atributos
        public double a;
        public double b;
        public double r;

        // Declaramos los metodos
        public void suma()
        {
            // Se lleva a cabo una accion
            r = a + b;
        }

        public void muestra()
        {
            Console.WriteLine("A = {0}, B = {1}, Rta: {2}", a, b, r);
        }

    }
}
