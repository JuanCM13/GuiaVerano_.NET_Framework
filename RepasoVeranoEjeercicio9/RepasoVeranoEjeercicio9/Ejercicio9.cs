using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoVeranoEjeercicio9
{
    internal class Ejercicio9
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio9RepasoVerano";

            //Escribir programa que imprima por pantalla una piramide como la siguiente:
            /*
             *      *
             *      ***
             *      *****
             *      *******
             *      *********
             *      La altura la elige el usuario..
             */

            int altura;
            //int cant;

            do
            {
                Console.WriteLine("Ingrese la cantidad de escalones que tendra la piramide.. (mayor a cero)");
                altura = int.Parse(Console.ReadLine());

                if(altura > 0)
                {
                    break;
                }

                Console.WriteLine("Error, reingrese");

            } while (true);

            for(int i=0; i<altura; i++)
            {
                for(int b=0; b<=i*2 ; b++)
                {
                    Console.Write("*");
                    
                  /*  if (i == 0) no hace falta esto, total en el primer caso 0*2 sigue siendo 0 y por eso si o si tengo que 
                    {                   ponerle el b <= i*2 sino en el primer caso no entraria, 0 no es menor a 0
                        break;
                    }*/

                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();

        }
    }
}
