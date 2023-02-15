using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa02_01_Sobrecarga_de_metodos
{
    // Esta clase es definida por nosotros
    internal class CCalculadora
    {
        // La sobrecarga de metodos es un metodo con mas de una version de 
        // si mismo. En este caso, estos tres metodos tienen en comun que
        // suman numeros, solo que los primeros son nros enteros y el ultimo
        // son de nros de punto flotante.
        // De esta manera, segun el tipo de dato que se le pase por
        // parametro, el programa escoje la funcion de tipo int o la de double.

        // Declaramos los metodos
        public int Suma(int a, int b)
        {
            int r = 0;

            r = a + b;

            return r;
        }

        public int Suma(int a, int b, int c)
        {
            int r = 0;

            r = a + b + c;

            return r;
        }

        public double Suma(double a, double b)
        {
            double r = 0.0;

            r = a + b;

            return r;
        }
    }
}
