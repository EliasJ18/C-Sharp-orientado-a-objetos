using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa02_02_Constructor
{
    internal class CPersona
    {
        private string nombre;
        private int edad;

        // El constructor se llama como la clase, no
        // lleva tipo (void, int, string, etc) y aunque no lo escribamos
        // nosotros, el constructor siempre está aunque no lo veamos.

        
        //public CPersona()
        //{
        //    string tempEdad = "";

        //    Console.WriteLine("Estamos en el constructor");
        //    Console.WriteLine("Dame el nombre");
        //    nombre = Console.ReadLine();
        //    Console.WriteLine("Dame la edad");
        //    tempEdad = Console.ReadLine();
        //    edad = Convert.ToInt32(tempEdad);
        //}
        
        // Un constructor tambien puede recibir parametros
        public CPersona(string pNombre, int pEdad)
        {
            Console.WriteLine("Estamos en el constructor");

            nombre = pNombre;
            edad = pEdad;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            set { edad = value; }
        }

        public void muestra()
        {
            Console.WriteLine("Nombre: {0}, Edad: {1}", nombre, edad);
        }
    }
}
