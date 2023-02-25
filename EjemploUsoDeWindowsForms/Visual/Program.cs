using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //SIEMPRE ES SIEMPRE A CUALQUIER FORMULARIO QUE CREO O A LOS CONTROLES LE CAMBIO EL NOMBRE, NUNCA LE DEJO EL QUE
            //SALE POR DEFECTO AL CREARLO, SIEMPREEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PrincipalWindowsForm()); //acordarse de que si cambio el nombre del form lo modifico aca tambien
                                                        //sino sigue el que ya habia eliminado (form1)...

            //el metodo Application.Run(new PrincipalWindowsForm()) , aca se instancia el formulario (es un objeto, que hereda
                //de la clase Form todas sus propiedades mas las que le agregamos nosotros) y el .Run() va a ejecutarlo



            //El primer form se instancia siempre en el entry point como todos los programas osea el main




        }
    }
}
