using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormCentralita40
{
    public partial class DialogForm1 : Form
    {
        private string numDestino;
        private string numOrigen;


        private string NumDestino
        {
            get { return this.numDestino; }
            set { this.numDestino += value; }
        }

        public DialogForm1()
        {
            InitializeComponent();
        }

        private void Btn_LlamarEvento(object sender, EventArgs e)
        {
        
        }

        private void BtnLeaveUno(object sender, EventArgs e)
        {
            this.NumDestino = "1";
            this.txtBxNumDestino.Text = this.NumDestino;
        }

        private void BtnLeaveDos(object sender, EventArgs e)
        {
            this.NumDestino = "2";
            this.txtBxNumDestino.Text = this.NumDestino;
        }

        private void BtnLeaveTres(object sender, EventArgs e)
        {
            this.NumDestino = "3";
            this.txtBxNumDestino.Text = this.NumDestino;
        }

        private void BtnLeaveCuatro(object sender, EventArgs e)
        {
            this.NumDestino = "4";
            this.txtBxNumDestino.Text = this.NumDestino;
        }

        private void BtnLeaveCinco(object sender, EventArgs e)
        {
            this.NumDestino = "5";
            this.txtBxNumDestino.Text = this.NumDestino;
        }

        private void BtnLeaveSeis(object sender, EventArgs e)
        {
            this.NumDestino = "6";
            this.txtBxNumDestino.Text = this.NumDestino;
        }

        private void BtnLeaveSiete(object sender, EventArgs e)
        {
            this.NumDestino = "7";
            this.txtBxNumDestino.Text = this.NumDestino;
        }

        private void BtnLeaveOcho(object sender, EventArgs e)
        {
            this.NumDestino = "8";
            this.txtBxNumDestino.Text = this.NumDestino;
        }

        private void BtnLeaveNueve(object sender, EventArgs e)
        {
            this.NumDestino = "9";
            this.txtBxNumDestino.Text = this.NumDestino;
        }

        private void BtnLeaveCero(object sender, EventArgs e)
        {
            this.NumDestino = "0";
            this.txtBxNumDestino.Text = this.NumDestino;
        }

        private void BtnLeaveSharp(object sender, EventArgs e)
        {
            if(this.NumDestino.Length < 0)
            {
                this.NumDestino = "#";
                this.txtBxNumDestino.Text = this.NumDestino;
            }
            else
            {
                MessegeBoxDeError("Error, solo se admiten # al comienzo..");
            }
        }

        private void MessegeBoxDeError(string dato)
        {
            if(dato != null)
            {
                MessageBox.Show(dato , "Error", MessageBoxButtons.OK);
            }
        }
    }
}
