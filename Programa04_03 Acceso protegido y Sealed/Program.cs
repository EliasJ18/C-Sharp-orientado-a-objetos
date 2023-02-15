using System;

namespace Programa04_03_Acceso_protegido_y_Sealed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CEmpleado uno = new CEmpleado("Susana", 35, "Programadora", 150000);
            uno.empleadoMuestra();
            Console.WriteLine("---------");


            // A su vez, usar protected puede romper la encapsulacion de datos
            // demostranto esto en la siguiente linea de código;
            // Al ejecutarse, ya no se evalua la condicion de if else de la
            // propiedad Edad en la clase CPersona.
            uno.Edad = 35;

            // uno.ponerDatos("Susana", 23, "Programadora Senior", 180000.70);

            uno.empleadoMuestra();
        }
    }
}
