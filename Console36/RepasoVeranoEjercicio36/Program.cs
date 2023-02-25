using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
namespace RepasoVeranoEjercicio36
{
    internal class Program
    {
        /*
         Bueno por que no me voy a acordar un choto lo que hice lo anoto:

        Agarramos el ejercicio 30, agregamos la clase VehiculoTerrestre y la hicimos clase base, volcamos la data compartida de auto
        y la clase creada nueva, motocross, las heredamos. Tuvimos que agregar propiedades, sacar metodos al dope.
        y modificar la igualdad entre Competencia == Vehiculo. Ahora retorna true si ademas de no estar en la lista ya cargado
        si el objeto vehiculo coincide con el tipo de vehiculo del objeto Competencia.

        Los metodos MostrarDatos no supe como reformarlos, tuve que crear metodos especificos para auto y moto y concatenarlos
        con la info general de MostrarDatos que heredan de la clase vehiculo.
        */


        static void Main(string[] args)
        {
            Console.Title = "Ejercicio36RepasoVerano";
            Competencia com = new Competencia(10, 11 , Competencia.TipoCompetencia.MotoCross);
            AutoF1 a1 = new AutoF1(1, "Ferrari", 620);
            AutoF1 a2 = new AutoF1(2, "Mercedes", 650);
            AutoF1 a3 = new AutoF1(3, "Red Bull" , 600);
            //Competencia com2 = new Competencia(52, 5, Competencia.TipoCompetencia.MotoCross);
            MotoCross m1 = new MotoCross(25, "Yamaha", 455);
            MotoCross m2 = new MotoCross(14, "Honda", 500);
            MotoCross m3 = new MotoCross(188, "Ducati", 555);


            if (com + m1 && com + m2 && com + m3/*com + a1 && com + a2 && com + a3 && com + m1*/)
            {
                for(int i=0; i<com.Competidores.Count(); i++)
                {
                    if(i == 0)
                    {
                        Console.WriteLine(com.MostrarDatos());
                    }

                    if(com[i] is MotoCross)
                    {
                        MotoCross aux = (MotoCross) com[i];
                        Console.WriteLine(aux.MostrarDatosMoto());
                    }
                    else
                    {
                        AutoF1 auxA = (AutoF1)com[i];
                        Console.WriteLine(auxA.MostrarDatosAuto());
                    }
                }
            }
            Console.ReadKey();

        }
    }
}
