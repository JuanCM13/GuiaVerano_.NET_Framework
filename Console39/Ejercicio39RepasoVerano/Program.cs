using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sobreescrito;
namespace Ejercicio39RepasoVerano
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "RepasoVeranoEjercicio39";
            SobreSobreEscrito n = new SobreSobreEscrito();

            Console.WriteLine(n.MiMetodo());

            Console.ReadKey();
        }
    }
}
