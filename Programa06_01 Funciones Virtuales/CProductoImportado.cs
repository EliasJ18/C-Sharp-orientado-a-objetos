using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa06_01_Funciones_Virtuales
{
    internal class CProductoImportado : CProducto
    {
        // Con override se indica que se usará esa version del metodo y no la
        // original contenida en la clase padre,

        protected double impuesto;

        public CProductoImportado(string pDescripcion, double pPrecioCompra, double pImpuesto)
        :base(pDescripcion, pPrecioCompra)
        {
            impuesto = pImpuesto;
        }

        // Poner un sealed en una funcion virtual que ya tiene su propia version
        // (override), nos dice que las clases que hereden de esta clase, ya no
        // podran hacer uso personalizado de esta funcion, ya que se encunetra
        // sellada.

        public sealed override void CalcularPrecio()
        {
            Console.WriteLine("Calcula precio de importado");
            precioVenta = (precioCompra * (1 + impuesto)) * 1.30;
        }
    }
}
