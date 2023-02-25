using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploClase7ListasYmatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //siempre se instancia, el .Add es un metodo de instancia, tiene que haber un objeto para invocarlo, en este caso
            //tiene que estar instanciada la lista duh

            List<string> listaNombres = new List<string>();


            listaNombres.Add("Fede");
            listaNombres.Add("Maria");

            //recorro con forech

            foreach(string nombre in listaNombres)
            {
                Console.WriteLine(nombre);
            }

            //listaNombres.Remove("nombre"); elimina el elemento con el nombre que le pase, reacomoda todo
            //listaNombres.RemoveAt(index); elimina el elemento con el index que le pase, reacomoda todo


            Console.ReadKey();

        }
    }
}
