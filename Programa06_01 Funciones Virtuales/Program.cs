using System;

namespace Programa06_01_Funciones_Virtuales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Funcion virtual y override con sealed

            // Creamos producto
            CProducto uno = new CProducto("Bicicleta", 2500.35);

            uno.CalcularPrecio();
            uno.MuestraVenta();

            Console.WriteLine("----------------------");

            // Creamos producto importado
            CProductoImportado dos = new CProductoImportado("Bicicleta Importada", 2500.35, 0.15);

            dos.CalcularPrecio();
            dos.MuestraVenta();

            Console.WriteLine("--------------");

            // Creamos producto con multa
            CProductoDetenido tres = new CProductoDetenido("Bici detenida", 2500.35, 0.15, 500.8);

            tres.CalcularPrecio();
            tres.MuestraVenta();
        }
    }
}
