namespace Visual
{
    partial class PrincipalWindowsForm
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
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.LabelNombre = new System.Windows.Forms.Label();
            this.Saludar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(12, 46);
            this.textBoxNombre.Multiline = true;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(294, 26);
            this.textBoxNombre.TabIndex = 0;
            // 
            // LabelNombre
            // 
            this.LabelNombre.AccessibleName = "";
            this.LabelNombre.AutoSize = true;
            this.LabelNombre.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNombre.Location = new System.Drawing.Point(12, 9);
            this.LabelNombre.Name = "LabelNombre";
            this.LabelNombre.Size = new System.Drawing.Size(98, 32);
            this.LabelNombre.TabIndex = 1;
            this.LabelNombre.Text = "label1";
            this.LabelNombre.Click += new System.EventHandler(this.LabelNombre_Click);
            // 
            // Saludar
            // 
            this.Saludar.Location = new System.Drawing.Point(360, 33);
            this.Saludar.Name = "Saludar";
            this.Saludar.Size = new System.Drawing.Size(220, 39);
            this.Saludar.TabIndex = 3;
            this.Saludar.Text = "button2";
            this.Saludar.UseVisualStyleBackColor = true;
            this.Saludar.Click += new System.EventHandler(this.Saludar_OnClick);
            // 
            // PrincipalWindowsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 268);
            this.Controls.Add(this.Saludar);
            this.Controls.Add(this.LabelNombre);
            this.Controls.Add(this.textBoxNombre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(782, 324);
            this.Name = "PrincipalWindowsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Un nuevo Formulario";
            this.Load += new System.EventHandler(this.PrincipalWindowsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label LabelNombre;
        private System.Windows.Forms.Button Saludar;
    }
}