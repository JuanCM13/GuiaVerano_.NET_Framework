using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPL_2021_Dispositivos_Biblioteca
{
    public class AppMusical : Aplicacion
    {
        private List<String> listaCanciones;

        public AppMusical(String nombre, SistemaOperativo sistema, Int32 tamInicial)
            :this(nombre , sistema , tamInicial , new List<String>())
        {}

        public AppMusical(String nombre, SistemaOperativo sistema, Int32 tamInicial, List<String> canciones)
            :base(nombre , sistema , tamInicial)           
        {
            this.listaCanciones = canciones;
        }

        protected override int Tamanio
        {
            get 
            { 
                return (this.tamanioMb + (this.listaCanciones.Count * 2)); 
            }
        }

        public override string ObtenerInformacioApp()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"{base.ObtenerInformacioApp()}\nLista Canciones: ");
            if(this.listaCanciones.Count > 0)
            {
                foreach(String item in this.listaCanciones)
                {
                    str.AppendLine(item);
                }
            }
            else
            {
                str.AppendLine("Sin canciones por el momento..");
            }
            return str.ToString();
        }
    }
}
