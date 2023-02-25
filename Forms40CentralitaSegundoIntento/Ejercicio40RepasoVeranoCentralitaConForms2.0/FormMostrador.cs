using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CentralitaHerencia;
namespace Ejercicio40RepasoVeranoCentralitaConForms2._0
{
    public partial class FormMostrador : Form
    {
        Centralita central;
        int tipoMostrado;

        public FormMostrador(Centralita central, int tipoMostrar)
        {
            /*
             * tipoMostrar:
             1- Local
             2- Provinciales
             3- Todas
             */
            InitializeComponent();
            this.central = central;
            this.TipoAmostrar = tipoMostrar;
            this.PrinteoData();
        }

        public int TipoAmostrar
        {
            set { this.tipoMostrado = value; }
        }

        private string MostrarData()
        {
            StringBuilder auxD = new StringBuilder();
            //string auxData = String.Empty;
            float auxiliarFacturacion;

            switch(this.tipoMostrado)
            {
                case 1:

                    auxD.AppendLine($"Llamadas Locales:");
                    //auxData += "Llamadas Locales:\n";
                    
                    auxiliarFacturacion = central.GananciasPorLocal;
                    if(auxiliarFacturacion > 0)
                    {
                        auxD.AppendLine($"${auxiliarFacturacion}\n{central.GenerarDataClientes(1)}");  //generar data crea listado de llamadas por tipo, info de llamadas realizadas
                        //auxData += "$" + auxiliarFacturacion + "\n";
                        //auxData += central.GenerarDataClientes(1); //generar data crea listado de llamadas por tipo, info de llamadas realizadas
                    }
                    else
                    {
                        auxD.AppendLine("No se realizaron Llamadas de tipo Local al momento de facturar...");
                        //auxData += "No se realizaron Llamadas de tipo Local al momento de facturar...";
                    }

                break;

                case 2:

                    auxD.AppendLine($"Llamadas Provinciales:");
                   //auxData += "Llamadas Provinciales:\n";
                   auxiliarFacturacion = central.GananciasPorProvincial;
                    if (auxiliarFacturacion > 0)
                    {
                        auxD.AppendLine($"${auxiliarFacturacion}:");
                        auxD.AppendLine($"{central.GenerarDataClientes(2)}"); //generar data crea listado de llamadas por tipo, info de llamadas realizadas
                        //auxData += "$" +auxiliarFacturacion + "\n";
                        //auxData += central.GenerarDataClientes(2);                     }
                    }
                    else
                    {
                        auxD.AppendLine($"No se realizaron Llamadas de tipo Provincial al momento de facturar...");
                        //auxData += "No se realizaron Llamadas de tipo Provincial al momento de facturar...";
                    }

                break;

                default:
                    auxD.AppendLine($"{central.ToString()}"); //aca en el toString de centralita ya imprime todas las llamadas, invoca a generar data dentro..
                                                              //auxData += central.ToString(); 
                break;

            }

            return auxD.ToString();
        }

        private void PrinteoData()
        {
            this.richTextBox1.Text = this.MostrarData();
        }

        //boton salir del form mostrador
        private void btnFormMostradorSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
