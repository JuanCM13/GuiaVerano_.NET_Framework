using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace RepasoVeranoEjercicio33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio33RepasoVerano";

            Libro libro = new Libro();

            libro[0] = "a";
            libro[1] = "b";
            libro[2] = "c";
            libro[3] = "d";
            libro[4] = "e";
            libro[5] = "f";
            libro[1] = "z";
            string aux = libro[1];

            Console.WriteLine(aux);

            Console.ReadKey();

        }
    }
}
