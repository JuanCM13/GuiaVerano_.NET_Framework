using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Globalization;

namespace RepasoVeranoEjercicio2
{
    internal class Ejercicio2
    {
        static void Main(string[] args)
        {
            /*
             * Ingresar un numero y mostrar: el cuadrado y el cubo del mismo.Se debe validar que el numero sea mayor que cero
             * caso contrario mostrar el mensaje: "Error, ¡Reingrese el numero!
             * utilizar el metodo Pow de la clase Math para realizar la operacion
             */
            Console.Title = "Ejercicio2Repaso";

            //En C# no hay un signo especifico para hacer la potencia, en js era ^ pero aca en C# hay que usar un metodo especifico de una clase
            //"Math" , donde hay varios metodos matematicos, uno de ellos es pow, que es el de exponentes

            double num;
            double squeare;
            double cube;

            do
            {
                Console.WriteLine("Ingrese un numero mayor a cero, calcularemos el cuadrado y el cubo..");
                num = float.Parse(Console.ReadLine());
                
                if(num > 0)
                {
                    squeare = Math.Pow(num , 2);
                    cube = Math.Pow(num, 3);
                    break;
                }

                Console.WriteLine("ERROR , Reingresa el numero");
                

            }while(true); //no me toma c# el 1 en el while, si o si tengo que clavarle un booleano

            Console.WriteLine($"El numero: {num} Elevado al cuadrado da: {squeare}");
            Console.WriteLine($"El numero: {num} Elevado al cubo da: {cube}");

            Console.ReadKey();
        }
    }
}
