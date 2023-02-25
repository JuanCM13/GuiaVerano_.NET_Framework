using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
    {
        //fields
        protected float duracion;
        protected string nrOrigen;
        protected string nrDestino;

        //props
        public float Duracion
        {
            get { return this.duracion; }
        }

        public string NumOrigen
        {
            get { return this.nrOrigen; }
        }

        public string NumDestino
        {
            get { return this.nrDestino; }
        }

        public abstract float CostoLlamada { get; }

        /*
         * 
         * mepa que esto no va aca, el del pdf se equivoco, asumo que va en la de centralita.. sino no le encuentro sentido
         * aca no lo asigno a nada duh
        //emum
        public enum TipoLlamada { Local = 1, Provincial , Todas}
        */
        //constr
        public Llamada(float duracion, string numDestino, string numOrigen)
        {
            this.duracion = duracion;
            this.nrDestino = numDestino;
            this.nrOrigen = numOrigen;
        }

        //Meths
        public static int OrdenarLlamada(Llamada lUno, Llamada lDos)
        {
            int ret = 0; //son iguales
            if (lUno != null && lDos != null)
            {
                if (lUno.Duracion > lDos.Duracion)
                {
                    ret = 1;
                }
                else
                {
                    if (lUno.Duracion < lDos.Duracion)
                    {
                        ret = -1;
                    }
                }
            }

            return ret;
        }

        protected virtual string MostrarDatos()
        {
            StringBuilder auxS = new StringBuilder();

            auxS.Append($"Duracion de la llamada: {this.Duracion}\nNroº Origen: {this.NumOrigen}\nNroº Destino: {this.NumDestino}");

            return auxS.ToString();
        }

        //operators overload
        public static bool operator ==(Llamada uno, Llamada dos)
        {
            if (Object.ReferenceEquals(uno, null) == false && Object.ReferenceEquals(dos, null) == false)
            {
                //aca si la llamada uno y la dos son del mismo tipo, entra. llama al equals sobrecargado ya sea local o provincial
                //como llamada es abstracta, no tengo que preocuparme de que sea de tipo llamada solo sino que ya va y busca el tipo
                //especifico...
                if (uno.Equals(dos))
                {
                    if (uno.NumOrigen == dos.NumOrigen && uno.NumDestino == dos.NumDestino)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator !=(Llamada uno, Llamada dos)
        {
            return !(uno == dos);
        }
    }
}
