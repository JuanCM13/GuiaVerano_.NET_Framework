using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        //fields
        private string nombre;
        private int numero;

        //props
        public string Nombre 
        { 
            get 
            {
                return this.nombre;
            } 
            set
            {
                this.nombre = value;
            }
        }

        
        public int Numero
        {
            get
            {
                return this.numero;
            }
        }

        //constructor
        public Cliente(int numero) : this(numero, null)
        {

        }

        public Cliente(int numero , string nombre)
        {
            this.numero = numero;
            this.nombre = nombre;
        }

        //operators overload
        public static bool operator ==(Cliente cUno , Cliente cDos)
        {
            bool ret = false;
            if( !(Object.ReferenceEquals(cUno , null) && Object.ReferenceEquals(cDos , null)))
            {
                if(cUno.Numero == cDos.Numero)
                {
                    ret = true;
                }
            }

            return ret ;
        }

        public static bool operator !=(Cliente cUno , Cliente cDos)
        {
            return !(cUno == cDos);
        }

    }
}
