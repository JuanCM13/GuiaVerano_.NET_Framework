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
    public partial class DataForn : Form
    {
        public DataForn()
        {
            InitializeComponent();
        }

        private void DataForn_Load(object sender, EventArgs e)
        {
            StringBuilder str = new();
            Dictionary<Int32, String> logErroresEstudiantes = null;
            Dictionary<Int32, String> logErroresProfesores = null; 
            //Dictionary<Int32, String> logErroresMaterias;
            Int32 index;

            if(Universidad.Alumnos.Count > 0)
            {
                logErroresEstudiantes = new();
                index = 0;
                
                foreach (Alumno est in Universidad.Alumnos)
                {
                    try
                    {
                        str.AppendLine(est.ToString());
                    }                    
                    catch(Exception ex)
                    {
                        logErroresEstudiantes.Add(index, ex.Message);
                    }
                    index++;
                }
                this.Rbt_Estudiantes.Text = str.ToString();
                str.Clear();
            }
            else
            {
                this.Rbt_Estudiantes.Text = "Listado Sin Alumnos";
            }

            if (Universidad.Profesores.Count > 0)
            {
                logErroresProfesores = new();
                index = 0;

                foreach (Profesor item in Universidad.Profesores)
                {
                    try
                    {
                        str.AppendLine(item.ToString());
                    }
                    catch (Exception ex)
                    {
                        logErroresProfesores.Add(index, ex.Message);
                    }
                    index++;
                }
                this.Rbt_Profesores.Text = str.ToString();
                str.Clear();
            }
            else
            {
                this.Rbt_Profesores.Text = "Listado Sin Profesores";
            }

            if( !(logErroresEstudiantes is null) && !(logErroresProfesores is null))
            {
                if(logErroresEstudiantes.Count > 0)
                {
                    foreach(KeyValuePair<Int32 , String> data in logErroresEstudiantes)
                    {
                        str.AppendLine($"Indice: {data.Key} -- Fallo: {data.Value}");
                    }
                    this.Rbt_ErroresEstudiantes.Text = str.ToString();
                    str.Clear();
                }
                else
                {
                    this.Rbt_ErroresEstudiantes.Text = "All looking good";
                }

                if(logErroresProfesores.Count > 0)
                {
                    foreach (KeyValuePair<Int32, String> data in logErroresProfesores)
                    {
                        str.AppendLine($"Indice: {data.Key} -- Fallo: {data.Value}");
                    }
                    this.Rbt_ErroresProfesores.Text = str.ToString();
                }
                else
                {
                    this.Rbt_ErroresProfesores.Text = "All looking good";
                }
            }
            /*
            if (Universidad.Profesores.Count > 0)
            {
                logErroresProfesores = new();
                index = 0;

                foreach (Materia item in Universidad.Materias)
                {
                    try
                    {
                        str.AppendLine(item.ToString());
                    }
                    catch (Exception ex)
                    {
                        logErroresProfesores.Add(index, ex.Message);
                    }
                    index++;
                }
                this.Rbt_Profesores.Text = str.ToString();
                str.Clear();
            }
            else
            {
                this.Rbt_Profesores.Text = "Listado Sin Alumnos";
            }*/

        }

        private void DataForn_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Seguro que desea cerrar?","Confirme", MessageBoxButtons.OK,MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        } 
    }
}
