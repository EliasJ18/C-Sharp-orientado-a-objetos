using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01_02_Ambito
{
    internal class CMiClase
    {
        // Estos datos se pueden ver en cualquier lugar de la clase
        // pero no fuera de ella, ambito a nivel objeto (los ambitos a nivel
        // de objeto son conocidos por todo lo de la clase)
        private int b = 10;
        public void Muestra()
        {
            // Creamos una variable local a la funcion Muestra();
            // Ambito a nivel local (los ambitos a nivel local solo son
            // conocidos en el metodo en el cual se definio x cosa)

            // Si tanto en ambito local como ambito de objeto existe 
            // la misma variable (en este caso "b") usamos "this", al hacer
            // uso de this, se toma la variable del ambito de objeto.
            // Si no usamos this, el metodo priorizará la variable en el
            // ambito local.

            // Se recomienda no usar variables de ambito local que se llamen
            // exactamente igual que la variables de ambito de objeto o al reves.
            int m = 5;
            int b = 3;

            // Podemos usar la variable local

            Console.WriteLine("m = {0}", m);

            // Tratamos de mostrar la variable de Main
            // No se puede
            // Console.WriteLine("a = {0}", a);

            // Tratamos de mostrar el dato de la clase
            Console.WriteLine("ambito local b = {0}", b);
            Console.WriteLine("ambito objeto b = {0}", this.b);
        }

        public void Multiplicador()
        {
            // Tratamos de usar la variable de la clase
            b = b * 5;

            // Tratamos de usar la variable local del metodo Muestra()
            // No se puede
            // m = m * 100;
        }
    }
}
