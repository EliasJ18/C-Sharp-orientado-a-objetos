using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa04_02_Constructor_en_Herencia
{
    internal class CPersona
    {
        public CPersona(string pNombre, int pEdad)
        {
            Console.WriteLine("Constructor de persona");
            nombre = pNombre;
            edad = pEdad;
        }

        private string nombre;
        private int edad;

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

