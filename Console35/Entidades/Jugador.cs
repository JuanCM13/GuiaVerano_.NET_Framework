using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Jugador : Persona
    {
        private int partidosJugados;
        private int totalGoles;

        public Jugador(int dni, string nombre) :base(dni , nombre)
        {

        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            this.partidosJugados = totalPartidos;
            this.totalGoles = totalGoles;
        }

        //props agregadas

        //read only
        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }
            set { this.partidosJugados = value; }
        }

        public float PromedioGoles
        {
            get
            {
                return this.TotalGoles / (float)this.PartidosJugados;
            }
        }

        public int TotalGoles
        {
            get { return this.totalGoles; }
            set { this.totalGoles = value; }
        }

        public string MostrarDatosJugador()
        {
            StringBuilder stringAux = new StringBuilder();

            //aca reemplace en vez de llamar directamente al atributo, llamo directamente a los getters..
            stringAux.AppendLine($"{this.MostrarDatos()}\nTotal Partidos: {this.PartidosJugados}\nTotal Goles: {this.TotalGoles}\nPromedio Goles: {this.PromedioGoles}");

            return stringAux.ToString();

        }

        public static bool operator ==(Jugador jUno, Jugador jDos)
        {
            if ((Object.ReferenceEquals(jUno, null) == false) && (Object.ReferenceEquals(jDos, null) == false))
            {
                if (jUno.Dni == jDos.Dni) //aca modifique el llamado en vez de llamar al atributo, llamo a la propiedad, acordarse de esto duuuh 
                {
                    return true;
                }
            }

            //EEEEEEEEEEEEEEJEJEJEJEEEEEEEEE AHI ANDA PAPAAAAAAAAAAAAAAAAAA

            return false;
        }

        public static bool operator !=(Jugador jUno, Jugador jDos)
        {
            return !(jUno == jDos);
        }
    }
}
