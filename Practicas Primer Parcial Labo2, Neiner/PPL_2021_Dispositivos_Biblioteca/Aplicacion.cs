using System;
using System.Text;
using System.Collections.Generic;

namespace PPL_2021_Dispositivos_Biblioteca
{
    public abstract class Aplicacion
    {
        protected String nombre;
        protected SistemaOperativo sistemaOperativo;
        protected Int32 tamanioMb;

        public SistemaOperativo SistemaOperativo 
        {
            get { return this.sistemaOperativo; }
        }

        protected abstract Int32 Tamanio
        {
            get;
        }

        public Aplicacion(String nombre, SistemaOperativo so, Int32 tamanio)
        {
            this.nombre = nombre;
            this.sistemaOperativo = so;
            this.tamanioMb = tamanio;
        }

        public virtual String ObtenerInformacioApp()
        {
            StringBuilder str = new StringBuilder();

            str.Append($"Nombre: {this.nombre}\nSO: {this.SistemaOperativo}\nTamaño: {this.Tamanio}");

            return str.ToString();
        }

        public static implicit operator Aplicacion(List<Aplicacion> lista)
        {
            Int32 tam = 0;
            Int32 i = 0;
            Aplicacion auxApp = null;
            foreach(Aplicacion item in lista)
            {
                if(i == 0 || tam < item.Tamanio)
                {
                    auxApp = item;
                    tam = item.Tamanio;
                }
            }
            return auxApp;
        }

        public static bool operator ==(List<Aplicacion> lista , Aplicacion app)
        {
            bool ret = false;
            if(!(lista is null) && !(app is null))
            {
                foreach(Aplicacion item in lista)
                {
                    if(item.nombre == app.nombre)
                    {
                        ret = true;
                        break;
                    }
                }
            }
            return ret;
        }

        public static bool operator !=(List<Aplicacion> lista, Aplicacion app)
        {
            return !(lista == app);
        }

        public static bool operator +(List<Aplicacion> lista, Aplicacion app)
        {
            bool ret = false;
            if(lista != app)
            {
                lista.Add(app);
                ret = true;
            }
            return ret;
        }

        public override string ToString()
        {
            return this.nombre;
        }
    }
}
