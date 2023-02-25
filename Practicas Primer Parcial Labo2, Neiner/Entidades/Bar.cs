using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Botellas;

namespace Entidades.Establecimiento
{
    public class Bar
    {
        private List<Botella> botellas;
        private Int32 capacidadMaxima;
        private String nombre;
        private Double recaudacion;

        public List<Botella> Botellas
        {
            get { return this.botellas; }
        }

        public String MostrarBar
        {
            get { return this.Mostrar(); }
        }

        public Bar()
        {
            this.botellas = new List<Botella>();
            this.capacidadMaxima = 5;
            this.nombre = "Sin Nombre";
        }

        public Bar(Int32 capacidad)
            :this()
        {
            this.capacidadMaxima = capacidad;
        }

        public Bar(Int32 capacidad , String nombre)
            :this(capacidad)
        {
            this.nombre = nombre;
        }

        private String Mostrar()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"Nombre Bar: {this.nombre}\nCapacidad Botellas: {this.capacidadMaxima}\nRecaudacion: {(Double)this}");
            str.AppendLine("--------------------------------------------------------------------------");
            str.AppendLine("                                Botellas:");
            str.AppendLine("--------------------------------------------------------------------------");
            
            if(this.Botellas.Count > 0)
            {
                foreach(Botella item in this.Botellas)
                {
                    str.Append(item.ToString());
                }
            }
            else
            {
                str.AppendLine("Sin botellas por el momento...");
            }
            return str.ToString();
        }

        public static explicit operator Double(Bar b)
        {
            Double aux = 0;
            if(!(b is null))
            {
                aux = b.recaudacion;
            }
            return aux;
        }

        public static bool operator ==(Bar bar , Botella bote)
        {
            bool ret = false;
            if(!(bar is null) && !(bote is null))
            {
                foreach(Botella item in bar.Botellas)
                {
                    if(item.Equals(bote))
                    {
                        ret = true;
                        break;
                    }
                }
            }
            return ret;
        }

        public static bool operator !=(Bar bar, Botella bote)
        {
            return !(bar == bote);
        }

        public static Bar operator +(Bar bar, Botella bote)
        {
            if(!(bar is null) && !(bote is null))
            {
                if(bar.Botellas.Count < bar.capacidadMaxima && bar != bote)
                {
                    bar.Botellas.Add(bote);    
                }
            }
            return bar;
        }

        public static Bar operator -(Bar bar, Botella bote)
        {
            if(!(bar is null) && !(bote is null))
            {
                if(bar == bote)
                {
                    bote--;
                    bar += bote.Ganancia;
                    if(bote.PorcentajeContenido < 1)
                    {
                        bar.Botellas.Remove(bote);
                    }
                }
            }
            return bar;
        }

        public static Bar operator +(Bar bar, Double g)
        {
            if(!(bar is null))
            {
                bar.recaudacion += g;
            }
            return bar;
        }

        public void OrdenarBotellas(Ordenamiento o)
        {
            switch(o)
            {
                case Ordenamiento.Ganancia:
                    this.Botellas.Sort(this.OrdenarPorGanancia);
                    break;
                case Ordenamiento.Marca:
                    this.Botellas.Sort(Bar.OrdenarPorMarca);
                    break;
                case Ordenamiento.PorcentajeContenido:
                    this.Botellas.Sort(Bar.OrdenarPorContenido);
                    break;
            }
        }

        private static Int32 OrdenarPorContenido(Botella a , Botella b)
        {
            Int32 ret = 0;
            if(!(a is null) && !(b is null))
            {
                if(a.PorcentajeContenido > b.PorcentajeContenido)
                {
                    ret = 1;
                }
                else
                {
                    if(a.PorcentajeContenido < b.PorcentajeContenido)
                    {
                        ret = -1;
                    }
                }
            }
            return ret;
        }

        private Int32 OrdenarPorGanancia(Botella a, Botella b)
        {
            Int32 ret = 0;
            if (!(a is null) && !(b is null))
            {
                if (a.Ganancia > b.Ganancia)
                {
                    ret = 1;
                }
                else
                {
                    if (a.Ganancia < b.Ganancia)
                    {
                        ret = -1;
                    }
                }
            }
            return ret;
        }

        private static Int32 OrdenarPorMarca(Botella a, Botella b)
        {
            Int32 ret = 0;
            if (!(a is null) && !(b is null))
            {
                ret = String.Compare((String)a, (String)b);
            }
            return ret;
        }

    }
}
