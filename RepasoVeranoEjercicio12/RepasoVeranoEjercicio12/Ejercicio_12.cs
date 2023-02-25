 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ValidacionesEjercicio12;

namespace RepasoVeranoEjercicio12
{
    internal class Ejercicio_12
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio12RepasoVerano";

            char auxResp;
            int num;
            string aux;
            int acum;

            acum = 0;

            do
            {
                do
                {
                    Console.WriteLine("Ingrese un numero entero..");
                    aux = Console.ReadLine();

                    if(int.TryParse(aux , out num))
                    {
                        acum += num;
                        break;
                    }
                    Console.WriteLine("Error, ingrese un numero entero..");

                } while (true);

                Console.WriteLine("Seguimos pa? s/n");
                auxResp = char.Parse(Console.ReadLine());

                if(ValidarRespuesta.validaS_N(auxResp) == false)
                {
                    break;
                }

            } while (true);

            Console.WriteLine($"La suma dio: {acum} \n\n\n-------PROGRAMA FINALIZADO-------");

            Console.ReadKey();
        }
    }
}
