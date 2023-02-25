using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoVeranoEjercicio3
{
    internal class Ejercicio3
    {
        /*
         * Mostrar por pantalla todos los numeros primos que haya hasta el numero que ingrese el usuario
         * por console, usar estructuras repetitivas, selectivas y la funcion modulo %
         */
        static void Main(string[] args)
        {
            Console.Title = "EjercicioGuiaVerano3";
            int num;
            int counter;
            char resp;

            resp = 's';

            do
            {
                counter = 0;
                Console.WriteLine("Ingrese un numero y veremos si es primo..");
                num = int.Parse(Console.ReadLine());

                for (int i = num; i > 1; i--)
                {
                    if (num % i == 0)
                    {
                        counter++;
                    }
                }

                if (counter == 1)
                {
                    Console.WriteLine($"El numero {num} es primo");
                }
                else
                {
                    Console.WriteLine($"El numero {num} no es primo");
                }

                Console.WriteLine("Volvemos a probar otro? s/n");
                resp = char.Parse(Console.ReadLine());

            } while (resp == 's');

            Console.ReadKey();
        }
    }
}
