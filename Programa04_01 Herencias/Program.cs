using System;

namespace Programa04_01_Herencias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos objeto de la clase persona
            CPersona uno = new CPersona();

            uno.Nombre = "Maria";
            uno.Edad = 27;

            uno.Muestra();
            Console.WriteLine("-------------------");

            // Creamos objeto de la clase empleado
            CEmpleado dos = new CEmpleado();

            // Colocamos la informacion usando las propiedades de su clase base
            dos.Nombre = "Julian";
            dos.Edad = 28;

            dos.Puesto = "Contador";
            dos.Salario = 10500.50;

            // Usamos el muestra de empleado
            dos.empleadoMuestra();

            // Verificamos que podemos usar el muestra() de la clase base CPersona
            dos.Muestra();

            Console.WriteLine("-----------------------");

            // Creamos otro empleado

            CEmpleado tres = new CEmpleado();

            tres.ponerDatos("Julio", 25, "Programador", 150000.30);

            tres.empleadoMuestra();
        }
    }
}
