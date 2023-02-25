using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ConversionesB_D;

namespace VistaEjercicio24
{
    public partial class PrincipalForm : Form
    {
        public static NumeroBinario numBinario;
        public static NumeroDecimal numDecimal;
        

        public PrincipalForm()
        {
            InitializeComponent();
            initObjs();
        }

        private void initObjs()
        {
            PrincipalForm.numBinario = new NumeroBinario();
            PrincipalForm.numDecimal = new NumeroDecimal();
        }


        //Validacion y asignaciones de objetos


        //Numero Binario
        private void TxtIngresoBinario_Leave(object sender, EventArgs e)
        {
            string dato = this.txtBxConvertBtoD.Text;

            if(ValidarParametroBinario(dato))
            {
                numBinario = dato;
            }
            else
            {
                MensajeErrorValidacionDoBMensajeErrorValidacionDoB("Error, el dato debe estar compuesto solo por 1s y 0s..", "Alerta");
                this.txtBxConvertBtoD.Focus();
            }
        }


        //Numero Decimal
        private void TxtIngresoDecimal_Leave(object sender, EventArgs e)
        {
            int aux;
            string auxS = this.txtBxConvertDtoB.Text;

            if (int.TryParse(auxS, out aux) && aux > -1 && aux < 257)
            {
                numDecimal.numero = aux;
            }
            else
            {
                MensajeErrorValidacionDoBMensajeErrorValidacionDoB("Error, solo se admiten numeros entre 0 y 256..", "Alerta");
                this.txtBxConvertDtoB.Focus();
            }
        }


        //funcion para validar si el parametro es binario, la tengo tambien en el Conversor, pero no me deja invocarla
        //Asumo que es por que ese metodo tiene que ser invocado por el objeto...
        public bool ValidarParametroBinario(string dato)
        {
            bool ret;
            char[] arrayAux = dato.ToCharArray();

            ret = true; //todo ok
            for (int i = 0; i < arrayAux.Length; i++)
            {
                if (arrayAux[i] != '1' && arrayAux[i] != '0')
                {
                    ret = false;//no esta formado solo por 1 y 0
                    break;
                }
            }
            return ret;
        }


        //Crea mensaje de error atravez de un messegeBox.Show()
        private void MensajeErrorValidacionDoBMensajeErrorValidacionDoB(string menUno , string menDos)
        {
            MessageBox.Show(menUno, menDos, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        //Conversion por botones..


        //Binario -> Decimal
        private void btnConvertBtoD_Click(object sender, EventArgs e)
        {
            double aux;
            NumeroDecimal auxD;
            string auxS = this.txtBxConvertBtoD.Text;

            if(String.IsNullOrEmpty(auxS) == false)
            {
                auxD = (NumeroDecimal)numBinario;
                aux = auxD.GetCantidad();
                this.txtBxBtoD.Text = aux.ToString();
            }
            else
            {
                MensajeErrorValidacionDoBMensajeErrorValidacionDoB("Error, para operar debe completarse el campo..", "Error");
                this.txtBxConvertBtoD.Focus();
            }
        }

        private void btnConvertDtoB_Click(object sender, EventArgs e)
        {
            string aux;
            NumeroBinario auxB = (NumeroBinario)numDecimal;
            aux = this.txtBxConvertDtoB.Text;

            if (String.IsNullOrEmpty(aux) == false)
            {
                aux = auxB.GetCantidad();
                this.txtBxDtoB.Text = aux;
            }
            else
            {
                MensajeErrorValidacionDoBMensajeErrorValidacionDoB("Error, para operar debe completarse el campo..", "Error");
                this.txtBxConvertDtoB.Focus();
            }      
        }

        //Decimal -> Binario



    }
}
