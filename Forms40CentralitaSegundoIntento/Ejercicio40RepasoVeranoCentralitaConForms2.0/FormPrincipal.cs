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
    public partial class FormPrincipal : Form
    {
        Centralita centralLlamadas;
        Form formularioLlamador;
        Form formLlamador; //si ya se que podia evitar crear otra var Form reutilizando el de arriba, pero asi es mas facil
                        //de entender a simple vista..
        public FormPrincipal()
        {
            InitializeComponent();
            centralLlamadas = new Centralita("Central Llamadas Kiev");     
        }

        //generador llamadas
        private void Click_GenerarLlamada(object sender, EventArgs e)
        {
            this.formularioLlamador = new FormLlamador(centralLlamadas);
            formularioLlamador.ShowDialog();
        }

        //facturacion total
        private void btnFacTotal_Click(object sender, EventArgs e)
        {
            if(centralLlamadas.Llamadas.Count > 0)
            {
                this.formLlamador = new FormMostrador(this.centralLlamadas , 3); //muestra todas las llamadas con la data..
                this.formLlamador.Show();
            }
            else
            {
                CartelAlertaError("Error, no hay llamadas realizadas todavia..");
            }
        }

        //facturacion local
        private void btnFacLocal_Click(object sender, EventArgs e)
        {
            if (centralLlamadas.Llamadas.Count > 0)
            {
                this.formLlamador = new FormMostrador(this.centralLlamadas, 1); //muestra locales las llamadas con la data..
                this.formLlamador.Show();
            }
            else
            {
                CartelAlertaError("Error, no hay llamadas realizadas todavia..");
            }
        }

        //facturacion provincial
        private void btnFacProvincial_Click(object sender, EventArgs e)
        {
            if (centralLlamadas.Llamadas.Count > 0)
            {
                this.formLlamador = new FormMostrador(this.centralLlamadas, 2); //muestra provinciales las llamadas con la data..
                this.formLlamador.Show();
            }
            else
            {
                CartelAlertaError("Error, no hay llamadas realizadas todavia..");
            }
        }

        //metodos..
        private void CartelAlertaError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        //boton salir form llamador... 
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
