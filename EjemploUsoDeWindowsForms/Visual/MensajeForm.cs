using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual
{
    public partial class MensajeForm : Form
    {
        public MensajeForm(string mensaje) //como es un constructor cualquiera, le mando que reciba el string mensaje y que
        {                                   //cuando se ejecute el this.labelSaludo.Text = mensaje....
            InitializeComponent();
            this.labelSaludo.Text = mensaje; //string.Empty; //con string.Empty devuelve un string vacio "", aca llamo a la clase
                                                  //MensajeForm, al atributo LabelSaludo (el label que cree dentro) y le piso
                                                  //la variable string .Text con el string vacio...
            

        }
    }
}
