using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AreaEjercicio14;

namespace RepasoVeranoEjercicio14
{
    internal class Ejercicio14
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio13RepasoVerano";

            int option;
            string aux;
            string auxDos;
            double datoUno;
            double datoDos;
            double resultado = 0;
            int flagControl;

            flagControl = 0;

            do
            {
                Console.WriteLine("Ingrese el tipo de figura cuya area desea calcular:\n1.Cuadrado\n2.Triangulo\n3.Circulo");
                aux = Console.ReadLine();

                if(int.TryParse(aux , out option) && option > 0 && option < 4)
                {
                    switch(option)
                    {
                        case 1:

                            Console.WriteLine("Ingrese la longitud de uno de los lados del cuadrado..");
                            aux = Console.ReadLine();

                            if(double.TryParse(aux , out datoUno))
                            {
                                flagControl = 1;
                                resultado = CalculoDeArea.CalcularCuadrado(datoUno);
                            }

                        break;
                        case 2:

                            Console.WriteLine("Ingrese el largo de la base..");
                            aux = Console.ReadLine();

                            Console.WriteLine("Ingrese la altura del triangulo..");
                            auxDos = Console.ReadLine();

                            if (double.TryParse(aux, out datoUno) && double.TryParse(auxDos, out datoDos) )
                            {
                                flagControl = 1;
                                resultado = CalculoDeArea.CalcularTriangulo(datoUno , datoDos);
                            }

                        break;
                        case 3:
                            Console.WriteLine("Ingrese el radio del circulo..");
                            aux = Console.ReadLine();

                            if (double.TryParse(aux, out datoUno))
                            {
                                flagControl = 1;
                                resultado = CalculoDeArea.CalcularCirculo(datoUno);
                            }

                        break;
                    }

                    if (flagControl == 1)
                    {
                        break;
                    }

                    Console.WriteLine("Error, todos los datos ingresados deben ser numeros con coma.. ej: 2,45");

                }
                else
                {
                    Console.WriteLine("Error, ingrese una opcion entre las dadas..");
                }

            } while (true);

            Console.WriteLine($"El valor del area es: {resultado}");
            Console.ReadKey();
        }
    }
}
