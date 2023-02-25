using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecas
{
    public class Grupo
    {
        private List<Mascota> manada;
        private String nombre;
        private static EtipoManada tipo;

        static Grupo()
        {
            Grupo.tipo = EtipoManada.Unica;
        }

        private Grupo()
        {
            this.manada = new List<Mascota>();
        }

        public Grupo(String nombre)
            :this()
        {
            this.nombre = nombre;
        }

        public Grupo(String nombre, EtipoManada tipo)
            : this(nombre)
        {
            this.Tipo = tipo;
        }

        public EtipoManada Tipo
        {
            set
            {
                Grupo.tipo = value;
            }
        }

        public static implicit operator String(Grupo g)
        {
            StringBuilder str = new StringBuilder();
            
            if(!(g is null))
            {
                str.AppendLine($"Grupo: {g.nombre} - Tipo: {Grupo.tipo}");
                str.AppendLine($"Integrantes: {g.manada.Count}\n");
                if (g.manada.Count > 0)
                {
                    foreach (Mascota item in g.manada)
                    {
                        str.Append(item.ToString());
                    }
                }
                else
                {
                    str.AppendLine("Sin mascotas por el momento");
                }
            }
            else
            {
                str.AppendLine("El grupo no esta instanciado..");
            }

            return str.ToString();
        }

        public static bool operator ==(Grupo g , Mascota m)
        {
            bool ret = false;
            if(!(g is null) && !(m is null))
            {
                foreach(Mascota item in g.manada)
                {
                    if(item.Equals(m))
                    {
                        ret = true;
                        break;
                    }
                }
            }
            return ret;
        }

        public static bool operator !=(Grupo g, Mascota m)
        {
            return !(g == m);
        }

        public static Grupo operator +(Grupo g, Mascota m)
        {
            if(!(g is null) && !(m is null))
            {
                if(g != m)
                {
                    g.manada.Add(m);
                }                
                else
                {
                    Console.WriteLine($"El elemento ya esta en la lista: {m}");
                }
            }
            else
            {
                Console.WriteLine("Uno de los miembros pasados por parametro fue nulo");
            }
            return g;
        }

        public static Grupo operator -(Grupo g, Mascota m)
        {
            if (!(g is null) && !(m is null))
            {
                if(g == m)
                {
                    g.manada.Remove(m);
                }
                else
                {
                    Console.WriteLine($"El elemento no esta en la lista: {m}");

                }
            }
            else
            {
                Console.WriteLine("Uno de los miembros pasados por parametro fue nulo");
            }
            return g;
        }


    }
}
