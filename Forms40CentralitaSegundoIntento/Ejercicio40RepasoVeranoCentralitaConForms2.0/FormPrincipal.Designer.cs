namespace Ejercicio40RepasoVeranoCentralitaConForms2._0
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLlamar = new System.Windows.Forms.Button();
            this.btnFacLocal = new System.Windows.Forms.Button();
            this.btnFacProvincial = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnFacTotal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLlamar
            // 
            this.btnLlamar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLlamar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLlamar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLlamar.Location = new System.Drawing.Point(36, 31);
            this.btnLlamar.Name = "btnLlamar";
            this.btnLlamar.Size = new System.Drawing.Size(364, 84);
            this.btnLlamar.TabIndex = 0;
            this.btnLlamar.Text = "Generar Llamada";
            this.btnLlamar.UseVisualStyleBackColor = false;
            this.btnLlamar.Click += new System.EventHandler(this.Click_GenerarLlamada);
            // 
            // btnFacLocal
            // 
            this.btnFacLocal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnFacLocal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFacLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacLocal.Location = new System.Drawing.Point(36, 253);
            this.btnFacLocal.Name = "btnFacLocal";
            this.btnFacLocal.Size = new System.Drawing.Size(364, 84);
            this.btnFacLocal.TabIndex = 1;
            this.btnFacLocal.Text = "Facturacion Local";
            this.btnFacLocal.UseVisualStyleBackColor = false;
            this.btnFacLocal.Click += new System.EventHandler(this.btnFacLocal_Click);
            // 
            // btnFacProvincial
            // 
            this.btnFacProvincial.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnFacProvincial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFacProvincial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacProvincial.Location = new System.Drawing.Point(36, 371);
            this.btnFacProvincial.Name = "btnFacProvincial";
            this.btnFacProvincial.Size = new System.Drawing.Size(364, 84);
            this.btnFacProvincial.TabIndex = 2;
            this.btnFacProvincial.Text = "Facturacion Provincial";
            this.btnFacProvincial.UseVisualStyleBackColor = false;
            this.btnFacProvincial.Click += new System.EventHandler(this.btnFacProvincial_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(36, 484);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(364, 84);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnFacTotal
            // 
            this.btnFacTotal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnFacTotal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFacTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacTotal.Location = new System.Drawing.Point(36, 142);
            this.btnFacTotal.Name = "btnFacTotal";
            this.btnFacTotal.Size = new System.Drawing.Size(364, 84);
            this.btnFacTotal.TabIndex = 4;
            this.btnFacTotal.Text = "Facturacion Total";
            this.btnFacTotal.UseVisualStyleBackColor = false;
            this.btnFacTotal.Click += new System.EventHandler(this.btnFacTotal_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(441, 605);
            this.Controls.Add(this.btnFacTotal);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnFacProvincial);
            this.Controls.Add(this.btnFacLocal);
            this.Controls.Add(this.btnLlamar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Central";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLlamar;
        private System.Windows.Forms.Button btnFacLocal;
        private System.Windows.Forms.Button btnFacProvincial;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnFacTotal;
    }
}

