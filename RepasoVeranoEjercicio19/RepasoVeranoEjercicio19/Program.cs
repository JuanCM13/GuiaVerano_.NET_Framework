using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace RepasoVeranoEjercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador newSuma = new Sumador(15);
            Sumador segundaSuma = new Sumador(17);
            Sumador pruebaConstructorPorDefecto = new Sumador();
            int cantSumas;
            int operacionLong;
            string operacionConcatenado;
            long sumaDos;


            cantSumas = newSuma.getSumas();
            Console.WriteLine($"La cantidad de sumas es de: {cantSumas}");

            operacionLong = (int) newSuma.Sumar(16, 12);
            cantSumas = newSuma.getSumas();
            Console.WriteLine($"Ahora la cantidad de sumas es de: {cantSumas} y el resultado de 16 + 12 dio: {operacionLong}");

            operacionConcatenado = newSuma.Sumar("pito", "corto");
            cantSumas = newSuma.getSumas();
            Console.WriteLine($"Ahora la cantidad de sumas es de: {cantSumas} y el resultado del string dio {operacionConcatenado}");

            cantSumas = (int)pruebaConstructorPorDefecto;
            Console.WriteLine($"La cantidad de sumas del tercer sumador, construido con constructor por defecto es: {cantSumas}");


            //---------------------------------------- probando castings sobrecargados

            cantSumas = (int) newSuma;
            Console.WriteLine($"Cant sumas en la prueba de conversiones dio: {cantSumas}");

            sumaDos =  newSuma + segundaSuma;
            Console.WriteLine($"La suma de ambos objetos con el operador sobrecargado + dio: {sumaDos}");

            if(newSuma | segundaSuma)
            {
                Console.WriteLine("La cantidad de sumas de ambos objetos es igual..");
            }
            else
            {
                Console.WriteLine("La cantidad de sumas de ambos objetos NO es igual..");
            }


            Console.ReadKey();
        } 
    }
}
