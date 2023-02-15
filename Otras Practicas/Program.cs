using System;

namespace Otras_Practicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad = 0;

            Console.WriteLine("ingrese su edad");
            edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tu edad es {0}", edad);

        }
    }
}
