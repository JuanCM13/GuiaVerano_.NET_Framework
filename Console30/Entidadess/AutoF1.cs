using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidadess
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        private AutoF1()
        {
            /* this.cantidadCombustible = 0;
             this.enCompetencia = false;
             this.vueltasRestantes = 0;*/
            this.setData(0, false, 0);
        }


        public AutoF1(short numero, string escuderia) : this()
        {
            this.numero = numero;
            this.escuderia = escuderia;
        }

        public void setData(short cantCombus, bool competenciaEstado, short vueltas)
        {
            this.cantidadCombustible = cantCombus;
            this.enCompetencia = competenciaEstado;
            this.vueltasRestantes = vueltas;
        }
        public string getData()
        {
            StringBuilder strBuilder = new StringBuilder();
            string aux;

            if (this.enCompetencia)
            {
                aux = "Afirmativo";
            }
            else
            {
                aux = "Negativo";
            }

            strBuilder.AppendFormat("Cantidad Combustible: {0}\nEsta Compitiendo?: {1}\nVueltas Restantes: {2}" , this.cantidadCombustible , aux , this.vueltasRestantes);
            return strBuilder.ToString();
        }

        

        public string MostrarDatos()
        {
            StringBuilder aux = new StringBuilder();
            //string resultado;

            aux.AppendLine($"Numero: {this.numero}\nEscuderia: {this.escuderia}");
            aux.AppendLine(this.getData());
            /*resultado = aux.ToString();
            resultado += this.getData(); //data de los datos conseguidos por setter y getter*/

            return aux.ToString();
        }

       /* public static short GetCantidadCombustible(AutoF1 aux)
        {
            return aux.cantidadCombustible;
        }*/

        public static bool operator ==(AutoF1 a , AutoF1 b)
        {
            if(Object.ReferenceEquals(a , null) && Object.ReferenceEquals(b, null))
            {
                if( (a.numero == b.numero) && (a.escuderia == b.escuderia) )
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(AutoF1 a , AutoF1 b)
        {
            return !(a == b);
        }

    }
}
