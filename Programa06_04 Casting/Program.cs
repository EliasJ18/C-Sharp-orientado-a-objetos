using System;

namespace Programa06_04_Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Casting nos va a permitir que una clase trabaje como
            // si fuera otra y solo funciona cuando tenemos una cadena de herencia

            // Podemos hacer casting de una clase en la cadena de herencia

            // CProductoImportado es un CProducto

            // La instancia que estamos creando es de tipo CProductoImportado
            // Esto es posible porque producto importado es-un producto
            CProducto p1 = new CProductoImportado("Tele", 2500, 0.15);

            p1.CalcularPrecio();
            Console.WriteLine(p1);

            // No se puede invocar lo que no es comun
            //p1.Mensaje();

            // Esto de aqui es conocido como Type Cast
            ((CProductoImportado)p1).Mensaje();

            Console.WriteLine("---------------");

            // CProducto es un object
            // object es el Supertipo, cualquier clase que se defina desciende
            // de object,
            object p2 = new CProducto("Radio", 300);

            ((CProducto)p2).CalcularPrecio();
            Console.WriteLine(((CProducto)p2));

            Console.WriteLine("-----------------");

            //object no es un CProducto, por eso esto da error
            //CProducto p3 = new object();

            Console.WriteLine("-----Detecta-----");
            CProducto p4 = new CProducto("balon", 250.50);

            Detecta(p1);
            Detecta((CProducto)p4);
            Detecta(p4);

            Console.WriteLine("-------");
            // Casting Numericos

            int a = 57;
            float b = 5.6f;
            double c = 123.456;
            byte x = 5;

            // De un tipo menor a uno mayor no hace falta poner explicitamente
            // el casting porque byte cabe perfecto dentro de int.

            a = x;
            Console.WriteLine(a);

            double y = b;
            Console.WriteLine(y);

            // De un tipo mayor a uno menor si usamos type cast, porque un 
            // double no entra en un float
            // Con esto puede haber perdida de informacion
            b = (float)c;
            Console.WriteLine(b);
        }

        public static void Detecta(CProducto pProducto)
        {
            if (pProducto is CProducto)
            {
                Console.WriteLine("== Es CProducto");
                pProducto.CalcularPrecio();
                Console.WriteLine(pProducto);
            }

            if (pProducto is CProductoImportado)
            {
                Console.WriteLine("== Es CProductoImportado");
                pProducto.CalcularPrecio();
                ((CProductoImportado)pProducto).Mensaje();
                Console.WriteLine(pProducto);
            }
        }
    }
}
