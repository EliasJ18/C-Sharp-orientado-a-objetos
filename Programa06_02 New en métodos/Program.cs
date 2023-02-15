using System;

namespace Programa06_02_New_en_métodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Uso de new en metodos
            // Nos permite poner código propio a metodos no virtuales
            // Pero perdemos polimorfismo

            CProductoImportado uno = new CProductoImportado("Moto", 45000.0, 0.15);

            uno.CalcularPrecio();
            uno.MuestraVenta();

            Console.WriteLine("---------------------------");

            CProducto p1 = new CProducto("TV", 10500);

            p1.CalcularPrecio();
            p1.MuestraVenta();

            Console.WriteLine("---------------------------");


            // Puedo hacer lo siguiente gracias a la herencia que tienen
            // estas clases. producto importado es-un producto

            // Aqui se rompe el polimorfismo, porque por haber echo uso
            // de new en la funcion muestra venta, perdió su caracteristica
            // polimorfica y entonces ejecuta la funcion de la clase base
            // que es CProducto
            CProducto p3 = new CProductoImportado("bici", 2200, 0.2);

            p3.CalcularPrecio();
            p3.MuestraVenta();


        }
    }
}
