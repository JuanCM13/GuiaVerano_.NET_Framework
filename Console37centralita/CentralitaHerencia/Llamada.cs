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

        /*
         * 
         * mepa que esto no va aca, el del pdf se equivoco, asumo que va en la de centralita.. sino no le encuentro sentido
         * aca no lo asigno a nada duh
        //emum
        public enum TipoLlamada { Local = 1, Provincial , Todas}
        */
        //constr
        public Llamada(float duracion , string numDestino , string numOrigen)
        {
            this.duracion = duracion;
            this.nrDestino = numDestino;
            this.nrOrigen = numOrigen;
        }

        //Meths
        public static int OrdenarLlamada(Llamada lUno , Llamada lDos)
        {
            int ret = 0; //son iguales
            if(lUno != null && lDos != null)
            {
                if(lUno.Duracion > lDos.Duracion)
                {
                    ret = 1;
                }
                else
                {
                    if(lUno.Duracion < lDos.Duracion)
                    {
                        ret = -1;
                    }
                }
            }

            return ret;
        }

        public static string MostrarDatos(Llamada data)
        {
            StringBuilder auxS = new StringBuilder();

            auxS.Append($"Duracion de la llamada: {data.Duracion}\nNroº Origen: {data.NumOrigen}\nNroº Destino: {data.NumDestino}");

            return auxS.ToString();
        }
    }
}
