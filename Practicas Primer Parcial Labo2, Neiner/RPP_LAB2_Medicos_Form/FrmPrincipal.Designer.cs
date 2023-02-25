
namespace RPP_LAB2_Medicos_Form
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rtb_Ingresado = new System.Windows.Forms.RichTextBox();
            this.rtb_Egresado = new System.Windows.Forms.RichTextBox();
            this.Btn_Ingresar = new System.Windows.Forms.Button();
            this.Btn_Egresar = new System.Windows.Forms.Button();
            this.cmb_Orden = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1308, 528);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_Egresar);
            this.groupBox2.Controls.Add(this.Btn_Ingresar);
            this.groupBox2.Controls.Add(this.rtb_Ingresado);
            this.groupBox2.Location = new System.Drawing.Point(6, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(635, 498);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingresado";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cmb_Orden);
            this.groupBox3.Controls.Add(this.rtb_Egresado);
            this.groupBox3.Location = new System.Drawing.Point(656, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(635, 498);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Egresado";
            // 
            // rtb_Ingresado
            // 
            this.rtb_Ingresado.Location = new System.Drawing.Point(7, 31);
            this.rtb_Ingresado.Name = "rtb_Ingresado";
            this.rtb_Ingresado.Size = new System.Drawing.Size(622, 387);
            this.rtb_Ingresado.TabIndex = 0;
            this.rtb_Ingresado.Text = "";
            // 
            // rtb_Egresado
            // 
            this.rtb_Egresado.Location = new System.Drawing.Point(7, 30);
            this.rtb_Egresado.Name = "rtb_Egresado";
            this.rtb_Egresado.Size = new System.Drawing.Size(622, 387);
            this.rtb_Egresado.TabIndex = 1;
            this.rtb_Egresado.Text = "";
            // 
            // Btn_Ingresar
            // 
            this.Btn_Ingresar.BackColor = System.Drawing.Color.Lime;
            this.Btn_Ingresar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Ingresar.Location = new System.Drawing.Point(7, 437);
            this.Btn_Ingresar.Name = "Btn_Ingresar";
            this.Btn_Ingresar.Size = new System.Drawing.Size(196, 55);
            this.Btn_Ingresar.TabIndex = 1;
            this.Btn_Ingresar.Text = "INGRESAR";
            this.Btn_Ingresar.UseVisualStyleBackColor = false;
            // 
            // Btn_Egresar
            // 
            this.Btn_Egresar.BackColor = System.Drawing.Color.Red;
            this.Btn_Egresar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Egresar.Location = new System.Drawing.Point(433, 437);
            this.Btn_Egresar.Name = "Btn_Egresar";
            this.Btn_Egresar.Size = new System.Drawing.Size(196, 55);
            this.Btn_Egresar.TabIndex = 2;
            this.Btn_Egresar.Text = "EGRESAR";
            this.Btn_Egresar.UseVisualStyleBackColor = false;
            // 
            // cmb_Orden
            // 
            this.cmb_Orden.FormattingEnabled = true;
            this.cmb_Orden.Location = new System.Drawing.Point(21, 450);
            this.cmb_Orden.Name = "cmb_Orden";
            this.cmb_Orden.Size = new System.Drawing.Size(229, 33);
            this.cmb_Orden.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ordenar por";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 567);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Orden;
        private System.Windows.Forms.RichTextBox rtb_Egresado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_Egresar;
        private System.Windows.Forms.Button Btn_Ingresar;
        private System.Windows.Forms.RichTextBox rtb_Ingresado;
    }
}

