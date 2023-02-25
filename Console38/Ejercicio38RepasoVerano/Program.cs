using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sobreescrito;

namespace Ejercicio38RepasoVerano
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "RepasoVeranoEjercicio38";
            ClassSobreescrito sobreCarga = new ClassSobreescrito();

            Console.WriteLine(sobreCarga.ToString());
            ClassSobreescrito objPrueba = new ClassSobreescrito();
            string objeto = "¡ESTE ES MI METODO ToString SOBREESCRITO";
           
            Console.WriteLine("-------------------------------------------------------");
            
            Console.WriteLine("Comparacion Sobrecargas con string: ");
            Console.WriteLine(sobreCarga.Equals(objPrueba));
            Console.WriteLine(sobreCarga.Equals(objeto));

            Console.WriteLine("-------------------------------------------------------");
            
            Console.WriteLine(sobreCarga.GetHashCode());

            Console.ReadKey();
        }
    }
}
