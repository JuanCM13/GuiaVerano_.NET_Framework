using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private short cantidadJugadores;
        private List<Jugador> jugadores;
        private string nombreEquipo;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre) : this()
        {
            this.cantidadJugadores = cantidad;
            this.nombreEquipo = nombre;
        }

        public List<Jugador> GetLista()
        {
            return this.jugadores;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            //si la cantidad de jugadores +1 no supera la cantidad de jugadores y el jugador no se encuentra en la lista.. en este orden asi si esta llena
            //la lista, no busca al dope
            if ((e.jugadores.Count() + 1 <= e.cantidadJugadores) && (e.jugadores.Contains(j) == false))
            {
                e.jugadores.Add(j);
                return true;
            }

            return false;
        }
    }
}
