using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace Ejercicio35RepasoVerano
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "RepasoVeranoEjercicio35";
            DirectorTecnico dt = new DirectorTecnico("Pepee" , new DateTime(1995 , 10 , 12));
            Equipo e = new Equipo(11, "Masticate esta");
            Jugador jUno = new Jugador(40423224 , "Juan" , 10 , 4);
            Jugador jDos = new Jugador(25402365, "Raul" , 11 , 3);

            if(e + jUno && e + jDos)
            {
                Console.WriteLine($"DIRECTOR DATA:{dt.MostrarDatosDirector()}\nDatos Jugador: \n");
                foreach(Jugador aux in e.GetLista())
                {
                    Console.WriteLine($"{aux.MostrarDatosJugador()}");
                }
            }

            Console.ReadKey();

            /*            Console.Title = "Ejercicio32RepasoVerano";
            Equipo eUno = new Equipo(11, "Bocaaaa");
            Jugador jUno = new Jugador(40423224, "Tevez", 5, 10);
            Jugador jDos = new Jugador(40423224, "Riquelme", 6, 15); //dni
            Jugador jTres = new Jugador(40423246, "Gona", 7, 12);
            Jugador jCuatro = new Jugador(40423227, "Tata", 6, 10);
            Jugador jCinco = new Jugador(40423228, "Pepe", 5, 15);
            Jugador jSeis = new Jugador(40423229, "Trunks", 6, 4);
            Jugador jSiete = new Jugador(404232210, "Goku", 6, 15);
            Jugador jOcho = new Jugador(404232211, "Vegeta", 6, 1);
            Jugador jNueve = new Jugador(404232212, "Gohan", 6, 4);
            Jugador jDiez = new Jugador(404232213, "Brolly", 12, 4);

            if (eUno + jUno && eUno + jTres && eUno + jCuatro && eUno + jCinco && eUno + jSeis
                && eUno + jSiete && eUno + jOcho && eUno + jNueve && eUno + jDiez)
            {
                foreach (Jugador jugador in eUno.GetLista())
                {
                    Console.WriteLine(jugador.MostrarDatos());
                }
            }

            if (jDos == jUno) //comparando jugadores no necesariamente en la lista, solo objetos instanciados random
            {
                Console.WriteLine("Funco");
            }
            else
            {
                Console.WriteLine("No funco");
            }


            //ta bien que tire falso por que nunca voy a tener 2 jugadores con el mismo dni, por que en el equipo + jugador filtro eso...
            if (eUno.GetLista().ElementAt(0) == eUno.GetLista().ElementAt(1)) //probando comparar jugadores cargados en la lista de equipo
            {
                Console.WriteLine("Funco");
            }
            else
            {
                Console.WriteLine("No funco");
            }

            Console.ReadKey();
        }*/
        }
    }
}
