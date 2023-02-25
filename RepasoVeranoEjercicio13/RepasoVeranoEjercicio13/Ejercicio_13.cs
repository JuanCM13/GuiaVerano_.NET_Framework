using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConversorEjercicio13;


namespace RepasoVeranoEjercicio13
{

    //------********** TIENE AGRAGADO EL EJERCICIO 22 DEL SOBRECARGA DE OPERADORES Y METODOS. ************----------------




    //Ejercicio a terminar, hacer una clase llamada conversor, que tiene 2 metodos, 1 conversor de decimal a decimal
    //y otro que sea pasar de binario a decimal
    /*
     *  Podria hacer el conversor de d a binario algo asi:
     *  devuelve un arrayDeRetorno de int , y dentro hago un loop, consiguiendo el resto dividiendo x 2, y un array de int aux le asigno ese resto( 0 o 1)
     *  Como tengo que formarlo leyendo de arriba a abajo (acordarse como calcularlo en el ingreso (dividiendo x 2))
     *  Podria despues ese array recorrerlo de abajo a arriba y asignarle al arrayDeRetorno cada posision:
     *  
     *  Array;       arrayRetorno
     *  0            5
     *  1            4
     *  2            3
     *  3            2
     *  4            1
     *  5            0
     *  
     */
    internal class Ejercicio_13
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio13RepasoVerano";

            NumeroDecimal nD = 250;
            NumeroBinario nB = "11111001";
            NumeroDecimal aux = (NumeroDecimal)nB;

            Console.WriteLine($"{nB.numero}");

            if (nD == nB)
            {
                Console.WriteLine("all good hommie");

            }
            else
            {
                Console.WriteLine("Shhheeeeit");
                string resultado = nB - nD;
                Console.WriteLine($"Resultado de la suma de {nD.numero} + {nB.numero} (255) dio: {resultado}");
                Console.WriteLine($"11111111 a decimal da {aux.numero}");
            }

            /*int num;
            string resultadoDaB;
            int resultadoBaD;
            int option;
            string aux;
            string auxDos;

            do
            {
                Console.WriteLine("Que operacion desea realizar?\n1.Decimal a Binario\n2.Binario a Decimal");
                aux = Console.ReadLine();

                if(int.TryParse(aux , out option) && option == 1 || option == 2)
                {
                    break;
                }
                Console.WriteLine("Error, reingrese");

            } while (true);

            if(option == 1)
            {
                do
                {
                    Console.WriteLine("Ingrese un numero entero, la calculadora solo va a representar numeros hasta el 255");
                    auxDos = Console.ReadLine();

                    if (int.TryParse(auxDos, out num))
                    {
                        if (num > 0 && num < 256)
                        {
                            break;
                        }

                        Console.WriteLine("Error, ingrese un numero entre 0 y 255..");
                    }
                    else
                    {
                        Console.WriteLine("Error, ingrese un numero entero..");
                    }

                } while (true);

                resultadoDaB = Conversor.ConversorD_B(num);
                Console.WriteLine($"El numero {num} pasado a binario da: {resultadoDaB}..");
            }
            else
            {
                do
                {
                    Console.WriteLine("Ingrese el numero binario a convertir");
                    auxDos = Console.ReadLine();

                    if(Conversor.Esbinario(auxDos))
                    {
                        break;
                    }
                    Console.WriteLine("Error, un num binario solo esta compuesto por 1 y 0, reingrese");

                } while (true);

                resultadoBaD = Conversor.ConversorB_D(auxDos);

                Console.WriteLine($"El numero {auxDos} pasado a binario da: {resultadoBaD}..");
            }

            Console.ReadKey();*/

            Console.ReadKey();
        }


    }
}
