using System;

namespace Programa01_05_Accessor_I
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double impuesto = 0.0;
            // Creamos objeto
            CEmpleado Juan = new CEmpleado();

            // No podemos hacer esto porque es un atributo privado:
            // Juan.sueldo = 1000;

            // Esto podemos hacerlo porque el metodo set_sueldo hace uso de set
            // lo cual si nos permite asignar valor a la propiedad.
            Juan.set_sueldo(10500);

            Juan.Muestra();
            Juan.CalculaImpuesto();

            impuesto = Juan.get_impuesto();

            Console.WriteLine("El impuesto es {0}", impuesto);

            Juan.Muestra();
        }
    }
}
