using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01_04_Metodos_Privados
{
    // Esta clase es definida por nosotros
    internal class CCalculadora
    {
        // Declaramos los atributos
        public double a;
        public double b;
        public double r;

        // Le cambiamos el tipo de acceso a private
        // Cuando algo es privado, solo el objeto puede acceder a el

        // Declaramos los metodos
        public void Suma()
        {
            // Se lleva a cabo una accion
            r = a + b;

            // Invocamos al metodo
            Muestra();
        }

        private void Muestra()
        {
            Console.WriteLine("A = {0}, B = {1}, R: {2}", a, b, r);
        }

    }
}
