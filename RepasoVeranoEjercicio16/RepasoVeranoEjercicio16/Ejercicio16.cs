using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Biblioteca;

namespace RepasoVeranoEjercicio16
{
    internal class Ejercicio16
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio16RepasoVerano";

            Alumno aUno = new Alumno("Mendez" , 123456 , "Juan");
            Alumno aDos = new Alumno("Locro", 124581, "Maria"); ;
            Alumno aTres = new Alumno("Perez", 124578, "Pablo");

            aUno.Estudiar(4 , 5);
            aDos.Estudiar(2, 0);
            aTres.Estudiar(9, 5);

            Console.WriteLine(aUno.DevolverDatos());
            Console.WriteLine(aDos.DevolverDatos());
            Console.WriteLine(aTres.DevolverDatos());

            Console.ReadKey();
        }
    }
}
