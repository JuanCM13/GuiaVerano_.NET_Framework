using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueSeaLoQueElDieguitoQuiera
{
    public class Jardin
    {
        private Int32 espacioTotal;
        private List<Planta> plantas;
        private static Tipo suelo;

        static Jardin()
        {
            Jardin.suelo = Tipo.Terrozo;
        }

        private Jardin()
        {
            this.plantas = new List<Planta>();
        }

        public Jardin(Int32 espacio)
            :this()
        {
            this.espacioTotal = espacio;
        }

        public Tipo TipoSuelo
        {
            set { Jardin.suelo = value; }
        }

        public static bool operator +(Jardin j , Planta p)
        {
            bool ret = false;
            if(!(j is null) && !(p is null))
            {
                if(j.EspacioOcupado(p) <= j.espacioTotal)
                {
                    j.plantas.Add(p);
                    ret = true;
                }
            }
            return ret;
        }

        public Int32 EspacioOcupado()
        {
            Int32 acum = 0;
            foreach(Planta item in this.plantas)
            {
                acum += item.Tamanio;
            }
            return acum;
        }

        public Int32 EspacioOcupado(Planta p)
        {
            Int32 ret = this.EspacioOcupado();
            if(!(p is null))
            {
                ret += p.Tamanio;
            }
            return ret;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"Composicion del Jardin: {Enum.GetName(Jardin.suelo)}");
            str.AppendLine($"Espacio ocupado: {this.EspacioOcupado()} de {this.espacioTotal}");

            str.AppendLine("Plantas cargadas: ");
            if(this.plantas.Count > 0)
            {
                foreach(Planta item in this.plantas)
                {
                    str.AppendLine(item.ToString());
                }
            }
            else
            {
                str.AppendLine("Sin plantas al momento..");
            }

            return str.ToString();
        }

    }
}
