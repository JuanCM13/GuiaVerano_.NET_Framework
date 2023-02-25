namespace VistaEjercicio24
{
    partial class PrincipalForm
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
            this.lblBinarioAdecimal = new System.Windows.Forms.Label();
            this.lblDecimalAbinario = new System.Windows.Forms.Label();
            this.txtBxBtoD = new System.Windows.Forms.TextBox();
            this.txtBxDtoB = new System.Windows.Forms.TextBox();
            this.btnConvertBtoD = new System.Windows.Forms.Button();
            this.txtBxConvertBtoD = new System.Windows.Forms.TextBox();
            this.txtBxConvertDtoB = new System.Windows.Forms.TextBox();
            this.btnConvertDtoB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBinarioAdecimal
            // 
            this.lblBinarioAdecimal.AutoSize = true;
            this.lblBinarioAdecimal.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBinarioAdecimal.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblBinarioAdecimal.Location = new System.Drawing.Point(12, 51);
            this.lblBinarioAdecimal.Name = "lblBinarioAdecimal";
            this.lblBinarioAdecimal.Size = new System.Drawing.Size(178, 27);
            this.lblBinarioAdecimal.TabIndex = 0;
            this.lblBinarioAdecimal.Text = "Binario a Decimal";
            // 
            // lblDecimalAbinario
            // 
            this.lblDecimalAbinario.AutoSize = true;
            this.lblDecimalAbinario.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecimalAbinario.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblDecimalAbinario.Location = new System.Drawing.Point(12, 108);
            this.lblDecimalAbinario.Name = "lblDecimalAbinario";
            this.lblDecimalAbinario.Size = new System.Drawing.Size(178, 27);
            this.lblDecimalAbinario.TabIndex = 3;
            this.lblDecimalAbinario.Text = "Decimal a Binario";
            // 
            // txtBxBtoD
            // 
            this.txtBxBtoD.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBxBtoD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBxBtoD.Location = new System.Drawing.Point(634, 54);
            this.txtBxBtoD.Name = "txtBxBtoD";
            this.txtBxBtoD.ReadOnly = true;
            this.txtBxBtoD.Size = new System.Drawing.Size(215, 26);
            this.txtBxBtoD.TabIndex = 4;
            // 
            // txtBxDtoB
            // 
            this.txtBxDtoB.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBxDtoB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBxDtoB.Location = new System.Drawing.Point(634, 111);
            this.txtBxDtoB.Name = "txtBxDtoB";
            this.txtBxDtoB.ReadOnly = true;
            this.txtBxDtoB.Size = new System.Drawing.Size(215, 26);
            this.txtBxDtoB.TabIndex = 5;
            // 
            // btnConvertBtoD
            // 
            this.btnConvertBtoD.BackColor = System.Drawing.Color.Silver;
            this.btnConvertBtoD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConvertBtoD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConvertBtoD.Location = new System.Drawing.Point(453, 48);
            this.btnConvertBtoD.Name = "btnConvertBtoD";
            this.btnConvertBtoD.Size = new System.Drawing.Size(158, 37);
            this.btnConvertBtoD.TabIndex = 6;
            this.btnConvertBtoD.Text = "->";
            this.btnConvertBtoD.UseVisualStyleBackColor = false;
            this.btnConvertBtoD.Click += new System.EventHandler(this.btnConvertBtoD_Click);
            // 
            // txtBxConvertBtoD
            // 
            this.txtBxConvertBtoD.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBxConvertBtoD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBxConvertBtoD.Location = new System.Drawing.Point(217, 54);
            this.txtBxConvertBtoD.Name = "txtBxConvertBtoD";
            this.txtBxConvertBtoD.Size = new System.Drawing.Size(215, 26);
            this.txtBxConvertBtoD.TabIndex = 7;
            this.txtBxConvertBtoD.Leave += new System.EventHandler(this.TxtIngresoBinario_Leave);
            // 
            // txtBxConvertDtoB
            // 
            this.txtBxConvertDtoB.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBxConvertDtoB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBxConvertDtoB.Location = new System.Drawing.Point(217, 111);
            this.txtBxConvertDtoB.Name = "txtBxConvertDtoB";
            this.txtBxConvertDtoB.Size = new System.Drawing.Size(215, 26);
            this.txtBxConvertDtoB.TabIndex = 8;
            this.txtBxConvertDtoB.Leave += new System.EventHandler(this.TxtIngresoDecimal_Leave);
            // 
            // btnConvertDtoB
            // 
            this.btnConvertDtoB.BackColor = System.Drawing.Color.Silver;
            this.btnConvertDtoB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConvertDtoB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConvertDtoB.Location = new System.Drawing.Point(453, 105);
            this.btnConvertDtoB.Name = "btnConvertDtoB";
            this.btnConvertDtoB.Size = new System.Drawing.Size(158, 37);
            this.btnConvertDtoB.TabIndex = 9;
            this.btnConvertDtoB.Text = "->";
            this.btnConvertDtoB.UseVisualStyleBackColor = false;
            this.btnConvertDtoB.Click += new System.EventHandler(this.btnConvertDtoB_Click);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(872, 159);
            this.Controls.Add(this.btnConvertDtoB);
            this.Controls.Add(this.txtBxConvertDtoB);
            this.Controls.Add(this.txtBxConvertBtoD);
            this.Controls.Add(this.btnConvertBtoD);
            this.Controls.Add(this.txtBxDtoB);
            this.Controls.Add(this.txtBxBtoD);
            this.Controls.Add(this.lblDecimalAbinario);
            this.Controls.Add(this.lblBinarioAdecimal);
            this.Name = "PrincipalForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBinarioAdecimal;
        private System.Windows.Forms.Label lblDecimalAbinario;
        private System.Windows.Forms.TextBox txtBxBtoD;
        private System.Windows.Forms.TextBox txtBxDtoB;
        private System.Windows.Forms.Button btnConvertBtoD;
        private System.Windows.Forms.TextBox txtBxConvertBtoD;
        private System.Windows.Forms.TextBox txtBxConvertDtoB;
        private System.Windows.Forms.Button btnConvertDtoB;
    }
}