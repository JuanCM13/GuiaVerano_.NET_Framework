
namespace RepasoSabadosTestUnitariosYexcepciones
{
    partial class DataForn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Rbt_Estudiantes = new System.Windows.Forms.RichTextBox();
            this.Rbt_Profesores = new System.Windows.Forms.RichTextBox();
            this.Rbt_ErroresEstudiantes = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Rbt_ErroresProfesores = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Rbt_Estudiantes
            // 
            this.Rbt_Estudiantes.Location = new System.Drawing.Point(13, 50);
            this.Rbt_Estudiantes.Name = "Rbt_Estudiantes";
            this.Rbt_Estudiantes.Size = new System.Drawing.Size(225, 569);
            this.Rbt_Estudiantes.TabIndex = 0;
            this.Rbt_Estudiantes.Text = "";
            // 
            // Rbt_Profesores
            // 
            this.Rbt_Profesores.Location = new System.Drawing.Point(265, 50);
            this.Rbt_Profesores.Name = "Rbt_Profesores";
            this.Rbt_Profesores.Size = new System.Drawing.Size(225, 569);
            this.Rbt_Profesores.TabIndex = 1;
            this.Rbt_Profesores.Text = "";
            // 
            // Rbt_ErroresEstudiantes
            // 
            this.Rbt_ErroresEstudiantes.Location = new System.Drawing.Point(520, 50);
            this.Rbt_ErroresEstudiantes.Name = "Rbt_ErroresEstudiantes";
            this.Rbt_ErroresEstudiantes.Size = new System.Drawing.Size(282, 245);
            this.Rbt_ErroresEstudiantes.TabIndex = 2;
            this.Rbt_ErroresEstudiantes.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(51, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Estudiantes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(520, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Error Estudiantes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(305, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Profesores";
            // 
            // Rbt_ErroresProfesores
            // 
            this.Rbt_ErroresProfesores.Location = new System.Drawing.Point(520, 374);
            this.Rbt_ErroresProfesores.Name = "Rbt_ErroresProfesores";
            this.Rbt_ErroresProfesores.Size = new System.Drawing.Size(282, 245);
            this.Rbt_ErroresProfesores.TabIndex = 9;
            this.Rbt_ErroresProfesores.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(520, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "Error Profesores";
            // 
            // DataForn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 631);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Rbt_ErroresProfesores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rbt_ErroresEstudiantes);
            this.Controls.Add(this.Rbt_Profesores);
            this.Controls.Add(this.Rbt_Estudiantes);
            this.Name = "DataForn";
            this.Text = "DataForn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DataForn_FormClosing);
            this.Load += new System.EventHandler(this.DataForn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Rbt_Estudiantes;
        private System.Windows.Forms.RichTextBox Rbt_Profesores;
        private System.Windows.Forms.RichTextBox Rbt_ErroresEstudiantes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox Rbt_ErroresProfesores;
        private System.Windows.Forms.Label label4;
    }
}