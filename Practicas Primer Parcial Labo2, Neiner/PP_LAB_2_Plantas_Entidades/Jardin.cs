using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_LAB_2_Plantas_Entidades
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

        private Int32 EspacioOcupado()
        {
            Int32 espacioOcupado = 0;
            foreach(Planta item in this.plantas)
            {
                espacioOcupado += item.Tamanio;
            }
            return espacioOcupado;
        }

        private Int32 EspacioOcupado(Planta p)
        {
            return (this.EspacioOcupado() + p.Tamanio);         
        }

        public static bool operator +(Jardin j , Planta p)
        {
            bool ret = false;
            if(!(p is null) && !(j is null))
            {
                if(j.EspacioOcupado(p) <= j.espacioTotal)
                {
                    j.plantas.Add(p);
                    ret = true;
                }
            }
            return ret;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"Composicion del Jardin: {Enum.GetName(Jardin.suelo)}\nEspacio Ocupado: {this.EspacioOcupado()}");
            str.AppendLine($"\n\nPlantas: ");
            
            if(this.plantas.Count > 0)
            {
                foreach(Planta item in this.plantas)
                {
                    str.AppendLine(item.ResumenDeDatos());
                }
            }
            else
            {
                str.AppendLine("Sin plantas por el momento..");
            }
            return str.ToString();
        }
    }
}
