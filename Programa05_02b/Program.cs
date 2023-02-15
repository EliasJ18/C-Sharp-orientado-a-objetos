using System;

namespace Programa05_02b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos la escuela
            CEscuela miEscuela = new CEscuela("Nicosiored");

            // Creamos los objetos de aula, que existen adentro de escuela
            miEscuela.ColocaAulas();

            // Mostramos al objeto compuesto
            Console.WriteLine(miEscuela);

            // Si eliminamos la instancia no hay forma de tener aulas
            miEscuela = null;
        }
    }
}
