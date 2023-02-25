using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoVeranoEjercicio27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio27RepasoVerano";

            Random numRandom = new Random();
            Stack<int> listaStack = new Stack<int>();
            Queue<int> listaQueue = new Queue<int>();
            List<int> listaList = new List<int>();

            int auxN;

            for(int i=0; i<20; i++)
            {
                auxN = GenerateRandomNumExcluido(numRandom, -2500, 1000, 0);
                listaStack.Push(auxN);
                listaQueue.Enqueue(auxN);
                listaList.Add(auxN);
            }

            Console.WriteLine("\n Lista stack");
            foreach(int num in listaStack)
            {
                Console.WriteLine(" " + num);
            }

            Console.WriteLine("\n Lista Queue");
            foreach (int num in listaQueue)
            {
                Console.WriteLine(" " + num);
            }

            Console.WriteLine("\n Lista List sin ordenar");
            MostrarDataListaInt(listaList, 0);

            listaList.Sort(); // sort ordena de menor a mayor
            listaList.Reverse(); //reverse da vuelta la lista

            Console.WriteLine("\n Lista List positivos de manera decreciente");
            MostrarDataListaInt(listaList, -1);
            
            
            Console.WriteLine("\n Lista List negativos de manera creciente");
            MostrarDataListaInt(listaList, 1);


            Console.ReadKey();
        }

        private static int GenerateRandomNumExcluido(Random numR , int min , int max, int numAexcluir)
        {
            int auxNum = 0;

            if(numR != null)
            {
                do
                {
                    auxNum = numR.Next(min, max);
                    Console.WriteLine("Numero" + auxNum);
                } while (auxNum == numAexcluir);
            }

            return auxNum;
        }
        
        private static void MostrarDataListaInt(List<int> lista , int order)
        {
            if(lista != null && order > -2 && order < 2)
            {

                foreach(int num in lista)
                {
                    if (order == 0 || (order == -1 && num > 0) || (order == 1 && num < 0))
                    {
                        Console.WriteLine(" " + num);
                    }
                } 
            }
        }

    }
}
