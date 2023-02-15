using System;

namespace Programa06_03_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Clases abstractas y metodos abstractos

            // No podemos instanciar clase abstracta directamente
            //CProducto miProducto = new CProducto("Bicicleta", 3500);

            CProductoImportado miProdImp = new CProductoImportado("Motocicleta", 350000, 0.15);
            CProductoDetenido miProdDet = new CProductoDetenido("TV", 15000, 0.15, 0.30);

            miProdImp.CalcularPrecio();
            miProdDet.CalcularPrecio();

            miProdImp.MuestraVenta();
            miProdDet.MuestraVenta();
        }
    }
}
