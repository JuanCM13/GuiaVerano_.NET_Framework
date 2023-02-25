namespace WindowsFormCentralita40
{
    partial class DialogForm1
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
            this.txtBxNumDestino = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnNumAsterisco = new System.Windows.Forms.Button();
            this.btnNum0 = new System.Windows.Forms.Button();
            this.btnNumSharp = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btnLlamar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cmboxFranjaHoraria = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBxNumDestino
            // 
            this.txtBxNumDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxNumDestino.Location = new System.Drawing.Point(32, 35);
            this.txtBxNumDestino.Multiline = true;
            this.txtBxNumDestino.Name = "txtBxNumDestino";
            this.txtBxNumDestino.ReadOnly = true;
            this.txtBxNumDestino.Size = new System.Drawing.Size(454, 45);
            this.txtBxNumDestino.TabIndex = 0;
            this.txtBxNumDestino.Text = "Nro Destino";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNum4);
            this.groupBox1.Controls.Add(this.btnNumAsterisco);
            this.groupBox1.Controls.Add(this.btnNum0);
            this.groupBox1.Controls.Add(this.btnNumSharp);
            this.groupBox1.Controls.Add(this.btnNum9);
            this.groupBox1.Controls.Add(this.btnNum7);
            this.groupBox1.Controls.Add(this.btnNum8);
            this.groupBox1.Controls.Add(this.btnNum6);
            this.groupBox1.Controls.Add(this.btnNum5);
            this.groupBox1.Controls.Add(this.btnNum2);
            this.groupBox1.Controls.Add(this.btnNum3);
            this.groupBox1.Controls.Add(this.btnNum1);
            this.groupBox1.Location = new System.Drawing.Point(12, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 324);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Panel";
            // 
            // btnNum4
            // 
            this.btnNum4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNum4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum4.Location = new System.Drawing.Point(20, 115);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(51, 52);
            this.btnNum4.TabIndex = 11;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = false;
            this.btnNum4.Leave += new System.EventHandler(this.btnLeaveCuatro);
            // 
            // btnNumAsterisco
            // 
            this.btnNumAsterisco.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNumAsterisco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumAsterisco.Location = new System.Drawing.Point(20, 255);
            this.btnNumAsterisco.Name = "btnNumAsterisco";
            this.btnNumAsterisco.Size = new System.Drawing.Size(51, 52);
            this.btnNumAsterisco.TabIndex = 10;
            this.btnNumAsterisco.Text = "*";
            this.btnNumAsterisco.UseVisualStyleBackColor = false;
            // 
            // btnNum0
            // 
            this.btnNum0.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNum0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum0.Location = new System.Drawing.Point(87, 255);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(51, 52);
            this.btnNum0.TabIndex = 9;
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = false;
            this.btnNum0.Leave += new System.EventHandler(this.btnLeaveCero);
            // 
            // btnNumSharp
            // 
            this.btnNumSharp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNumSharp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumSharp.Location = new System.Drawing.Point(158, 255);
            this.btnNumSharp.Name = "btnNumSharp";
            this.btnNumSharp.Size = new System.Drawing.Size(51, 52);
            this.btnNumSharp.TabIndex = 8;
            this.btnNumSharp.Text = "#";
            this.btnNumSharp.UseVisualStyleBackColor = false;
            this.btnNumSharp.Leave += new System.EventHandler(this.btnLeaveSharp);
            // 
            // btnNum9
            // 
            this.btnNum9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNum9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum9.Location = new System.Drawing.Point(158, 187);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(51, 52);
            this.btnNum9.TabIndex = 7;
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = false;
            this.btnNum9.Leave += new System.EventHandler(this.btnLeaveNueve);
            // 
            // btnNum7
            // 
            this.btnNum7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNum7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum7.Location = new System.Drawing.Point(20, 187);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(51, 52);
            this.btnNum7.TabIndex = 6;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = false;
            this.btnNum7.Leave += new System.EventHandler(this.btnLeaveSiete);
            // 
            // btnNum8
            // 
            this.btnNum8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNum8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum8.Location = new System.Drawing.Point(87, 187);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(51, 52);
            this.btnNum8.TabIndex = 5;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = false;
            this.btnNum8.Leave += new System.EventHandler(this.btnLeaveOcho);
            // 
            // btnNum6
            // 
            this.btnNum6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNum6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum6.Location = new System.Drawing.Point(158, 113);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(51, 52);
            this.btnNum6.TabIndex = 4;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = false;
            this.btnNum6.Leave += new System.EventHandler(this.btnLeaveSeis);
            // 
            // btnNum5
            // 
            this.btnNum5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNum5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum5.Location = new System.Drawing.Point(87, 115);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(51, 52);
            this.btnNum5.TabIndex = 3;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = false;
            this.btnNum5.Leave += new System.EventHandler(this.btnLeaveCinco);
            // 
            // btnNum2
            // 
            this.btnNum2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNum2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum2.Location = new System.Drawing.Point(87, 47);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(51, 52);
            this.btnNum2.TabIndex = 2;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = false;
            this.btnNum2.Leave += new System.EventHandler(this.btnLeaveDos);
            // 
            // btnNum3
            // 
            this.btnNum3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNum3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum3.Location = new System.Drawing.Point(158, 47);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(51, 52);
            this.btnNum3.TabIndex = 1;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = false;
            this.btnNum3.Leave += new System.EventHandler(this.btnLeaveTres);
            // 
            // btnNum1
            // 
            this.btnNum1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNum1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum1.Location = new System.Drawing.Point(20, 47);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(51, 52);
            this.btnNum1.TabIndex = 0;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = false;
            this.btnNum1.Leave += new System.EventHandler(this.btnLeaveUno);
            // 
            // btnLlamar
            // 
            this.btnLlamar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLlamar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLlamar.Location = new System.Drawing.Point(270, 176);
            this.btnLlamar.Name = "btnLlamar";
            this.btnLlamar.Size = new System.Drawing.Size(216, 46);
            this.btnLlamar.TabIndex = 2;
            this.btnLlamar.Text = "Llamar";
            this.btnLlamar.UseVisualStyleBackColor = false;
            this.btnLlamar.Click += new System.EventHandler(this.btn_LlamarEvento);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(270, 248);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(216, 46);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(270, 390);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(216, 46);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(270, 323);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(216, 46);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Nro Origen";
            // 
            // cmboxFranjaHoraria
            // 
            this.cmboxFranjaHoraria.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmboxFranjaHoraria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboxFranjaHoraria.FormattingEnabled = true;
            this.cmboxFranjaHoraria.Items.AddRange(new object[] {
            "Franja Horaria 1",
            "Franja Horaria 2",
            "Franja Horaria 3"});
            this.cmboxFranjaHoraria.Location = new System.Drawing.Point(32, 478);
            this.cmboxFranjaHoraria.Name = "cmboxFranjaHoraria";
            this.cmboxFranjaHoraria.Size = new System.Drawing.Size(426, 33);
            this.cmboxFranjaHoraria.TabIndex = 6;
            this.cmboxFranjaHoraria.Text = "Franja Horaria";
            // 
            // DialogForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 547);
            this.Controls.Add(this.cmboxFranjaHoraria);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnLlamar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtBxNumDestino);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogForm1";
            this.Text = "Llamador";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxNumDestino;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNum4;
        private System.Windows.Forms.Button btnNumAsterisco;
        private System.Windows.Forms.Button btnNum0;
        private System.Windows.Forms.Button btnNumSharp;
        private System.Windows.Forms.Button btnNum9;
        private System.Windows.Forms.Button btnNum7;
        private System.Windows.Forms.Button btnNum8;
        private System.Windows.Forms.Button btnNum6;
        private System.Windows.Forms.Button btnNum5;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.Button btnNum3;
        private System.Windows.Forms.Button btnNum1;
        private System.Windows.Forms.Button btnLlamar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cmboxFranjaHoraria;
    }
}