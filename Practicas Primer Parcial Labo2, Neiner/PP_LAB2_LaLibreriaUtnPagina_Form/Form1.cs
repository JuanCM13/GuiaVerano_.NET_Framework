using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PP_LAB2_LaLibreriaUtnPagina_Entidades;

namespace PP_LAB2_LaLibreriaUtnPagina_Form
{
    public partial class Form1 : Form
    {
        Vendedor vendedor;
        public Form1()
        {
            InitializeComponent();
            this.vendedor = new Vendedor("Jorge");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Biografia p1 = (Biografia)"Life (Keith Richards)";
            Biografia p2 = new Biografia("White line fever (Lemmy)", 5);
            Biografia p3 = new Biografia("Commando (Johnny Ramone)", 2, 5000);
            Comic p4 = new Comic("La Muerte de Superman (Superman)", true, 1, 1850);
            Comic p5 = new Comic("Año Uno (Batman)", false, 3, 1270);

            this.lstStock.Items.Add(p1);
            this.lstStock.Items.Add(p2);
            this.lstStock.Items.Add(p3);
            this.lstStock.Items.Add(p4);
            this.lstStock.Items.Add(p5);

        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if(this.lstStock.SelectedItem is not null)
            {
                if( (vendedor + (Publicacion)this.lstStock.SelectedItem) == false)
                {
                    MessageBox.Show("Error,ya no hay mas stock!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error, elija una publicacion!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVerInforme_Click(object sender, EventArgs e)
        {
            this.rtbInforme.Clear();
            this.rtbInforme.Text = this.vendedor.ObtenerInformeDeVentas();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Seguro que desea salir?","Alerta",MessageBoxButtons.OKCancel,MessageBoxIcon.Hand) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
