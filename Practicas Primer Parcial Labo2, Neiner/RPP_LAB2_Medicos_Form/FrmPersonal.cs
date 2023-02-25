using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPP_LABO2_Medicos_Entidades;
namespace RPP_LAB2_Medicos_Form
{
    public abstract partial class FrmPersonal : Form
    {
        public abstract Personal PersonalDelForm { get; }


        public FrmPersonal()
        {
            InitializeComponent();
        }
    }
}
