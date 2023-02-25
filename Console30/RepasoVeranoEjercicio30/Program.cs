using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidadess;
namespace RepasoVeranoEjercicio30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            Console.Title = "Ejercicio30RepasoVerano";
            Competencia com = new Competencia(10, 5);
            AutoF1 a1 = new AutoF1(1, "Ferrari");
            AutoF1 a2 = new AutoF1(2, "Mercedes");
            AutoF1 a3 = new AutoF1(3, "Red Bull");
            AutoF1 a4 = new AutoF1(4, "Mc Laren");
            AutoF1 a5 = new AutoF1(5, "Renault");
            AutoF1 a6 = new AutoF1(3, "Red Bull");

            if(com + a1 && com + a2 && com + a3 && com + a4 && com + a5/* && com + a6*/)
            {
                foreach (AutoF1 aux in com.GetList())
                {
                    if (counter == 0)
                    {
                        //apenas entra imprimo la info de la compe
                        Console.WriteLine($"Datos Carrera: \n\n{com.MostrarData()}");
                    }
                    counter=1;
                    Console.WriteLine($"--CORREDOR {counter} --\n\n{aux.MostrarDatos()}");
                    
                }
            }
            else
            {
                Console.WriteLine("La lista ya esta llena, el 6 fletalo");
            }

            Console.ReadKey();

        }
    }
}
