using System;

namespace Programa02_02_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CPersona p1 = new CPersona("Julian", 21);

            //p1.Nombre = "Julian";
            //p1.Edad = 21;

            p1.muestra();
        }
    }
}
