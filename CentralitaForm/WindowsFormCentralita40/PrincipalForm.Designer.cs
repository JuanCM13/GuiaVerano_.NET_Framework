namespace WindowsFormCentralita40
{
    partial class PrincipalForm
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
            this.btnGenerarLlamada = new System.Windows.Forms.Button();
            this.btnFacturacionLocal = new System.Windows.Forms.Button();
            this.btnFacturacionProvincial = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnFacturacionTotal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerarLlamada
            // 
            this.btnGenerarLlamada.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGenerarLlamada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarLlamada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarLlamada.Location = new System.Drawing.Point(24, 24);
            this.btnGenerarLlamada.Name = "btnGenerarLlamada";
            this.btnGenerarLlamada.Size = new System.Drawing.Size(409, 94);
            this.btnGenerarLlamada.TabIndex = 0;
            this.btnGenerarLlamada.Text = "Generar Llamada";
            this.btnGenerarLlamada.UseVisualStyleBackColor = false;
            // 
            // btnFacturacionLocal
            // 
            this.btnFacturacionLocal.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnFacturacionLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturacionLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturacionLocal.Location = new System.Drawing.Point(24, 277);
            this.btnFacturacionLocal.Name = "btnFacturacionLocal";
            this.btnFacturacionLocal.Size = new System.Drawing.Size(409, 94);
            this.btnFacturacionLocal.TabIndex = 1;
            this.btnFacturacionLocal.Text = "Facturacion Local";
            this.btnFacturacionLocal.UseVisualStyleBackColor = false;
            // 
            // btnFacturacionProvincial
            // 
            this.btnFacturacionProvincial.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnFacturacionProvincial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturacionProvincial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturacionProvincial.Location = new System.Drawing.Point(24, 405);
            this.btnFacturacionProvincial.Name = "btnFacturacionProvincial";
            this.btnFacturacionProvincial.Size = new System.Drawing.Size(409, 94);
            this.btnFacturacionProvincial.TabIndex = 2;
            this.btnFacturacionProvincial.Text = "Facturacion Provincial";
            this.btnFacturacionProvincial.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(25, 536);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(409, 94);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnFacturacionTotal
            // 
            this.btnFacturacionTotal.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnFacturacionTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturacionTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturacionTotal.Location = new System.Drawing.Point(25, 145);
            this.btnFacturacionTotal.Name = "btnFacturacionTotal";
            this.btnFacturacionTotal.Size = new System.Drawing.Size(409, 94);
            this.btnFacturacionTotal.TabIndex = 4;
            this.btnFacturacionTotal.Text = "Facturacion Total";
            this.btnFacturacionTotal.UseVisualStyleBackColor = false;
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(458, 642);
            this.Controls.Add(this.btnFacturacionTotal);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnFacturacionProvincial);
            this.Controls.Add(this.btnFacturacionLocal);
            this.Controls.Add(this.btnGenerarLlamada);
            this.Name = "PrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Central Telefonica";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarLlamada;
        private System.Windows.Forms.Button btnFacturacionLocal;
        private System.Windows.Forms.Button btnFacturacionProvincial;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnFacturacionTotal;
    }
}

