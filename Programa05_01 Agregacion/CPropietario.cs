using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa05_01_Agregacion
{
    internal class CPropietario
    {
        private string nombre;

        // Agregacion; Una escuela tiene muchos alumnos, pero sin la escuela
        // los alumnos siguen existiendo

        // El atributo propiedad es de tipo CEdificio, es decir que "propiedad"
        // va a poder guardar una referencia a cualquier objeto o instancia declarada en
        // CEdificio y se esta iniciando en null por seguridad.
        // IMPORTANTE: Esto no es una instanciacion de CEdificio dentro de CPropiedad, simplemente
        // se está declarando la propiedad "propiedad" con el tipo CEdificio y de esta forma, mediante
        // "propiedad", se puede acceder a todos los objetos y metodos de la clase CEdificio. Mas claro echale agua.
        private CEdificio propiedad = null;

        public CPropietario(string pNombre)
        {
            nombre = pNombre;
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

        // Este metodo es importante porque nos está permitiendo recibir
        // la referencia de una instancia de tipo CEdificio y colocarlo dentro
        // de la variable de referencia propiedad que tenemos.
        public void AdicionaPropiedad(CEdificio pEdificio)
        {
            if (pEdificio != null)
                propiedad = pEdificio;
            
        }
    }
}
