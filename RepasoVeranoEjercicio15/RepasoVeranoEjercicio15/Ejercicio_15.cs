using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CalculadoraEjercicio15;

namespace RepasoVeranoEjercicio15
{
    internal class Ejercicio_15
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio15RepasoVerano";
            float numUno;
            float numDos;
            string aux;
            string auxDos;
            char op;
            float resultado;
            int varControlDivision;

            Console.WriteLine("Ingrese dos numeros:");
            do
            {
                Console.WriteLine("NUM 1:");
                aux = Console.ReadLine();

                Console.WriteLine("NUM 2:");
                auxDos = Console.ReadLine();

                if(float.TryParse(aux , out numUno) && float.TryParse(auxDos, out numDos))
                {
                    Console.WriteLine("Ingrese la operacion: + , - , * , /");
                    op = char.Parse(Console.ReadLine());

                    if(op == '+' || op == '-' || op == '*' || op == '/' )
                    {
                        resultado = Calculador.Calcular(numUno, numDos, op, out varControlDivision);
                        break;
                    }

                    Console.WriteLine("Error, ingrese una de las operaciones mostradas..");

                }
                else
                {
                    Console.WriteLine("Error, solo pueden ingresarse numeros..");
                }

            } while (true);

            if(varControlDivision == 1)
            {
                Console.WriteLine($"El resultado de la operacion: {numUno} {op} {numDos} es: {resultado}..");
            }
            else
            {
                Console.WriteLine("Error, no puede dividirse por 0, reintente..");
            }
            Console.ReadKey();
        }
    }
}
