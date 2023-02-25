using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidadess
{
    public class Competencia
    {
        private short cantidadVueltas;
        private short cantidadCompetidores;
        private List<AutoF1> competidores;
        private static Random combustibleRandom;

        private Competencia()
        {
            Competencia.combustibleRandom = new Random();
            this.competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadVueltas , short cantidadCompetidores) :this()
        {
            //si se da el caso que el parametro del constructor se llama igual que el campo de la clase al que quiero asignar
            //y no agrego el this, se va a crear una ambiguedad de valor, lo cual el intelicense piensa que voy a asignar al
            //parametro el mismo parametro, tengo que si o si usar el this en el field...
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }

        public List<AutoF1> GetList()
        {
            return this.competidores;
        }

        public string MostrarData()
        {
            StringBuilder strB = new StringBuilder();

            strB.AppendLine($"Cantidad totales de vueltas: {this.cantidadVueltas}\nCantidad de corredores: {this.cantidadCompetidores}");

            return strB.ToString();
        }

        public static bool operator -(Competencia c , AutoF1 a)
        {
            if(c != null && a != null)
            {
                c.competidores.Remove(a);
                return true;
            }

            return false;
        }
        
        public static bool operator +(Competencia c , AutoF1 a)
        {
            if (c != null && a != null)
            {
                if( (c.competidores.Count())+1 <= c.cantidadCompetidores && c != a)
                {
                    c.CargarDataCorredor(a);
                    c.competidores.Add(a);
                    return true;
                }
            }

            return false;
        }

        private bool CargarDataCorredor(AutoF1 auto)
        {
            if(auto != null)
            {
                //Random combustible = new Random(); no instancio aca, por que como se generan rapido mismas instancias de rnadom
                //siempre me tira el mismo numero, mejor lo paso por referencia asi no se instancia al toque y me tira siempre el mismo numero
                //en todos los corredores, aclaro eso no funciono, me tira le mismo igual....

                //Creandolo en el operador sobrecargado + y pasandolo por referencia aca tampoco funco...


                /* Voy a probar, creandolo una sola vez seteandolo estatico como campo de clase, a ver que onda*/
                //JEJEJEJEJE AHI FUNCOOOO que genio 7.7 

                short combustible = (short) Competencia.combustibleRandom.Next(15, 100);
                auto.setData(combustible , true, this.cantidadVueltas);
                return true;
            }
            return false;
        }

        public static bool operator ==(Competencia c , AutoF1 a)
        {
            if(Object.ReferenceEquals(c , null) == false && object.ReferenceEquals(a , null) == false)
            {
                if(c.competidores.Contains(a))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);   
        }

    }
}
