using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaUniversidad;

namespace RepasoSabadosTestUnitariosYexcepciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Tbx_User.Text = "123123";
            this.Tbx_Password.Text = "lucas123";
        }

        private void Btn_Logear_Click(object sender, EventArgs e)
        {
            String id = this.Tbx_User.Text;
            String pass = this.Tbx_Password.Text;
            StringBuilder str = new StringBuilder(); 

            try
            {
                if(Universidad.Loguear(Int32.Parse(id) , pass))
                {
                    this.Hide();
                    new DataForn().ShowDialog();
                    this.Show();
                }
            }
            catch(NullReferenceException ex)
            {
                str.AppendLine($"Error, alguno de los campos llenos fue vacio..\n{ex.Message}");
                this.MostrarMsjeError(str.ToString());
            }
            catch(FormatException ex)
            {
                str.AppendLine($"Error, el ususario solo puede ser estar compuesto por numeros....\n{ex.Message}");
                this.MostrarMsjeError(str.ToString());
            }  
            catch(UnauthorizedAccessException ex)
            {
                str.AppendLine($"Error, el ususario no tiene acceso....\n{ex.Message}");
                this.MostrarMsjeError(str.ToString());
            }
            catch (Exception ex)
            {
                this.MostrarMsjeError(ex.Message);
            }
        }

        private void MostrarMsjeError(String msje)
        {
            if(!(msje is null))
            {
                MessageBox.Show(msje, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
