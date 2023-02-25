using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoVeranoEjercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Pedir fecha (dia, mes y año) de nacimiento al usuario, y con funcion DateTimeNow, conseguir fecha actual,
             *  iterar hasta esa fecha y calcular la cantidad de dias vividos por esa persona, tener
             *  en cuenta si es año bisiesto o no
             */

            Console.Title = "Ejercicio7";
            //int acumuladorAños;
            int arrayLen = 3;
            int[] añoNacimiento = new int[arrayLen];
            //string fechaDateTime;
            int[] fechaActual = new int[3];
            int acumuladorDias;
            int flagBisiesto;
            int difDias = 0; 
            int banderaDifDias;

            //acumuladorAños = 0;
            acumuladorDias = 0;
            banderaDifDias = 0;

            //fechaDateTime = DateTime.Now.Date.ToString("dd/mm/yyyy");

            //Console.WriteLine($"La fecha actual es: {fechaDateTime}");

            fechaActual[0] = 24;
            fechaActual[1] = 1;
            fechaActual[2] = 2022;

            Console.WriteLine("Ingrese su fecha de nacimiento");
            for(int i=0; i<arrayLen; i++)
            {
                switch(i)
                {
                    case 0:
                        do
                        {
                            Console.WriteLine("Dia: ");
                            añoNacimiento[i] = int.Parse(Console.ReadLine());

                            if (añoNacimiento[i] > 0 && añoNacimiento[i] < 32)
                            {
                                break;
                            }

                            Console.WriteLine("Error, el dia debe estar en el rango de 1 a 31, reingrese");

                        } while (true);
                    break;

                    case 1:
                        do
                        {
                            Console.WriteLine("Mes: ");
                            añoNacimiento[i] = int.Parse(Console.ReadLine());

                            if(añoNacimiento[i] > 0 && añoNacimiento[i] < 13)
                            {
                                break;
                            }

                            Console.WriteLine("Error, el mes debe estar en el rango de 1 a 12, reingrese");

                        } while (true);
                    break;

                    case 2:
                        Console.WriteLine("Año: ");
                        añoNacimiento[i] = int.Parse(Console.ReadLine());
                    break;
                }

            }

            //-------------------------------------------------------------------------------


            for(int i=añoNacimiento[2]; i<=fechaActual[2]; i++)
            {
                Console.WriteLine("Entre");
                flagBisiesto = 0;

                if(EsBisiesto(i) == 0)
                {
                    flagBisiesto = 1;
                }

                for(int j=fechaActual[1]; j<=12; j++)
                {
                    Console.WriteLine("Entre 2");
                    switch (j)
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12:

                            if(banderaDifDias == 0)
                            {
                                difDias = 31 - añoNacimiento[0];
                            }

                            acumuladorDias += 31;

                        break;

                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            acumuladorDias += 30;

                            if (banderaDifDias == 0)
                            {
                                difDias = 30 - añoNacimiento[0];
                            }

                        break;

                        default:

                            if(flagBisiesto == 1)
                            {
                                acumuladorDias += 29;
                            }
                            else
                            {
                                acumuladorDias += 28;
                            }

                            if (banderaDifDias == 0)
                            {
                                difDias = 28 - añoNacimiento[0];
                            }

                        break;

                    }

                    banderaDifDias = 1;

                }
            }

            acumuladorDias += difDias;

            Console.WriteLine($"La cantidad de dias que lleva vivo es de: {acumuladorDias}");

            Console.ReadKey();

            // Console.WriteLine($"{añoNacimiento[0]} / {añoNacimiento[1]} / {añoNacimiento[2]}");

            /*if(EsBisiesto(añoNacimiento[2]) == 0)
            {
                Console.WriteLine($"El año {añoNacimiento[2]} es bisiesto");
            }
            else
            {
                Console.WriteLine($"El año {añoNacimiento[2]} no es bisiesto");
            }
            
            fechaActual = fechaDateTime.Split(',');

            resultadoMes = (añoNacimiento[1] - int.Parse(fechaActual[1])) * 30;

            Console.WriteLine($"El resultado dio: {resultadoMes}");

            Console.ReadKey();
            */
        }

        public static int EsBisiesto(int año)
        {
            int ret;

            if(año % 400 == 0)
            {
                ret = 0;
            }
            else
            {
                ret = 0;

                if(!(año % 4 == 0 && año % 100 != 0))
                {
                    ret = -1;
                }
            }
            return ret;
        }
    }
}
