using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Biblioteca;

namespace EjercicioMascotas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mascota pepe = new Mascota("Pepe", new DateTime(2020, 10, 11), "Gato");
            Mascota lara = new Mascota("Lara", new DateTime(2010, 05, 22), "Perro");
            Mascota zaira = new Mascota("Zaira", new DateTime(2015, 09, 30), "Loro");

            Console.WriteLine(pepe.MostrarDatos() + $"Edad: {pepe.GetEdad()}");
            Console.WriteLine(lara.MostrarDatos() + $"Edad: {lara.GetEdad()}");
            Console.WriteLine(zaira.MostrarDatos() + $"Edad: {zaira.GetEdad()}");

            Console.ReadKey();
        }
    }
}
