using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa02_04_Atributos_Estáticos
{
    internal class CCompu
    {
        // Al declarar estatica una propiedad, el valor que se le asigne 
        // a dicha propiedad será el mismo para todas las instanciaciones.

        private static double tipoCambio;

        private string procesador;
        private int memoria;
        private int costo;

        public CCompu()
        {
            procesador = "i3";
            memoria = 2;
            costo = 350;
        }

        public CCompu(string pProce, int pMem, int pCost)
        {
            procesador= pProce;
            memoria= pMem;
            costo= pCost;
        }

        public double TipoCambio
        {
            set { tipoCambio = value; }
        }

        public void muestraDolares()
        {
            Console.WriteLine("Procesador: {0}, Memoria {1}", procesador, memoria);
            Console.WriteLine("Costo USD: ${0}", costo);
        }

        public void muestraPesos()
        {
            Console.WriteLine("Procesador: {0}, Memoria {1}", procesador, memoria);
            Console.WriteLine("Costo: ${0}, Tipo de cambio: {1}", costo * tipoCambio, tipoCambio);
        }
    }
}
