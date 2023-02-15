using System;

namespace Practica_Orientado_a_objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Edificio ed = new Edificio(5, "Juan Dominguez");

            ed.cantDepa(10);
            ed.asignarProp("Elias");
            ed.Muestra();
        }
    }
}
