using System;

namespace Programa05_02_Composición
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos al propietario

            CPropietario Ana = new CPropietario("Ana");

            // Mostramos la propiedad
            Ana.MostrarPropiedad();
            Console.WriteLine("---------");

            // Esto rompe el encapsulamiento 
            // Tratamos de acceder a la propiedad
            //CEdificio edif = Ana.Propiedad;

            //edif.Muestra();
            //Console.WriteLine("------");

            // Eliminamos el objeto CPropietario
            //Ana = null;
            //GC.Collect();

            //edif.Muestra();
        }
    }
}
