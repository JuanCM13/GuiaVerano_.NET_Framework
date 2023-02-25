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
        private float promedioGoles;
        private int totalGoles;

        private Jugador() : this(0 , null , 0 , 0)
        {

        }

        public Jugador(int dni , string nombre)
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni , string nombre , int totalGoles , int totalPartidos) : this(dni , nombre)
        {
            this.partidosJugados = totalPartidos;
            this.promedioGoles = 0;
            this.totalGoles = totalGoles;
        }

        public float GetPromedioGoles()
        {
            if(this.partidosJugados != 0)
            {
                this.promedioGoles = this.totalGoles / (float)this.partidosJugados;
                return this.promedioGoles;
            }

            return -1; //no hizo goles, manejo la salido con un msje en el main
        }

        public string MostrarDatos()
        {
            StringBuilder stringAux = new StringBuilder();

            stringAux.AppendLine($"Nombre: {this.nombre}\nDNI: {this.dni}\nTotal Partidos: {this.partidosJugados}\nTotal Goles: {this.totalGoles}\nPromedio Goles: {this.GetPromedioGoles()}");

            return stringAux.ToString();

        }

        public static bool operator ==(Jugador jUno , Jugador jDos)
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

            if( (Object.ReferenceEquals(jUno , null) == false) && (Object.ReferenceEquals(jDos , null) == false) )
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
