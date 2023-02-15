using System;

namespace Programa01_04_Metodos_Privados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos instancia
            CCalculadora calcu1 = new CCalculadora();

            // Accedemos a los atributos para colocar informacion
            calcu1.a = 5;
            calcu1.b = 3;

            // Intentamos invocar al metodo privado
            // No se puede porque es privado en su clase.
            // calcu1.Muestra();

            // Invocamos metodo
            calcu1.Suma();
        }
    }
}
