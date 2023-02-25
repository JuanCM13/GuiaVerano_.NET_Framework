using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoVeranoEjercicio6
{
    internal class Ejercicio6
    {
        static void Main(string[] args)
        {
            /*
             * Calculadora de años bisiestos, formula:
             * Si el año es divisible por 400 es bisiesto sino, si es divisible por 4 pero no por 400 
             * Tambien es bisiesto, sino no es bisiesto..
             */
            Console.Title = "RepasoVeranoEjercicio6";
            int anio;
            char resp;

            resp = 's';

            do
            {
                Console.WriteLine("Ingrese el año a analizar..");
                anio = int.Parse(Console.ReadLine());

                if (anio % 400 == 0)
                {
                    Console.WriteLine($"El anio {anio} Es bisiesto..");
                }
                else
                {
                    if (anio % 4 == 0 && anio % 100 != 0)
                    {
                        Console.WriteLine($"El anio {anio} Es bisiesto..");
                    }
                    else
                    {
                        Console.WriteLine($"El anio {anio} No es bisiesto..");
                    }
                }

                Console.WriteLine("Desea volver a intentar? s/n");
                resp = char.Parse(Console.ReadLine());

            } while (resp == 's');

            Console.ReadKey();
        }
    }
}
