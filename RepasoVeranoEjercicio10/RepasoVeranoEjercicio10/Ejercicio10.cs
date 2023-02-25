using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoVeranoEjercicio10
{
    internal class Ejercicio10
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio10RepasoVerano";

            int alt;
            int auxAlturaGuia = 0; 

            do
            {
                Console.WriteLine("Ingrese la altura");
                alt = int.Parse(Console.ReadLine());

                if(alt > 0)
                {
                    break;
                }
                Console.WriteLine("Error");


            } while (true);


            auxAlturaGuia = alt;
            for(int i=0; i<alt; i++)
            {
                Console.WriteLine("  ");
                auxAlturaGuia--;
                /*
                 * Para imprimir los espacios, se repite el patron de, desde el primero al ultimo, la cantidad de espacios
                 * es la altura -1, en cada vuelta se le resta otro, una torre de 3 escalones:
                 * el primer renglon va a tener 2 espacios (alt -1)
                 * el segundo rengglon va a tener 1 espacio (alt -2)
                 * y el ultimo va a tener 0 espacios (alt -3)
                 */

                for (int z=0; z<auxAlturaGuia; z++)
                {
                    Console.Write(" ");
                }

                for (int j=0; j<=i*2; j++)
                {
                    Console.Write("*");
                }

                Console.Write("\n");
            }

            Console.ReadKey();
        }
    }
}
