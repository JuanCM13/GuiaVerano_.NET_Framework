using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CentralitaHerencia;

namespace Ejercicio40RepasoVerano
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "RepasoVeranoEjercicio40";

            //Mi central
            Centralita c = new Centralita("Fede Center");

            //Mis 4 Llamadas //el nombre solo con numeros no me lo permite, tengo que si o si agregarle alguna letra al inicio
            Local llamada11 = new Local("Bernal", 30, "Rosario", 2.65F);
            Provincial llamada12 = new Provincial("Moron", Provincial.Franja.Franja_1, 21, "Bernal");
            Local llamada13 = new Local("Lanus", 45, "San Rafael", 1.99F);
            Provincial llamada14 = new Provincial("Palermo", Provincial.Franja.Franja_3, 12, "Recoleta");

            if(c + llamada11 && c + llamada12 && c + llamada13 && c + llamada14)
            {
                Console.WriteLine(c.ToString());
            }

            Console.ReadKey();
        }
    }
}
