using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Boligrafo;

namespace RepasoVeranoEjercicio17
{
    internal class Ejercicio17
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio17RepasoVerano";
            Boligrafos uno = new Boligrafos(3, ConsoleColor.Blue);
            Boligrafos dos = new Boligrafos(50, ConsoleColor.Red);
            string cantVeces;
            int tintaRestante;
            bool resultado;

            resultado = uno.Pintar(+4 , out cantVeces);

            if(resultado == true)
            {
                Console.ForegroundColor = uno.GetColor();
                tintaRestante = uno.GetTinta();
                Console.WriteLine($"Resultado: {cantVeces}");
                Console.WriteLine($"Tinta restante: {tintaRestante}");
            }
            else
            {
                Console.WriteLine($"Resultado: {cantVeces}");
            }

            Console.WriteLine("Desea rellenar la tinta?");
            uno.Recargar();
            tintaRestante = uno.GetTinta();
            Console.WriteLine($"Nivel de tinta actual: {tintaRestante}");
            Console.ReadKey();
    }            
    }
}
