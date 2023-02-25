using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepasoVeranoEjercicio28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void BtnMostrarData_Click(object sender, EventArgs e)
        {
            //Recorrer el texto, agregar las palabras a un diccionario junto con la cantidad de veces que aparece

            //Para recorrer la lista tengo que pasar este richTextbox a un string y separarlo por espacios en un array

            string aux = this.richTxt.Text;
            String[] listadoPalabras = aux.Split(' ');
            Dictionary<string, int> diccionario = new Dictionary<string, int>();
            string palabraAcomparar = null;
            int contadorPalabras = 0;
            string resultado = null;
            string topTres = null;
            int controlTopTres = 0;

            //ordeno el array ascendentemente asi me queda todo ordenado alfabeticamente, entonces si tengo palabras:
            // pepe hola zaira pepe hola
            // mequeda hola hola pepe pepe zaira, asi recorro uno a uno y pregunto si el actual es igual al anterior,
            //si es igual incremento el contador, sino , asigno al diccionario y paso a comparar el nuevo elemento..

            Array.Sort(listadoPalabras);

            for (int i = 0; i < listadoPalabras.Length; i++)
            {
                if (i == 0) //uso for asi me queda separado el indice de guia del indice del array, sino usaba un foreach
                {
                    palabraAcomparar = listadoPalabras[i];
                    contadorPalabras = 1;
                }
                else
                {
                    if (palabraAcomparar == listadoPalabras[i])
                    {
                        contadorPalabras++;
                    }
                    else
                    {
                        diccionario.Add(palabraAcomparar, contadorPalabras);
                        palabraAcomparar = listadoPalabras[i];
                        contadorPalabras = 1;
                    } 
                }
            }

            //para ordenar el diccionario tuve que incluir el namespace Linq, trae funciones utiles para enumerados
            //orderBy(key => key.Value) ordena ascendentemente
            //orderByDescending (key => key.Value) ordena descendentemente
            //para conseguir los top 3 como esta ordenado descendentemente los primeros 3 ya estan ordenados, cree
            //un contador y dentro del foreach asigne dentro de un if los primeros 3 puestos..
            //PD: creo que hay una funcion que se le agrega al orderBy pero no logre encontrarla, esta first que devuelve solo el primero..
            //pueede ser take, investigar..

            foreach (KeyValuePair<string, int> palabra in diccionario.OrderByDescending(key => key.Value))
            {
                resultado += $" \n Palabra: {palabra.Key} Cant Veces: {palabra.Value}";

                controlTopTres++;
                if (controlTopTres == 3) //si dejo controlTopTres < 3 y en cada vuelta acumulo resultado, como se van concatenando 
                {                       //en resultado siempre, me suma por ejemplo, carla, carla Maria, carla maria jose etc
                    topTres += resultado;
                }
            }

            this.richTxt.Text = resultado;
            
            if(topTres != null) //osea que hay algun valor cargado..
            {
                MessageBox.Show($"Top 3 Puestos: {topTres}", "Resultado" , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
