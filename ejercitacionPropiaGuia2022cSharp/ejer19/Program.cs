using System;

using CuentaDdl;
namespace ejer19
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Primer ejer clase 3, Objetos
            Ejercicio I01 - Creo que necesito un préstamo 
             */
            Console.Title = "Ejer19";
            Cuenta dep1 = new Cuenta("Sol Naciente", 200);


            Console.WriteLine(dep1.Mostrar());

            dep1.Ingresar(250);
            Console.WriteLine(dep1.Mostrar());

            dep1.Retirar(451);
            Console.WriteLine(dep1.Mostrar());

            Console.ReadKey();
        }
    }
}
