using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPL_2021_Dispositivos_Biblioteca
{
    public static class Dispositivo
    {
        private static List<Aplicacion> appInstaladas;
        private static SistemaOperativo sistemaOperativo;

        static Dispositivo()
        {
            Dispositivo.appInstaladas = new List<Aplicacion>();
            Dispositivo.sistemaOperativo = SistemaOperativo.ANDROID;
        }

        public static bool InstalarApp(Aplicacion app)
        {
            bool ret = false;
            if(!(app is null))
            {
                if(Dispositivo.sistemaOperativo == app.SistemaOperativo)
                {
                    if(Dispositivo.appInstaladas + app)
                    {
                        ret = true;
                    }
                }
            }
            return ret;
        }

        public static String ObtenerInformacionDispositivo()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine($"Sistema Operativo: {Dispositivo.sistemaOperativo}");
            if(Dispositivo.appInstaladas.Count > 0)
            {
                foreach(Aplicacion item in Dispositivo.appInstaladas)
                {
                    str.AppendLine(item.ObtenerInformacioApp());
                }
            }
            else
            {
                str.AppendLine($"Sin aplicaciones instaladas..");
            }
            return str.ToString();
        }
    }
}
