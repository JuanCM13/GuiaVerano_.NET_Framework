using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class PuestoAtencion
    {
         
        //fields
        private static int numeroActual;
        private Puesto puesto;


        //constructor
        public PuestoAtencion() :this(0)
        {
            
        }

        public PuestoAtencion(Puesto puestoA)
        {
            this.puesto = puestoA;
        }


        //props
        public int NumeroActual
        {
            get
            {
                return PuestoAtencion.numeroActual + 1;
            }
        
        }

        public int Caja
        {
            get
            {
                return PuestoAtencion.numeroActual + 1;
            }

        }

        //nested Types
        public enum Puesto { caja1 = 1 , caja2 }


        //methods
        public bool Atender(Cliente cli)
        {
            Console.WriteLine("Entre");
            Thread.Sleep(10000);
            return true;
        }

    }
}
