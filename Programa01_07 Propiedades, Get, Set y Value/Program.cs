using System;

namespace Programa01_07_Propiedades__Get__Set_y_Value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos objeto
            CEmpleado Juan = new CEmpleado();

            Juan.Sueldo = 1500;
            Juan.CalculaImpuesto();

            Console.WriteLine("El impuesto de Juan es {0}", Juan.Impuesto);

            Juan.Muestra();
        }
    }
}
