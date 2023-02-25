 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace RepasoVeranoEjercicio20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio20RepasoVerano";
            Dolares dol = 35;
            Pesos pes = 2310;
            Pesos pes2 = 350000;
            Euro aux = (Euro)pes2;
            Euro aPesos = 600;
            Pesos cantEnPesos = (Pesos)aPesos;

            
            Dolares a1 = 540;
            Euro a2 = 500;
            Euro a3 = 750;
            Pesos a4 = (Pesos)a3;
            Euro auxResta;

            auxResta = a3 - a1;

            Console.WriteLine("750eu - 540dls da: " + auxResta.GetCantidad());


            if(a3 == a4)
            {
                Console.WriteLine("A3 ES IGUAL A A4");
            }


            Console.WriteLine($"La cantidad de billetes de dol es: {dol.GetCantidad()}");
            Console.WriteLine($"La cantidad de billetes de pes es: {pes.GetCantidad()}");

            if(pes == dol)
            {
                Console.WriteLine($"33 dolares equivalen a 2310");
            }
            else
            {
                Console.WriteLine($"Rompi todo");

            }

            Console.WriteLine($"{pes2.GetCantidad()} Pesos equivalen a: {aux.GetCantidad()} Dolares");
            Console.WriteLine($"{aPesos.GetCantidad()} Euros equivalen a: {cantEnPesos.GetCantidad()} Pesos");

            Console.ReadKey();
        }
    }
}
