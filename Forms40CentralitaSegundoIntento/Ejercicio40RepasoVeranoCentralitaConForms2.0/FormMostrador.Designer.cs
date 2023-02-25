namespace Ejercicio40RepasoVeranoCentralitaConForms2._0
{
    partial class FormMostrador
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnFormMostradorSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(24, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(498, 595);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnFormMostradorSalir
            // 
            this.btnFormMostradorSalir.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnFormMostradorSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormMostradorSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormMostradorSalir.Location = new System.Drawing.Point(391, 613);
            this.btnFormMostradorSalir.Name = "btnFormMostradorSalir";
            this.btnFormMostradorSalir.Size = new System.Drawing.Size(112, 35);
            this.btnFormMostradorSalir.TabIndex = 1;
            this.btnFormMostradorSalir.Text = "Salir";
            this.btnFormMostradorSalir.UseVisualStyleBackColor = false;
            this.btnFormMostradorSalir.Click += new System.EventHandler(this.btnFormMostradorSalir_Click);
            // 
            // FormMostrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(545, 676);
            this.Controls.Add(this.btnFormMostradorSalir);
            this.Controls.Add(this.richTextBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMostrador";
            this.Text = "FormMostrador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnFormMostradorSalir;
    }
}