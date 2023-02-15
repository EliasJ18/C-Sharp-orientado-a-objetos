using System;

namespace Programa01_03
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

            // Intento acceder al dato privado
            // No se puede porque es un atributo privado en su clase.
            // Console.WriteLine(calcu1.r);

            // Mostramos los datos
            calcu1.muestra();

            // Invocamos metodo
            calcu1.suma();

            // Mostramos nuevamente los datos
            calcu1.muestra();

            //--------------
            Console.WriteLine("-----------------");

            // Creamos otra instancia de CCalculadora
            CCalculadora calcu2 = new CCalculadora();

            calcu2.a = 6;
            calcu2.b = 10;
            calcu2.suma();

            // Comprobamos que cada objeto tiene su propia informacion

            calcu1.muestra();
            calcu2.muestra();
        }
    }
}
