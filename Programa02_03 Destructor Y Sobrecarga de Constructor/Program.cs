using System;
using System.Security.Cryptography;

namespace Programa02_03_Destructor_Y_Sobrecarga_de_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CPersona p1 = new CPersona();

            CPersona p2 = new CPersona("Juan", 20);

            p1.muestra();
            p2.muestra();

            
        }
    }
}
