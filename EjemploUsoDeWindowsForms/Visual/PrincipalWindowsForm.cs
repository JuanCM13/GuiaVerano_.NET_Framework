using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual //el namespace se puede cambiar como siempre...
{
    public partial class PrincipalWindowsForm : Form // nuestra clase PrincipalWindowsForm que hereda de Form, fijarse los :
                                                        //esto indica que es una subclase de la clase Form.., pertenece al namespace
                                                            //System.Windows.Forms..
                                                            //Ahi esta la magia para que al iniciar el formulario salte la ventanita
                                                            //asi por default....
    {
        public PrincipalWindowsForm()
        {
            //En esta clase es donde vamos a laburar, me paro en el form y apreto f7 y abre esta clase
            InitializeComponent();


            //*EJERCICIO BASICO:

            //Generar dentro de la ventana un cartel para poner el nombre y un mensaje tipo alert que diga hola y el nombre...



        }

        private void PrincipalWindowsForm_Load(object sender, EventArgs e)
        {

        }

        private void Saludar_OnClick(object sender, EventArgs e)
        {
            
            //Para mostrar el nombre que ingresa creo un string aux y concateno el nombre..
            string nombre = this.textBoxNombre.Text; //como pertenece al objeto PrincipalWindowForm lo llamo desde ahi
                                                    //con el nombre que le meti al textBox...
                                                    //y entro a la propiedad text, osea .Text, sino me devuelve el objeto..

                /*if(string.IsNullOrWhiteSpace(nombre)) //metodo static de la clase string, valida si el string esta vacio o null
                {                               //retorna true o false..// isNullOrWhiteSpace valida que no sean solo espacios..

                    MessageBox.Show($"Debe ingresar un nombre.." , "Error!" , MessageBoxButtons.OKCancel , MessageBoxIcon.Error);
                }*/ ///////****TODO ESTO LO PASE A LA FUNCION DE ABAJO, COPIE Y PEGUE ASI QUEDA MAS LIMPIO
            if(ValidarNombre(nombre))
            {
                nombre = nombre.Trim(); //elimina los espacios en blanco que hay detras y delante...tambien esta trimend y trimstart
                                        //trim devuelve un string asi que o lo piso o creo una var auxiliar...
                                        //los strings son por referencia asi que cuando cambiamos o modificamos el contenido de un string
                                        //realmente estamos cambiandole la referencia a otra direccion de memoria del string nuevo creado

                //--------------------------

                /*Ejemplo para instanciar el formulario creado MensajeForm asi creo onda un textbox pero mio...*/

                string aux = $"Hola,{nombre}!"; //guardo el mensaje que antes mostraba en txtBox, y se lo paso como parametro
                                                //al formulario creado MensajeForm....

                MensajeForm mensajeForm = new MensajeForm(aux);  //Instancio el formulario creado, falta mostrarlo todavia
                mensajeForm.ShowDialog(); // aca lo muestro, llamo al objeto y al metodo Show()

                //MessageBox.Show($"Hola,{nombre}!", "saludo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            }
            else
            {
                //Aparte de la respuesta que ya da la funcion ValidarSaludo, agrego este cartelito...

                DialogResult result = MessageBox.Show("Desea Continuar?", "ALERTAA!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if(result == DialogResult.No) 
                {
                     
                    this.Close(); //Asi cierro el formulario completo...

                } 
                /*El enumerado MessegeBox devuelve un tipo llamado DialogResult, si lo guardo en una var auxiliar de ese tipo
                Puedo manipular la respuesta de los botones....*/

                /*La respuesta la manipulo llamando al tipo DialogResult. Lo que me de la opcion que devuelve, aca por eje ese
                 *Enumerado puede devolverme yes or no---*/

            }


            //Clase MessegeBox.Show (metodo tipo alert, tira un cartel medio feo con lo que le pase dentro de las " "..)
            /*Show tiene sobrecargas...
             * ej:  texto
             *  texto + titulo etc
             * */

            //MessegeBoxButtons + . me da una serie de enumerados de acciones fijas a realizar...
            //MessegeBoxButtons no es un metodo sino que es un enumerado....

            //MessegeBoxIcon es otro enumerado, esto ir googleando y probando para ver todo vista..


        }

        private bool ValidarNombre(string dato)
        {
            bool retorno = true;

            if(string.IsNullOrWhiteSpace(dato)) //metodo static de la clase string, valida si el string esta vacio o null
            {                               //retorna true o false..// isNullOrWhiteSpace valida que no sean solo espacios..


                MessageBox.Show($"Debe ingresar un nombre.." , "Error!" , MessageBoxButtons.OKCancel , MessageBoxIcon.Error);
                retorno = false;
            }

            return retorno;
        }

        private void LabelNombre_Click(object sender, EventArgs e)
        {

        }
    }
}
