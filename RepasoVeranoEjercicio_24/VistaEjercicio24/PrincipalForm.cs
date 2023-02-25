using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ConversorTemperaturas;

namespace VistaEjercicio24
{
    public partial class PrincipalForm : Form
    {
        //propiedades..
        Fahrenheit datoFahrenheit;
        Celsius datoCelsius;
        Kelvin datoKelvin;

        Fahrenheit auxF;
        Celsius auxC;
        Kelvin auxK;

        public PrincipalForm()
        {
            InitializeComponent();
            inityData();
        }

        private void inityData()
        {
            this.datoFahrenheit = 0;
            this.datoCelsius = 0;
            this.datoKelvin = 0;
        }

        //seteo de datos a convertir

        //Seteo Fahrenheit
        private void txtF_Leave(object sender, EventArgs e)
        {
            string dato;
            double aux;

            dato = this.txtBxFahrenheitAconvertir.Text;

            if(ValidateTemperatureData(dato))
            {
                aux = double.Parse(dato); //como ya se que al dar true ValidateTemperatureData es un double el dato
                                            //parseo directamente y ahi asigno el valor...
                datoFahrenheit = aux;
            }
            else
            {
                txtBxFahrenheitAconvertir.Focus();
            }

        }


        //Seteo Celsius
        private void txtC_Leave(object sender, EventArgs e)
        {
            string dato;
            double aux;

            dato = this.txtBxCelsiusAconvertir.Text;

            if (ValidateTemperatureData(dato))
            {
                aux = double.Parse(dato); 
                datoCelsius = aux;
            }
            else
            {
                txtBxCelsiusAconvertir.Focus();
            }
        }


        //Seteo Kelvin
        private void txtK_Leave(object sender, EventArgs e)
        {
            string dato;
            double aux;

            dato = this.txtBxKelvinAconvertir.Text;

            if (ValidateTemperatureData(dato))
            {
                aux = double.Parse(dato);
                datoKelvin = aux;
            }
            else
            {
                txtBxKelvinAconvertir.Focus();
            }
        }

        //Funcion validar temperatura, recibe string valida si es double si es da true, sino muestra error y da false
        private bool ValidateTemperatureData(string data)
        {
            double aux;

            if(double.TryParse(data , out aux))
            {
                return true;
            }

            MessageBox.Show("Error, solo se admiten numeros..", "Alerta", MessageBoxButtons.OK);

            return false;
        }


        //Botones Conversion y asignacion

        //-----------Fahrenheit -> c/k
        private void btnConvertF_Click(object sender, EventArgs e)
        {
            double auxDouble;

            if(EstaCargado(this.txtBxFahrenheitAconvertir.Text))
            {
                //Fah to Cel
                auxC = (Celsius)datoFahrenheit;
                auxDouble = auxC.GetCantidad();
                this.txtBxF_C.Text = auxDouble.ToString("#,###.00");

                //Fah to Kel
                auxK = (Kelvin)datoFahrenheit;
                auxDouble = auxK.GetCantidad();
                this.txtBxF_K.Text = auxDouble.ToString("#,###.00");

                //Fah to Fah
                auxDouble = datoFahrenheit.GetCantidad();
                this.txtBxF_F.Text = auxDouble.ToString("#,###.00");
            }
            else
            {
                this.txtBxFahrenheitAconvertir.Focus();
            }
        }


        //-----------Celsius -> f/k
        private void btnConvertC_Click(object sender, EventArgs e)
        {
            double auxDouble;

            if (EstaCargado(this.txtBxCelsiusAconvertir.Text))
            {
                //Cel to Fah
                auxF = (Fahrenheit)datoCelsius;
                auxDouble = auxF.GetCantidad();
                this.txtBxC_F.Text = auxDouble.ToString("#,###.00");

                //Cel to Kel
                auxK = (Kelvin)datoCelsius;
                auxDouble = auxK.GetCantidad();
                this.txtBxC_K.Text = auxDouble.ToString("#,###.00");

                //Cel to Cel
                auxDouble = datoCelsius.GetCantidad();
                this.txtBxC_C.Text = auxDouble.ToString("#,###.00");
            }
            else
            {
                this.txtBxCelsiusAconvertir.Focus();
            }
        }


        //-----------Kelvin -> f/c
        private void btnConvertK_Click(object sender, EventArgs e)
        {
            double auxDouble;

            if (EstaCargado(this.txtBxKelvinAconvertir.Text))
            {
                //Kel to Fah
                auxF = (Fahrenheit)datoKelvin;
                auxDouble = auxF.GetCantidad();
                this.txtBxK_F.Text = auxDouble.ToString("#,###.00");

                //Kel to Cel
                auxC = (Celsius)datoKelvin;
                auxDouble = auxC.GetCantidad();
                this.txtBxK_C.Text = auxDouble.ToString("#,###.00");

                //Kel to Kel
                auxDouble = datoKelvin.GetCantidad();
                this.txtBxK_K.Text = auxDouble.ToString("#,###.00");
            }
            else
            {
                this.txtBxKelvinAconvertir.Focus();
            }
        }


        //Funcion para validar si antes de convertir, el txtbx de ingreso de cantidad esta cargado o no... true si esta cargado, false sino
        private bool EstaCargado(string dato)
        {
            double aux;

            if(double.TryParse(dato , out aux) == false)
            {
                MessageBox.Show("Error, el campo de ingreso de cantidad de grados debe estar cargada para que funcione..","Alert",MessageBoxButtons.OK, MessageBoxIcon.Exclamation  );
                return false;
            }

            return true;
        }

    }
}
