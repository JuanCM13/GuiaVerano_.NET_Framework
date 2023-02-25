using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace RepasoVeranoEjercicio31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ejercicio31RepasoVerano";

            Negocio newNegocio = new Negocio("Churreria");
            Cliente c1 = new Cliente(1 , "jorge");
            Cliente c2 = new Cliente(2, "pepe");
            Cliente c3 = new Cliente(3, "marito");
            Cliente c4 = new Cliente(4, "raul");
            Cliente c5 = new Cliente(5, "rolando");

            if(newNegocio + c1 && newNegocio + c2 && newNegocio + c3 && newNegocio + c4 && newNegocio + c5)
            {
                int largo = newNegocio.ListaClientes.Count;
                for (int i=0; i<largo; i++)
                {
                    if(~newNegocio)
                    {
                        Console.WriteLine($"{newNegocio.GetData()}Estado:Atendido");
                        Console.WriteLine("Para atender al proximo cliente ingrese s");
                        if(Console.ReadLine() != "s")
                        {
                            break;
                        }
                    }
                    Console.WriteLine("---El Cliente esta siendo atendido, aguarde...");
                }

                Console.WriteLine("Programa finalizado..");
            }

            Console.ReadKey();
        }
    }
}
