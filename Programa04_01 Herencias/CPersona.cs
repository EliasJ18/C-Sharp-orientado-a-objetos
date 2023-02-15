using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa04_01_Herencias
{
    internal class CPersona
    {
        private string nombre;
        private int edad;
        private string msj;

        public void mensaje()
        {
            msj = "Edad no permitida";

            Console.WriteLine("{0}", msj);
        }

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
                    mensaje();
            }
        }

        public void Muestra()
        {
            Console.WriteLine("{0} tiene {1} años.", nombre, edad);
        }
    }
}
