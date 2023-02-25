using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        //private float promedioGoles;
        private int totalGoles;

        private Jugador() : this(0, null, 0, 0)
        {

        }

        public Jugador(int dni, string nombre)
        {
            //reemplazo por los setters
            this.Dni = dni;
            this.Nombre = nombre;

            /*
            this.dni = dni;
            this.nombre = nombre;*/
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            this.partidosJugados = totalPartidos;
            //this.promedioGoles = 0;
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
        }

        //read write 

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public int Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }

        /*public float GetPromedioGoles()
        {
            //restructuro respecto a la anterior version, el atributo promedio de goles de esta clase lo vuelo y retorno directamente
            //por la propiedad PromedioGoles, asi que aca no seteo el promedio de goles sino que nomas devuelvo el promedio NO SETEO!!
            if (this.partidosJugados != 0)
            {
                this.promedioGoles = this.totalGoles / (float)this.partidosJugados;
                return this.promedioGoles
            }

            return -1; //no hizo goles, manejo la salido con un msje en el main
        }*/

        public string MostrarDatos()
        {
            StringBuilder stringAux = new StringBuilder();

            //aca reemplace en vez de llamar directamente al atributo, llamo directamente a los getters..
            stringAux.AppendLine($"Nombre: {this.Nombre}\nDNI: {this.Dni}\nTotal Partidos: {this.PartidosJugados}\nTotal Goles: {this.TotalGoles}\nPromedio Goles: {this.PromedioGoles}");

            return stringAux.ToString();

        }

        public static bool operator ==(Jugador jUno, Jugador jDos)
        {
            //Me tira error, stackOverFloatException, mepaque es por que llamo al != null y me lo toma como ladefinicion de abajo
            //osea la sobrecargada, como que el null lo convierte a objeto de tipo Jugador para hacer la comparasion. De manera
            //implicita lo castea a Jugador el null o a el tipo que vaya a usar... y compara Jugador != (jugador)null;
            //tengo que usar Object.ReferenceEquals(null) y lo niego para que entre al if
            /*
            if(jUno != null && jDos != null)
            {
                if (jUno.dni == jDos.dni)
                {
                    return true;
                }
            }*/

            if ((Object.ReferenceEquals(jUno, null) == false) && (Object.ReferenceEquals(jDos, null) == false))
            {
                if (jUno.dni == jDos.dni)
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
