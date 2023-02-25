using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Monedas;

namespace Ejercicio23HechoDeVueltaRepasoVerano
{
    public partial class PrincipalForm : Form
    {
        //atributos
        static Euro monedaEuro;
        static Dolares monedaDolar;
        static Pesos monedaPeso;

        private Euro auxEuro;
        private Pesos auxPesos;
        private Dolares auxDolares;

        public PrincipalForm()
        {
            InitializeComponent();
            formMonedas();
        }


        //Metodos...
        public static void formMonedas()
        {
            //inicializo las cantidades en Cero, automaticamente cuando se cran los objetos, el constructor estatico les va a setear
            //las cotizaciones por default...
            
            monedaEuro = 0;
            //double auxCantidad = monedaEuro.GetCantidad();
            //double auxCotizacion = Euro.GetCotizacion();

            monedaDolar = 0;
            //auxCantidad = monedaDolar.GetCantidad();
            //auxCotizacion = Dolares.GetCotizacion();

            monedaPeso = 0;
            //auxCantidad = monedaDolar.GetCantidad();
            //auxCotizacion = Pesos.GetCotizacion();
        }

        private void resetearCotizaciones()
        {
            monedaEuro.setCotizacion(1.08);
            monedaPeso.setCotizacion(66);
        }


        //-----------------------Uso boton candado
        private void ClickLock(object sender, EventArgs e)
        {
            if(LockButtom.ImageIndex == 1)
            {
                //candado cerrado, pasa a estar abierto

                this.LockButtom.ImageIndex = 0;
                this.txtBxCotizacionE.Enabled = true;
                this.txtBxCotizacionD.Enabled = true;
                this.txtBxCotizacionP.Enabled = true;

            }
            else
            {
                if (LockButtom.ImageIndex == 0)
                {
                    this.txtBxCotizacionE.Text = "0.89";
                    this.txtBxCotizacionD.Text = "1";
                    this.txtBxCotizacionP.Text = "0.023";
                    //candado abierto, pasa a estar cerrado

                    this.LockButtom.ImageIndex = 1;
                    this.resetearCotizaciones(); //vuelvo a setear las cotizaciones a las default
                    this.txtBxCotizacionE.Enabled = false;
                    this.txtBxCotizacionD.Enabled = false;
                    this.txtBxCotizacionP.Enabled = false;
                }
            }
        }


        //-----------------------Validacion de ingreso de la cotizacion

        //txtBx Euro
        private void txtCotizacionEuro_Leave(object sender, EventArgs e)
        {
            string auxCotzEuro;
            double monedaConvertida;

            auxCotzEuro = this.txtBxCotizacionE.Text;

            if(ValidarMoneda(auxCotzEuro , out monedaConvertida) && monedaConvertida != -666)
            {
                monedaEuro.setCotizacion(monedaConvertida);
                double auxCotizacion = Euro.GetCotizacion();
                //MessageBox.Show("La cotizacion del euro es: " + auxCotizacion.ToString());
            }
            else
            {
                this.txtBxCotizacionE.Focus();
            }
        }

        //txtBx Dolar
        private void txtCotizacionDolar_Leave(object sender, EventArgs e)
        {
            this.txtBxCotizacionD.Text = "1";
        }

        //txtBx Peso
        private void txtCotizacionPeso_Leave(object sender, EventArgs e)
        {
            string auxCotzPeso;
            double monedaConvertida;

            auxCotzPeso = this.txtBxCotizacionP.Text;

            if (ValidarMoneda(auxCotzPeso, out monedaConvertida) && monedaConvertida != -666)
            {
                monedaPeso.setCotizacion(monedaConvertida);
            }
            else
            {
                this.txtBxCotizacionP.Focus();
            }
        }

      
        //funcion validacion
        private bool ValidarMoneda(string dato, out double cantidadConvertida)
        {
            double auxDouble;
            bool ret;
            cantidadConvertida = -666;

            if ((double.TryParse(dato, out auxDouble) && auxDouble > -1))
            {
                ret = true;
                cantidadConvertida = auxDouble;
            }
            else
            {
                MessageBox.Show("Error,se admiten solo numeros positivos..", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ret = false;
            }

            return ret;
        }

        
        //-----------------------Validacion de ingreso de la Cantidad a convertir

        //Cantidad Euros
        private void txtCantidadEuro_Leave(object sender, EventArgs e)
        {
            string auxCantEuro;
            double monedaConvertida;

            auxCantEuro = this.txtbxIngresoE.Text;

            if (ValidarMoneda(auxCantEuro, out monedaConvertida) && monedaConvertida != -666)
            {
                monedaEuro.cantidad = monedaConvertida;
            }
            else
            {
                this.txtbxIngresoE.Focus();
            }

        }

        //Cantidad Dolares
        private void txtCantidadDolares_Leave(object sender, EventArgs e)
        {
            string auxCantDolares;
            double monedaConvertida;

            auxCantDolares = this.txtbxIngresoD.Text;

            if (ValidarMoneda(auxCantDolares, out monedaConvertida) && monedaConvertida != -666)
            {
                monedaDolar.cantidad = monedaConvertida;
            }
            else
            {
                this.txtbxIngresoD.Focus();
            }
        }

        //Cantidad Pesos
        private void txtCantidadPesos_Leave(object sender, EventArgs e)
        {
            string auxCantPesos;
            double monedaConvertida;

            auxCantPesos = this.txtbxIngresoP.Text;

            if (ValidarMoneda(auxCantPesos, out monedaConvertida) && monedaConvertida != -666)
            {
                monedaPeso.cantidad = monedaConvertida;
            }
            else
            {
                this.txtbxIngresoP.Focus();
            }
        }

        //-----------------------Conversiones Por boton

        //Convertir E->p/d
        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            if(validarIngresoCantidadDivisas(this.txtbxIngresoE.Text) == 0)
            {
                double auxCantidadConvertida;

                //conversion Euro -> Dolar
                auxDolares = (Dolares)monedaEuro;
                auxCantidadConvertida = auxDolares.GetCantidad();
                this.txtbxResultadoE_D.Text = auxCantidadConvertida.ToString("#,###.00");

                //conversion Euro -> Pesos
                auxPesos = (Pesos)monedaEuro;
                auxCantidadConvertida = auxPesos.GetCantidad();
                this.txtbxResultadoE_P.Text = auxCantidadConvertida.ToString("#,###.00");

                //Euros a euros.. duh
                auxCantidadConvertida = monedaEuro.GetCantidad();
                this.txtbxResultadoE_E.Text = auxCantidadConvertida.ToString("#,###.00");
            }
            else
            {
                this.txtbxIngresoE.Focus();
            }
        }

        //Convertir D-> p/e
        private void btnConvertirDolares_Click(object sender, EventArgs e)
        {
            if (validarIngresoCantidadDivisas(this.txtbxIngresoD.Text) == 0)
            {
                double auxCantidadConvertida;

                //conversion Dolar -> Euro
                auxEuro = (Euro)monedaDolar;
                auxCantidadConvertida = auxEuro.GetCantidad();
                this.txtbxResultadoD_E.Text = auxCantidadConvertida.ToString("#,###.00");

                //conversion Dolar -> Pesos
                auxPesos = (Pesos)monedaDolar;
                auxCantidadConvertida = auxPesos.GetCantidad();
                this.txtbxResultadoD_P.Text = auxCantidadConvertida.ToString("#,###.00");

                //Dolar a Dolar.. duh
                auxCantidadConvertida = monedaDolar.GetCantidad();
                this.txtbxResultadoD_D.Text = auxCantidadConvertida.ToString("#,###.00");
            }
            else
            {
                this.txtbxIngresoD.Focus();
            }
        }

        //Convertir P-> d/e
        private void btnConvertPesos_Click(object sender, EventArgs e)
        {
            if (validarIngresoCantidadDivisas(this.txtbxIngresoP.Text) == 0)
            {
                double auxCantidadConvertida;

                //conversion Pesos -> Euro
                auxEuro = (Euro)monedaPeso;
                auxCantidadConvertida = auxEuro.GetCantidad();
                this.txtbxResultadoP_E.Text = auxCantidadConvertida.ToString("#,###.00");

                //conversion Pesos -> Dolares
                auxDolares = (Dolares)monedaPeso;
                auxCantidadConvertida = auxDolares.GetCantidad();
                this.txtbxResultadoP_D.Text = auxCantidadConvertida.ToString("#,###.00");

                //Pesos a Pesos.. duh
                auxCantidadConvertida = monedaPeso.GetCantidad();
                this.txtbxResultadoP_P.Text = auxCantidadConvertida.ToString("#,###.00");
            }
            else
            {
                this.txtbxIngresoP.Focus();
            }
        }

        //Validar ingreso cantidad de divisa a convertir

        private int validarIngresoCantidadDivisas(string dato)
        {

            if (dato == null)
            {
                MessageBox.Show("Error, debe completar el campo para operar..", "Alerta", MessageBoxButtons.OK);
                return -1; 
            }

            return 0;
        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {

        }

    }
}
