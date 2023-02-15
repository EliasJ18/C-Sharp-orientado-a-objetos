using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa06_01_Funciones_Virtuales
{
    // "virtual", en una funcion, la convierte en una funcion virtual, lo que
    // significa que las clases hijas (clases que heredan de esta clase) pueden
    // modificarla y usar una version personalizada de dicha funcion.

    internal class CProducto
    {
        private string descripcion;
        protected double precioCompra;
        protected double precioVenta;

        public CProducto(string pDescripcion, double pPrecioCompra)
        {
            descripcion = pDescripcion;
            precioCompra = pPrecioCompra;
            precioVenta = 0.0;
            
        }

        public virtual void CalcularPrecio()
        {
            Console.WriteLine("Calcula precio de producto");
            precioVenta = precioCompra * 1.3;
        }

        public void MuestraVenta()
        {
            Console.WriteLine("{0} se vende en {1}", descripcion, precioVenta);
        }
    }
}
