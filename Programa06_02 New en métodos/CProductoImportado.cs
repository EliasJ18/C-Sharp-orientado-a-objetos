using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa06_02_New_en_métodos
{
    internal class CProductoImportado : CProducto
    {
        protected double impuesto;

        public CProductoImportado(string pDescripcion, double pPrecioCompra, double pImpuesto)
        : base(pDescripcion, pPrecioCompra)
        {
            impuesto = pImpuesto;
        }

        public override void CalcularPrecio()
        {
            Console.WriteLine("Calcula precio de importado");
            precioVenta = (precioCompra * (1 + impuesto)) * 1.30;
        }
        
        // Esta funcion no es virtual en la clase padre, por lo que no se le 
        // puede hacer override, y para hacer una version personalizada se usa
        // new. La desventaja de esto es que se pierde el polimorfismo.
        public new void MuestraVenta()
        {
            Console.WriteLine("El gran producto {0} se vende en ${1}!!!!!", descripcion, precioVenta);
        }
    }
}
