using System;

namespace Programa01_06_Accesors_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos objeto
            CEmpleado Juan = new CEmpleado();

            Juan.set_sueldo(7800);
            Juan.CalculaImpuesto();
            Juan.Muestra();
            Juan.MuestraLog();

            Console.WriteLine("--------------");

            CEmpleado Jose = new CEmpleado();

            Jose.set_sueldo(50000);
            Jose.set_sueldo(25000);
            Jose.set_sueldo(10000);

            Console.WriteLine("El sueldo de Jose es {0}", Jose.get_sueldo(12));

            Jose.Muestra();
            Jose.MuestraLog();
        }
    }
}
