using System;

namespace Programa01_02_Ambito
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Esta variable solo se conoce en Main
            int a = 5;

            a = a * 5;
            Console.WriteLine("a = {0}",a);

            // Tratamos de usar el dato directamente de la clase
            // No se puede
            // b = 10;
            // Console.WriteLine("b = {0}, b");

            // Ahora instanciamos la clase
            CMiClase objeto = new CMiClase();

            objeto.Muestra();
            objeto.Multiplicador();
            objeto.Muestra();
        }
    }
}
