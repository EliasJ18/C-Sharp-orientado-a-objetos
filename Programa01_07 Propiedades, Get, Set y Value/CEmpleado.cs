using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01_07_Propiedades__Get__Set_y_Value
{
    internal class CEmpleado
    {
        private double sueldo;
        private double impuesto;
        

        public void Muestra()
        {
            Console.WriteLine("Sueldo = {0}, Impuesto = {1}", sueldo, impuesto);
        }

        // Si solo queremos mostrar datos o asignar datos de atributos
        // este es el mejor modo, evitando asi crear funciones

        public double Sueldo
        {
            // Get nos permite sacar informacion al exterior aunque
            // sea un atributo privado
            // Get siempre debe tener un return/retornar algo.
            get { return sueldo; } 

            // Set nos permite colocar informacion en el interior del objeto
            // Value se ingresa como parametro brindado por c#
            // Tambien es posible escribir mas codigo.
            set 
            {
                if (sueldo > 15000)
                    sueldo = value;
                else
                    sueldo = 3000;
            }
        }

        public double Impuesto
        {
            get { return impuesto; }
        }

        public void CalculaImpuesto()
        {
            impuesto = sueldo * 0.16;
        }
    }
}
