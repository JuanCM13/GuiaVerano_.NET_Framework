using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoVeranoEjercicio26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //crear array 20 numeros, mostrarlos como fueron generados, despues los positivos de forma decreciente
            //y los negativos de forma creciente...

            int[] arrayInt = new int[20];
            Random numRandom = new Random();
            int aux;

            for(int i = 0; i< arrayInt.Length; i++)
            {
                do
                {
                    aux = numRandom.Next(-100 , 100);

                } while (aux == 0);

                arrayInt[i] = aux;
            }

            //como se ingresaron..
            MostrarLista(arrayInt , 0);

            //positivos decreciente
            Array.Reverse(arrayInt);
            MostrarLista(arrayInt, 1);

            //negativos decreciente
            Array.Sort(arrayInt);
            MostrarLista(arrayInt, -1);

            Console.ReadKey();
        }
        
        static void MostrarLista(int[] list , int order) //si no lo declaro estatico no me deja invocarlo
        {

            //orden 0 muestra todos, orden -1 muestra solo los negativos , orden 1 muestra solo los positivos..
            if(list != null && order > -2 && order < 2)
            {
                foreach (int num in list)
                {
                    if (order == 0 || (order == 1 && num > 0) || (order == -1 && num < 0))
                    {
                        Console.WriteLine(num);
                    }
                }

                Console.WriteLine("Listortiiii");

            }
            else
            {
                Console.WriteLine("Rompi todo");
            }
        }
    }
}
