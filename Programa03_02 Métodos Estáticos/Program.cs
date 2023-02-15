using System;

namespace Programa03_02_Métodos_Estáticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r = 0.0;

            // Clase normal

            CCalculadora miCalcu = new CCalculadora(5, 3);
            miCalcu.suma();
            Console.WriteLine("La suma es {0}", miCalcu.R);

            miCalcu.resta();
            Console.WriteLine("La resta es {0}", miCalcu.R);

            // Clase con metodos estaticos

            // El metodo por ser estatico, puede ser invocado sin instanciarlo
            // en este caso se lo guardamos en r haciendo referencia a respuesta
            // ya que los metodos retornan el calculo correspondiente y se 
            // almacena en r el resultado final.
            r = CCalculadoraS.suma(6, 9);
            Console.WriteLine("la suma es {0}", r);

            r = CCalculadoraS.resta(45, 67);
            Console.WriteLine("la resta es {0}", r);

            // Los metodos que no son estáticos si se deben de instanciar
            // como lo hacemos habitualmente para poder utilizarlos.
            // CCalculadoraS.Saludo();

            // Uso habitual
            CCalculadoraS hola = new CCalculadoraS();

            hola.Saludo();
        }
    }
}
