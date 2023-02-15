using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01_05_Accessor_I
{
    internal class CEmpleado
    {
        // El uso de metodos publicos en la clase es una buena forma de
        // hacer que el exterior trabaje con las propiedades sin modificarlas
        // o asignarles valores, en el nombre de dichos metodos ponemos
        // get o set según el trabajo que haga el metodo con la propiedad
        // solo para identificar que tipo de trabajo hace la funcion,
        // pero en sí, la palabra get y set en el nombre de la funcion
        // no se encargan independientemente
        // de definir u obtener el valor de una propiedad, solo es un nombre
        // para identificar lo que hace el metodo.

        private double sueldo;
        private double impuesto;

        public void Muestra()
        {
            Console.WriteLine("Sueldo = {0}, Impuesto = {1}", sueldo, impuesto);
        }

        // Accesor, get y set
        public void set_sueldo(double pSueldo) 
        {
            sueldo = pSueldo;
        }

        public double get_sueldo()
        {
            return sueldo;
        }

        public double get_impuesto()
        {
            return impuesto;
        }

        // Mutator
        // Es una funcion que al llevar a cabo una accion, cambia el
        // estado interno del objeto
        public void CalculaImpuesto()
        {
            impuesto = sueldo * 0.16;
        }

    }
}
