using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Validaciones;

namespace RepasoVeranoEjercicio11
{
    internal class Ejercicio11
    {
        static void Main(string[] args)
        {
            int limite;
            int numAvalidar;
            string aux;
            int minimo = 0; //si no las inicializo me tira error, nose que onda
            int maximo = 0;
            float promedio;
            int acumulador;

            limite = 10;
            acumulador = 0;

            Console.WriteLine("Ingrese 10 numeros:");

            for(int i=0; i<limite; i++)
            {
                do
                {
                    Console.WriteLine($"Ingrese un numero, le quedan: {limite - i} numeros por ingresar..");
                    aux = Console.ReadLine();

                    if (int.TryParse(aux, out numAvalidar))
                    {
                        if(Validacion.Validar(numAvalidar , -100 , 100))
                        {
                            acumulador += numAvalidar;

                            if(i==0)
                            {
                                maximo = numAvalidar;
                                minimo = numAvalidar;
                            }
                            else
                            {
                                if(minimo > numAvalidar)
                                {
                                    minimo = numAvalidar;
                                }
                                else
                                {
                                    if(maximo < numAvalidar)
                                    {
                                        maximo = numAvalidar;
                                    }
                                }
                            }

                            break;
                        }

                        Console.WriteLine("Error, El numero ingresado debe estar entre -100 y 100, reintente..");
                    }
                    else
                    {
                        Console.WriteLine("Error, ingrese un numero entero");
                    }

                } while (true);
            }

            Console.WriteLine($"El mayor numero ingresado fue: {maximo}\nEl Menor fue: {minimo}");

            if (limite > 0)
            {
                promedio = acumulador / (float)limite;
                Console.WriteLine($"El promedio fue de: {promedio}\n\n\n------Programa Finalizado------");
            }

            Console.ReadKey();
        }
    }
}
