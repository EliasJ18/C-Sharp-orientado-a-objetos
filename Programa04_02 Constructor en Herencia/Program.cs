using System;

namespace Programa04_02_Constructor_en_Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos objeto de la clase persona
            CPersona uno = new CPersona("María", 27);

            uno.Muestra();
            Console.WriteLine("-------------------");

            // Creamos objeto de la clase empleado
            CEmpleado dos = new CEmpleado("Juan", 30, "Contador", 10500.50);

            // Usamos el muestra de empleado
            dos.empleadoMuestra();

            Console.WriteLine("-----------------------");

            // Creamos otro empleado

            CEmpleado tres = new CEmpleado("Susana", 25, "Programadora", 150000.30);
            tres.empleadoMuestra();
            Console.WriteLine("-----------------------");
            tres.ponerDatos("Julio", 23, "Programador senior", 180000.70);

            tres.empleadoMuestra();
        }
    }
}
