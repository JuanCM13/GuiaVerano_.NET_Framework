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
    public partial class FormLlamador : Form
    {
        //campos 
        //textbox destino = 1 // textbox origen = 2
        private int textBoxUltimoFoco;
        private string numDestino;
        private string numOrigen;
        private Centralita central;
        private Random numRandom;
        private Random costoRandomLocal;
        private int tipoLlamada; //1 local, 2 provincial

        private Local auxLocal;
        private Provincial auxProvincial;

        public FormLlamador(Centralita callCenter)
        {
            InitializeComponent();
            this.central = callCenter;
            ResetearDatos(); //reutilizo la funcion para restaurar los valores a predeterminado..
            //seteo el enum en el combo box
            this.cmbFranjas.DataSource = Enum.GetValues(typeof(Provincial.Franja)); //sin el provincial no me lo toma...
        }

        //propiedades
        private string NumDestino
        {
            get { return this.numDestino; }
            set { this.numDestino += value; }
        }

        private string NumOrigen
        {
            get { return this.numOrigen; }
            set { this.numOrigen += value; }
        }

        private int TipoLlamada
        {
            get { return this.tipoLlamada; }
            set { this.tipoLlamada = value; }
        }
        //tablero numerico controles

        //1
        private void btnUno_Click(object sender, EventArgs e)
        {
            SetearBotones(textBoxUltimoFoco, "1");
        }

        //2
        private void btnDos_Click(object sender, EventArgs e)
        {
            SetearBotones(textBoxUltimoFoco, "2");
        }

        //3
        private void btnTres_Click(object sender, EventArgs e)
        {
            SetearBotones(textBoxUltimoFoco, "3");
        }

        //4
        private void btnCuatro_Click(object sender, EventArgs e)
        {
            SetearBotones(textBoxUltimoFoco, "4");
        }

        //5
        private void btnCinco_Click(object sender, EventArgs e)
        {
            SetearBotones(textBoxUltimoFoco, "5");
        }

        //6
        private void btnSeis_Click(object sender, EventArgs e)
        {
            SetearBotones(textBoxUltimoFoco, "6");
        }

        //7
        private void btnSiete_Click(object sender, EventArgs e)
        {
            SetearBotones(textBoxUltimoFoco, "7");
        }

        //8
        private void btnOcho_Click(object sender, EventArgs e)
        {
            SetearBotones(textBoxUltimoFoco, "8");
        }

        //9
        private void btnNueve_Click(object sender, EventArgs e)
        {
            SetearBotones(textBoxUltimoFoco, "9");
        }

        //0
        private void btnCero_Click(object sender, EventArgs e)
        {
            SetearBotones(textBoxUltimoFoco, "0");
        }

        //#
        private void btnHashtag_Click(object sender, EventArgs e)
        {
            if (this.textBoxUltimoFoco == 1)
            {
                if (this.NumDestino == " ")
                {
                    SetearBotones(textBoxUltimoFoco, "#");
                    this.TipoLlamada = 2; //aca confirmo que es provincial
                    this.cmbFranjas.Enabled = true; //hago visible el combobox
                }
                else
                {
                    CartelAlertaError("Error, solo se admiten # al inicio del numero");
                }
            }
            else
            {
                CartelAlertaError("Error, solo se admiten # en el numero de destino...");
            }
        }

        //*
        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            SetearBotones(textBoxUltimoFoco, "*");
        }

        //seteo numeros
        private void SetearBotones(int casillaAllenar, string numeroAasignar)
        {
            if (casillaAllenar > 0 && casillaAllenar < 3)
            {
                switch (casillaAllenar)
                {
                    case 1:
                        this.NumDestino = numeroAasignar;
                        this.txtBxDestino.Focus();
                        this.txtBxDestino.Text = this.NumDestino;
                    break;
                    case 2:
                        this.NumOrigen = numeroAasignar;
                        this.txtBxNumOrigen.Focus();
                        this.txtBxNumOrigen.Text = this.NumOrigen;
                    break;
                }
            }
        }

        //combo box franja horaria
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //controles de ultimo foco
        private void TxtBoxDestinoLeave(object sender, EventArgs e)
        {
            textBoxUltimoFoco = 1;
        }

        private void TxtBoxLeaveOrigen(object sender, EventArgs e)
        {
            textBoxUltimoFoco = 2;
        }

        private void CartelAlertaError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error" , MessageBoxButtons.OK , MessageBoxIcon.Exclamation);
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            if (this.NumDestino != " " && this.NumOrigen != " ")
            {
                if(SetLlamadaAlista())
                {
                    ResetearDatos();
                }
            }
            else
            {
                CartelAlertaError("Error, complete tanto el numero de destino como de origen para ingresar a esta opcion..");
            }
        }

        private bool SetLlamadaAlista()
        {
            bool retorno;
            this.numRandom = new Random();
            float auxDuracionRandom = this.numRandom.Next(1 , 50);
            double auxCostoLocal;
            Provincial.Franja franja;


            retorno = false;
            switch(this.TipoLlamada)
            {
                case 1:
                    this.costoRandomLocal = new Random();
                    auxCostoLocal = ( this.costoRandomLocal.NextDouble()) * 5.6 ;
                    this.auxLocal = new Local(this.NumOrigen, auxDuracionRandom , this.NumDestino ,(float)auxCostoLocal);
                    this.central = this.central + this.auxLocal;
                    retorno = true;
                break;
                case 2:
                    //asi rescato la opcion de franja seleccionada... en el out asigno la franja seleccionada..
                    Enum.TryParse<Provincial.Franja>(cmbFranjas.SelectedValue.ToString(), out franja);
                    this.auxProvincial = new Provincial(this.NumOrigen, franja, auxDuracionRandom, this.NumDestino);
                    this.central = this.central + this.auxProvincial;
                    retorno = true;
                break;
            }
            return retorno;
        }

        private void ResetearDatos()
        {
            this.numDestino = " "; //reseteo directamente el campo, no llamo a la prop, sino me concatena a lo anterior..
            this.numOrigen = " ";
            this.cmbFranjas.Enabled = false;
            this.TipoLlamada = 1;
            this.txtBxDestino.Text = "Num Destino";
            this.txtBxNumOrigen.Text = "Num Origen";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ResetearDatos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
