using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        //fields
        private List<Llamada> listaLlamadas;
        private string razonSocial;

        //props
        public float GananciasPorLocal
        {
            get { return this.CalcularGanancia(Centralita.TipoLlamada.Local); }
        }

        public float GananciasPorProvincial
        {
            get { return this.CalcularGanancia(Centralita.TipoLlamada.Provincial); }
        }

        public float GananciasPorTotal
        {
            get { return this.CalcularGanancia(Centralita.TipoLlamada.Todas); }
        }

        public List<Llamada> Llamadas
        {
            get { return this.listaLlamadas; }
        }

        //emum
        public enum TipoLlamada { Local = 1, Provincial, Todas }

        //constr
        private Centralita()
        {
            this.listaLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        //meths

        /*Podria haber hecho el total de ganancia sumando this.CostoLocales + this.CostoProvinciales, pero asi para realizar
         el calculo va a recorrer dos veces la lista y ocupar mas memoria stack al dope. Preferible que si seleccinoa solo calcular
        el total de las llamadas en el campo haga la validacion de opcion 3 y siempre entra y acumulo. Igual preguntar que manera
        es mejor...*/
        private float CalcularGanancia(TipoLlamada tipo)
        {
            //1- locales , 2-provinciales , 3-todas
            int aux = (int)tipo;
            float acumPrecio = 0;

            foreach (Llamada auxLlamada in this.Llamadas)
            {
                //Preguntar si hay modo de filtrar mas fino y ahorrar preguntas pero hice prueba de flujo y esta pareciera ser
                //la unica forma :s
                if ((aux == 1 || aux == 3) && auxLlamada is Local)
                {
                    /*auxLocal = (Local)auxLlamada;
                    acumPrecio += auxLocal.CostoLlamada;*/
                    acumPrecio += auxLlamada.CostoLlamada;
                }
                else
                {
                    if ((aux == 2 || aux == 3) && auxLlamada is Provincial)
                    {
                        /*auxProvincial = (Provincial)auxLlamada;
                        acumPrecio += auxProvincial.CostoLlamada;*/
                        acumPrecio += auxLlamada.CostoLlamada;
                    }
                }
            }
            return acumPrecio;
        }

        private string Mostrar()
        {
            StringBuilder str = new StringBuilder();

            str.Append($"Razon Social: {this.razonSocial}\nGanancia Total: {this.GananciasPorTotal}\nGanancia Local: {this.GananciasPorLocal}");
            str.AppendLine($"\nGanancia Provincial: {this.GananciasPorProvincial}\n");
            str.AppendLine($"{this.GenerarDataClientes()}");

            return str.ToString();
        }

        //aca asumo que con detalle de llamadas realizadas quiere que imprima la data de cada tipo de llamada :s podrian detallar mas no?
        private string GenerarDataClientes()
        {
            StringBuilder str = new StringBuilder();


            foreach (Llamada auxLlamada in this.Llamadas)
            {

                str.AppendLine($"{auxLlamada.ToString()}");

            }

            return str.ToString();
        }

        public void OrdenarLlamadas()
        {
            //lo paso asi como en la funcion sort de la linkedList en C, no invoco la funcion ordenarLlamada sino que paso
            //la direccion de memoria donde arranca la funcion. onda el nombre hace referencia a la primera posision donde
            //se aloja el metodo...

            this.Llamadas.Sort(Llamada.OrdenarLlamada);
        }

        private void AgregarLlamada(Llamada llamada)
        {
            if (Object.ReferenceEquals(llamada, null) == false)
            {
                this.Llamadas.Add(llamada);
            }
        }

        //operators overload
        public static bool operator ==(Centralita c, Llamada l)
        {
            bool ret = false;
            if (object.ReferenceEquals(c, null) == false && Object.ReferenceEquals(l, null) == false)
            {
                foreach (Llamada aux in c.Llamadas)
                {
                    if (aux == l)
                    {
                        ret = true;
                        break;
                    }
                }
            }
            return ret;
        }

        public static bool operator !=(Centralita c, Llamada l)
        {
            return !(c == l);
        }

        public static bool operator +(Centralita c, Llamada l)
        {
            if (c != l)
            {
                c.AgregarLlamada(l);
                return true;
            }

            return false;
        }

        //methods overrited
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
