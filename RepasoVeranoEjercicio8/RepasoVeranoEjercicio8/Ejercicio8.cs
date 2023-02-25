using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoVeranoEjercicio8
{
    struct empleado
    {
        public string nombre;
        public int horasTrabajadaEnElMes;
        public int añosAntiguedad;
        public float totalSueldoSinDescuento;
        public float totalSueldoConDescuento;
    }

    internal class Ejercicio8
    {
        static void Main(string[] args)
        { 
            Console.Title = "Ejercicio8";

            empleado[] arrayEmpleados;
            float valorHora = 0;
            int valorPorAñoTrabajado;
            int i;
            float descuento;
            float auxDescuento;
            int cantEmpleados;


            Console.WriteLine("Ingrese la cantidad de empleados a cargar..");
            cantEmpleados = int.Parse(Console.ReadLine());

            descuento = 13;
            valorPorAñoTrabajado = 150;
            arrayEmpleados = new empleado[cantEmpleados];

            for(i=0; i<cantEmpleados; i++)
            { 
                Console.WriteLine("Ingrese el nombre del empleado..");
                arrayEmpleados[i].nombre = Console.ReadLine();
    
                do
                {
                    Console.WriteLine("Ingrese las horas trabajadas por el empleado (mayor a cero)..");
                    arrayEmpleados[i].horasTrabajadaEnElMes = int.Parse(Console.ReadLine());

                    if (arrayEmpleados[i].horasTrabajadaEnElMes > 0)
                    {
                        break;
                    }

                    Console.WriteLine("Error, debe ser mayor a cero..");

                } while (true) ;

                do
                {
                    Console.WriteLine("Ingrese la antiguedad del empleado en años..");
                    arrayEmpleados[i].añosAntiguedad = int.Parse(Console.ReadLine());

                    if (arrayEmpleados[i].añosAntiguedad > -1)
                    {
                        break;
                    }

                    Console.WriteLine("Error, debe ser mayor o igual a cero..");

                } while (true);

                do
                {
                    Console.WriteLine("Ingrese el valor de la hora trabajada (debe ser mayor a cero)..");
                    valorHora = float.Parse(Console.ReadLine());

                    if (valorHora > 0)
                    {
                        break;
                    }

                    Console.WriteLine("Error, debe ser mayor a cero..");

                } while (true);

                //*****************************fin validaciones

                arrayEmpleados[i].totalSueldoSinDescuento = arrayEmpleados[i].horasTrabajadaEnElMes * valorHora;

                if(arrayEmpleados[i].añosAntiguedad > 0)
                {
                    arrayEmpleados[i].totalSueldoSinDescuento += arrayEmpleados[i].añosAntiguedad * valorPorAñoTrabajado;
                }

                if (descuento > 0)
                {
                    auxDescuento = arrayEmpleados[i].totalSueldoSinDescuento * descuento / 100;
                    arrayEmpleados[i].totalSueldoConDescuento = arrayEmpleados[i].totalSueldoSinDescuento - auxDescuento;
                }

                Console.WriteLine("\n\n----------Cargado----------\n\n");

            }

            PrintEmployees(arrayEmpleados, cantEmpleados, valorHora);

            Console.ReadKey();
        }

        public static int PrintEmployees(empleado[] array , int arrayLen , float valorHora) //nose por que pero si no pongo el static me tira error cs0120
        {
            int ret;
            int i;

            ret = -1;

            for (i = 0; i < arrayLen; i++)
            {
                Console.WriteLine("---------------------------------------------------------------------------------------\n");
                Console.WriteLine($"NOMBRE: {array[i].nombre}\nANTIGUEDAD: {array[i].añosAntiguedad}\nVALOR POR HORA: ${valorHora}\n"+
                    $"TOTAL BRUTO: ${array[i].totalSueldoSinDescuento}\n TOTAL CON DESCUENTO: ${array[i].totalSueldoConDescuento}\n");
            }
            Console.WriteLine("---------------------------------------------------------------------------------------\n");

            return ret;
        }
    }
}
