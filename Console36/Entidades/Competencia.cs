using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {
        //fields
        private short cantidadVueltas;
        private short cantidadCompetidores;
        private List<VehiculoCarrera> competidores;
        private TipoCompetencia tipo;
        private static Random combustibleRandom;

        //props

        public short CantidadVueltas
        {
            get { return this.cantidadVueltas; }
            set { this.cantidadVueltas = value; }
        }

        public short CantidadCompetidores
        {
            get { return this.cantidadCompetidores; }
            set { this.cantidadCompetidores = value; }
        }

        public TipoCompetencia Tipo
        {
            get { return this.tipo; }
            set { this.tipo = value; } 
        }

        public List<VehiculoCarrera> Competidores
        {
            get { return this.competidores; }
            private set { this.competidores = value; }
        }

        //indexador
        public VehiculoCarrera this[int i]
        {
            get { return this.competidores[i]; }
        }

        //enum
        public enum TipoCompetencia { F1 = 1 , MotoCross}


        //constructors
        private Competencia()
        {
            Competencia.combustibleRandom = new Random();
            this.Competidores = new List<VehiculoCarrera>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores , TipoCompetencia tipo) : this()
        {
            this.CantidadVueltas = cantidadVueltas;
            this.CantidadCompetidores = cantidadCompetidores;
            this.Tipo = tipo;
        }

        //meths
        public string MostrarDatos()
        {
            StringBuilder strB = new StringBuilder();

            strB.AppendLine($"Cantidad totales de vueltas: {this.CantidadVueltas}\nCantidad de corredores: {this.CantidadCompetidores} \nTipo Carrera: {this.Tipo}");

            return strB.ToString();
        }

        private bool CargarDataCorredor(VehiculoCarrera v)
        {
            if (object.ReferenceEquals(v,null) == false)
            {
                short combustible = (short)Competencia.combustibleRandom.Next(15, 100);
                v.CantidadCombustible = combustible;
                v.EnCompetencia = true;
                v.VueltasRestantes = this.CantidadVueltas;
                return true;
            }
            return false;
        }

        //operator overload
        public static bool operator -(Competencia c, VehiculoCarrera v)
        {
            if (c != null && v != null)
            {
                if(c.competidores.Contains(v))
                {
                    c.competidores.Remove(v);
                    return true;
                }
            }

            return false;
        }

        public static bool operator +(Competencia c, VehiculoCarrera v)
        {
            if (object.ReferenceEquals(c,null) == false && object.ReferenceEquals(v,null) == false)
            {
                if ((c.competidores.Count()) + 1 <= c.cantidadCompetidores && c == v)
                {
                    c.CargarDataCorredor(v);
                    c.competidores.Add(v);
                    return true;
                }
            }

            return false;
        }

        public static bool operator ==(Competencia c, VehiculoCarrera v )
        {
            bool flagRetorno = false;
            if (Object.ReferenceEquals(c, null) == false && object.ReferenceEquals(v, null) == false)
            {
                if(c.competidores.Contains(v) == false)
                    /*Con un switch verifico en base al tipo de carrera de la competencia, en el caso que sea f1, si el vehiculo
                     es de tupo f1 retorna true, sino false. Si competencia es Motocross entra y pregunta si el objeto es de tipo
                        motocross, retorna true o false..*/
                    switch (c.Tipo)
                    {
                        case Competencia.TipoCompetencia.F1:
                            if(v is AutoF1) //cuando me tira el error cs0184 es por que me olvide de hacer que el tipo herede del base, en este caso me nunca me iba
                            {               //a reconocer que v sea de tipo autof1 por que nunca le marque eque autof1 hereda de v duh
                                flagRetorno = true;
                            }
                        break;
                        case Competencia.TipoCompetencia.MotoCross:
                            if (v is MotoCross) 
                            {
                                flagRetorno = true;
                            }
                        break;
                }
            }
            return flagRetorno;
        }

        public static bool operator !=(Competencia c, VehiculoCarrera v)
        {
            return !(c == v);
        }

    }
}
