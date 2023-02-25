using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoVeranoEjercicio5
{
    internal class Program
    {
        //Ejercicio a terminar, es el ejercicio de los centros numericos, es un re cancer, pensar bien y
        //terminarlo-
        //falta pulir el algoritmo y ver por que compara mal--
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio5";

            int limite;
            string aux;
            int acumuladorUno;
            int acumuladorDos;
            int resta = 0;
            //int auxControlSegundaSuma;

            Console.WriteLine("Ingrese hasta que numero buscamos el/los centros numericos");
            aux = Console.ReadLine();

            if(int.TryParse(aux , out limite))              
            {
                for(int centro=1; centro<=limite; centro++)
                {
                    acumuladorUno = 0;
                    acumuladorDos = 0;

                    for(int j=1; j<centro; j++)
                    {
                      //  Console.WriteLine("Entre..");
                        acumuladorUno += j;
                    }

                    //Console.WriteLine($"Acum1: {acumuladorUno}");

                    for(int i=centro + 1; i<=limite ; i++)
                    {
                        //Console.WriteLine("Entre al segundo..");
                        acumuladorDos += i;
                        //Console.WriteLine($"Acum2: {acumuladorDos}");
                        resta = acumuladorUno - acumuladorDos;

                        if(resta <= 0)
                        {
                            break;
                        }

                    }


                    /*
                    do
                    {
                        auxControlSegundaSuma++;
                        acumuladorDos += auxControlSegundaSuma;

                        resta = acumuladorUno - acumuladorDos;  

                    } while (resta > 0);
                    */

                    if(resta == 0)
                    {
                        Console.WriteLine($"El numero: {centro} es un centro numerico...");
                    }
                    /*else
                    {
                        Console.WriteLine($"El numero: {centro} no es un centro numerico...");
                    }*/
                }
            }
            Console.ReadKey();
        }
    }
}
