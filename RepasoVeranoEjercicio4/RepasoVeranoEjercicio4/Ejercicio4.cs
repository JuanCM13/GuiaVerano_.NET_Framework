using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoVeranoEjercicio4
{
    internal class Ejercicio4
    {
        static void Main(string[] args)
        {
            /*
             *Un numero perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos
             *excluido el mismo que son divisores del numero.
             *El primer numero perfecto es 6 ya que, sus divisores son 1,2 y 3, y estos sumados dan 6
             *Hacer una app que encuentre los primeros 4 numeros perfectos.
             *Usar estructuras repetitivas y selectivas.
             */

            Console.Title = "Ejercicio4RepasoVerano";
            int acumulador;
            int contNumero;
            int contadorPerfectos;
            //int numeroPerfecto;

            contadorPerfectos = 0;
            contNumero = 1;

            do
            {
                acumulador = 0;
                
                for(int i=1; i<contNumero; i++) //hasta 1, por quetodos los nums son divisibles por 1
                {
                    if(contNumero % i == 0)
                    {
                        //Console.WriteLine($"Entre {contNumero} sobre {i} es divisible..");
                        acumulador += i;
                    }
                }

                if(acumulador == contNumero)
                {
                    Console.WriteLine($"El numero {contNumero} es perfecto..");
                    contadorPerfectos++;
                }

                contNumero++;

            } while (contadorPerfectos != 4);

            Console.WriteLine("Programa Finalizado");
            Console.ReadKey();

        }
    }
}
