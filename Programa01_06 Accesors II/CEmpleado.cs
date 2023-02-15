using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01_06_Accesors_II
{
    internal class CEmpleado
    {
        private double sueldo;
        private double impuesto;
        private string log;

        public void Muestra()
        {
            Console.WriteLine("Sueldo = {0}, Impuesto = {1}", sueldo, impuesto);
        }

        // Accesor, get y set
        public void set_sueldo(double pSueldo) 
        {
            if (pSueldo < 5000 || pSueldo > 15000)
                LogError("Sueldo Ilegal " + pSueldo.ToString());
            else
                sueldo = pSueldo;
        }

        public double get_sueldo(int pPassword)
        {
            if (pPassword != 12345)
            {
                LogError("Password Ilegal");
                return 0.0;
            } else
            {
                return sueldo;
            }
        }

        public double get_impuesto(int pPassword)
        {
            if (pPassword != 12345)
            {
                LogError("Password Ilegal");
                return 0.0;
            }
            else
            {
                return impuesto;
            }
        }

        // Mutator
        // Es una funcion que al llevar a cabo una accion, cambia el
        // estado interno del objeto
        public void CalculaImpuesto()
        {
            impuesto = sueldo * 0.16;
        }

        private void LogError(string pError)
        {
            log += pError + "\r\n";
        }

        public void MuestraLog()
        {
            Console.WriteLine(log);
        }
    }
}
