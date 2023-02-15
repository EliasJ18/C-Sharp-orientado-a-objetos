using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Orientado_a_objetos
{
    internal class Edificio
    {
        private int cantDepto;
        private string propietario;

        public Edificio(int cantDepto, string propietario)
        {
            CantDeptos = cantDepto;
            Propietario = propietario;

            Muestra();
        }

        public int CantDeptos
        {
            get { return cantDepto; }

            set { cantDepto = value; }
        }

        public string Propietario
        {
            get { return propietario; }
            set { propietario = value; }
        }

        public string asignarProp(string prop)
        {
            Propietario = prop;

            return Propietario;
        }

        public int cantDepa(int cant)
        {
            CantDeptos = cant;

            return CantDeptos;
        }

        public void Muestra()
        {
            Console.WriteLine("El edificio cuenta con {0} depto/s y el propietario es {1}.", CantDeptos, Propietario);
        }
    }
}
