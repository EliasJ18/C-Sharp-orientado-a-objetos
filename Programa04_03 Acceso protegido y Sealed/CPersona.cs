using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa04_03_Acceso_protegido_y_Sealed
{
    internal class CPersona
    {
        // Usar protected en las propiedades hace que SOLO LAS CLASES HEREDADAS
        // puedan acceder a ellas.

        public CPersona(string pNombre, int pEdad)
        {
            Console.WriteLine("Constructor de persona");
            nombre = pNombre;
            edad = pEdad;
        }

        protected string nombre;
        protected int edad; 

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }

            set
            {
                edad = value;

                if (value >= 18)
                    edad = value;
                else
                {
                    edad = -1;
                    Console.WriteLine("Edad inválida");
                }
            }
        }

        public void Muestra()
        {
            Console.WriteLine("{0} tiene {1} años.", nombre, edad);
        }
    }
}
