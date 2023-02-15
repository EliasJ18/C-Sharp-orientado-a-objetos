using System;

namespace Programa05_01_Agregacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo de agregacion

            // Creamos al propietario

            CPropietario Juan = new CPropietario("Juan");

            // Creamos la propiedad

            CEdificio edif1 = new CEdificio("Av. 1 num 56", 10, 3);

            // Vemos info del propietario

            Juan.MostrarPropiedad();

            // Le colocamos la propiedad

            Juan.AdicionaPropiedad(edif1);
            Juan.MostrarPropiedad();


            // A continuacion se borrará a Juan, esto no se recomienda hacerlo porque no es la manera correcta
            // de eliminar cosas, solo se muestra con fines de aprendizaje

            // Eliminamos a Juan
            Juan = null;
            GC.Collect();
            // Si ejecutamos el metodo MostrarPropiedad de la clase CPropietario, dará error ya que el objeto Juan fue borrado 
            // Juan.MostrarPropiedad();

            Console.WriteLine("------------------");

            // Verificamos que el edificio exista independiente de Juan
            edif1.Muestra();

        }
    }
}
