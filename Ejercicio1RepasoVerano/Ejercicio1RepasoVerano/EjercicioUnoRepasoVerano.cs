using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1RepasoVerano
{
    internal class EjercicioUnoRepasoVerano
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio001";

            int i;
            int num;
            int tam;
            int maximo = 0;
            int minimo = 0;
            float acumulador;
            float promedio = 0;
            int flag;

            acumulador = 0;
            tam = 10;
            flag = 0;

            for(i=0; i<tam ; i++)
            {
                Console.WriteLine("Ingrese un nuero..");
                num = int.Parse(Console.ReadLine());

                acumulador += num;
                //Console.WriteLine(num);
                if(i==0)
                {
                    minimo = num;
                    maximo = num;
                }
                else
                {
                    if(num < minimo)
                    {
                        minimo = num;
                    }
                    else
                    {
                        if(num > maximo)
                        {
                            maximo = num;
                        }
                    }
                }
            }

            if(tam > 0)
            {
                flag = 1;     
                promedio = acumulador / tam;
            }
            

            Console.WriteLine("El numero mas grande fue: " + maximo);
            Console.WriteLine("El numero mas chico fue: " + minimo);

            if(flag == 1)
            {
                //asi es lo mismo que pomer "" + variable, nomas que de esta forma lo dejo dentro de las comillas
                Console.Write( $"El promedio fue de: {promedio}");
            }
            else
            {
                Console.Write("No se puede calcular el promedio..");
            }

            Console.ReadKey(); 
        }
    }
}
