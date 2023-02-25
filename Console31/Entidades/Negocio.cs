using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        //fields
        private PuestoAtencion caja;
        private Queue<Cliente> listaClientes;
        private string nombreCliente;


        //constructors
        private Negocio()
        {
            listaClientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.caja1); 
        }

        public Negocio(string nombre) :this()
        {
            this.nombreCliente = nombre;
        }


        //props
        public Cliente Cliente
        {
            get
            {
                return this.listaClientes.Peek(); //devuelve y elimina asi siempre que entre devuelve el primero y como lo elimina
            }                                       //va en orden de fifo
            set
            {
                if(this + value == false) //aca uso el operador + va a sumar el tipo Negocio + un Cliente, por eso uso el this solo, asi al 
                {                            //operador sobrecargado + le paso todo el objeto Negocio, haciendo referencia a este objeto por eso 
                                             //nomas paso this
                    Console.WriteLine("Error, la lista esta llena..");
                }
            }
        }

        public int ClientesPendientes
        {
            get
            {
                return this.listaClientes.Count;
                //return this.listaClientes.Count(); puedo hacerlo asi por que como mi metodo los va eliminando a medidaque atiende
                //siempre el count me va a devolver cuantos clientes quedan, pero intuyo que tengo que usar la propiedad NumeroActual
                //de la clase PuestoAtencion
                //return this.listaClientes.Count() - this.caja.NumeroActual;
            
            }   
        }

        public Queue<Cliente> ListaClientes
        {
            get
            {
                return this.listaClientes;
            }
        }

        //operators overload
        public static bool operator ==(Negocio n, Cliente c)
        {
            if (!(Object.ReferenceEquals(n, null)) && !(Object.ReferenceEquals(c, null)))
            {
                foreach (Cliente auxC in n.listaClientes)
                {
                    if (auxC.Numero == c.Numero)
                    {
                        return true;
                    }
                }
            }
            return false; 
        }

        public static bool operator !=(Negocio n , Cliente c)
        {
            return !(n == c);
        }

        public static bool operator +(Negocio n , Cliente c)
        {
            /*if( !(Object.ReferenceEquals(n , null)) == false && !(Object.ReferenceEquals(c, null)) == false)
            {*/
                if(n != c)
                {
                    n.listaClientes.Enqueue(c);
                    return true;
                }
            //}
            return false;
        }

        public static bool operator ~(Negocio n)
        {
            /*Con la propiedad get de Cliente, consigo el proximo cliente, con el metodo atender que accedo desde el negocio
             ingresando a la caja (PuestoAtencion) y desde ahi accedo al metodo de puesto de atencion de Atender al cual le paso
            por parametro el cliente conseguido con la propiedad Cliente guardada en un Cliente aux si todo sale bien retorna true*/

            Cliente aux = n.Cliente;
            int auxDescartable;

            if (n.caja.Atender(aux))
            {
                auxDescartable = n.caja.NumeroActual;
                return true;
            }

            return false;
            
        }

        //methods

        public string GetData()
        { 
            Cliente aux = this.Cliente;
            StringBuilder data = new StringBuilder();

            data.Append($"Cliente Nº {aux.Numero}\nNombre: {aux.Nombre}\n");
            this.listaClientes.Dequeue();
            return data.ToString();
        }


    }
}
