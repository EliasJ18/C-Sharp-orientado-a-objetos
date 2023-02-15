using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa05_02_Composición
{
    internal class CPropietario
    {
        // Composicion: Una escuela tiene muchas aulas, si la escuela deja
        // de existir, las aulas tambien desaparecen. Aulas no tiene una 
        // existencia independiente.

        private string nombre;
        private CEdificio propiedad = null;

        public CPropietario(string pNombre)
        {
            nombre = pNombre;

            // Se está instanciando CEdificio
            // Aqui se hace la composicion porque este objeto de la clase
            // edificio está siendo creado en el ambito que tenemos dentro
            // de esta clase, entonces va a existir como parte de la clase
            // propietario
            propiedad = new CEdificio("Av 2 numero 12", 7, 4);
        }

        public void MostrarPropiedad()
        {
            if (propiedad != null)
            {
                Console.WriteLine("{0} tiene ", nombre);
                propiedad.Muestra();
            }
            else
            {
                Console.WriteLine("{0} aun no tiene propiedades", nombre);
            }
        }
        public void AdicionaPropiedad(CEdificio pEdificio)
        {
            if (pEdificio != null)
                propiedad = pEdificio;

        }

        // Cuidado con esto, rompre el encapsulamiento
        public CEdificio Propiedad
        {
            get { return propiedad; }
            set { propiedad = value; }
        }
    }
}
