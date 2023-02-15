using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa02_03_Destructor_Y_Sobrecarga_de_Constructor
{
    internal class CPersona
    {
        // La sobrecarga de constructores funciona exactamente igual que la 
        // sobrecarga de métodos, se pueden usar diferentes versiones de 
        // constructores y el programa elegirá ejecutar el conveniente 

        private string nombre;
        private int edad;

        public CPersona()
        {
            string tempEdad = "";

            Console.WriteLine("Estamos en el constructor");
            Console.WriteLine("Dame el nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Dame la edad");
            tempEdad = Console.ReadLine();
            edad = Convert.ToInt32(tempEdad);
        }

        // Sobrecarga
        public CPersona(string pNombre, int pEdad)
        {
            Console.WriteLine("Estamos en el constructor");

            nombre = pNombre;
            edad = pEdad;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            set { edad = value; }
        }

        public void muestra()
        {
            Console.WriteLine("Nombre: {0}, Edad: {1}", nombre, edad);
        }

        // Destructor
        // El destructor no recibe parametros, ni tipos de datos ni nada
        // Solo sirve para limpiar los datos, liberar memoria, cerrar archivos,
        // limpiar los valores de las variables, etc.
        ~CPersona()
        {
            Console.WriteLine("Adios desde {0}", nombre);
            // Limpiamos informacion
            nombre = "";
            edad = 0;
        }
    }
}
