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
namespace WindowsFormCentralita40
{
    public partial class FrmLlamador : Form
    {
        Centralita central;
        public FrmLlamador(Centralita c)
        {
            InitializeComponent();
            this.central = c;            
        }

        public string GetCentralitaLlamador
        {
            get { return this.central.ToString(); }
        }
    }
}
