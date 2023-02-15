using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa04_03_Acceso_protegido_y_Sealed
{
    // La clase becario no puede heredar de la clase empleado porque empleado
    // esta usando "sealed" lo que no permite que sea clase padre de ninguna clase
    // internal class CBecario:CEmpleado

    // CBecario si puede heredar de la clase CPersona porque esa clase no esta
    // haciendo uso de sealed a diferencia de CEmpleado
    internal class CBecario:CPersona
    {
        private int horasBeca;

        public CBecario(string pNombre, int pEdad, int pHoras)
            :base(pNombre, pEdad)
        {
            horasBeca = pHoras;
        }
        public int HorasBeca
        {
            get { return horasBeca; }
            set { horasBeca = value; }
        }

        public void muestraBecario()
        {
            Console.WriteLine("Cantidad de horas: {0}", horasBeca);
        }
    }
}
