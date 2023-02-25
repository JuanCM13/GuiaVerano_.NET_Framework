using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MedidoresTemperatura;

namespace RepasoVeranoEjercicio21
{
    internal class Ejercicio_21
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio21RepasoVerano";

            Celsius auxC = 100;
            Fahrenheit auxF2 = 211.25;

            //NOTA IMPORTANTE: ser preciso con los decimales, que al momento de convertir, dada la presision de dcecimales,
            //Al momento de comparar por ==, como lo redondeo capaz 100C comparado con 211 no da 100 grados C sino que tengo que
            //poner 211.25 y ahi si redondea a 100, sino da 99.44448457454 y lo redondea para abajo (99)

            Console.WriteLine($"100º C a Kelvin son: {auxF2.getCantidad()} Fahrenheit");

            if(auxC == auxF2)
            {
                Console.WriteLine("Entre");
            }

            /*Celsius aux = auxC - auxK;
            Console.WriteLine($"25C - 288.15K da: {aux.getCantidad().ToString("#,###.00")} Fahrenheit");*/

            Console.ReadKey();
        }
    }
}
