using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa04_03_Acceso_protegido_y_Sealed
{
    sealed internal class CEmpleado:CPersona
    {
        private string puesto;
        private double salario;

        public CEmpleado(string pNombre, int pEdad, string pPuesto, double pSalario)
            : base(pNombre, pEdad)
        {
            Console.WriteLine("Constructor Empleado");
            puesto = pPuesto;
            salario = pSalario;
        }

        public string Puesto
        {
            set { puesto = value; }
        }

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public void ponerDatos(string pNom, int pEdad, string pPuesto, double pSalario)
        {
            //Nombre = pNom; // Ojo, nos muestra la propiedad de CPersona, no el atributo
            //Edad = pEdad;

            nombre = pNom;  // Ahora si podemos usar directamente las propiedades
            edad = pEdad;   // por usar en ellas protected en la clase padre

            puesto = pPuesto;
            salario = pSalario;
        }

        public void empleadoMuestra()
        {
            Muestra();
            Console.WriteLine("Trabaja de {0} con sueldo de ${1}", puesto, salario);
        }
    }
}
