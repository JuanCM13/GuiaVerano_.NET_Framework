
namespace RepasoSabadosTestUnitariosYexcepciones
{
    partial class Form1
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
            this.Tbx_User = new System.Windows.Forms.TextBox();
            this.Tbx_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Logear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tbx_User
            // 
            this.Tbx_User.Location = new System.Drawing.Point(12, 79);
            this.Tbx_User.Name = "Tbx_User";
            this.Tbx_User.Size = new System.Drawing.Size(309, 31);
            this.Tbx_User.TabIndex = 0;
            // 
            // Tbx_Password
            // 
            this.Tbx_Password.Location = new System.Drawing.Point(12, 198);
            this.Tbx_Password.Name = "Tbx_Password";
            this.Tbx_Password.PasswordChar = '*';
            this.Tbx_Password.Size = new System.Drawing.Size(309, 31);
            this.Tbx_Password.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // Btn_Logear
            // 
            this.Btn_Logear.Location = new System.Drawing.Point(197, 321);
            this.Btn_Logear.Name = "Btn_Logear";
            this.Btn_Logear.Size = new System.Drawing.Size(124, 40);
            this.Btn_Logear.TabIndex = 4;
            this.Btn_Logear.Text = "Log";
            this.Btn_Logear.UseVisualStyleBackColor = true;
            this.Btn_Logear.Click += new System.EventHandler(this.Btn_Logear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "AutoComplete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 369);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_Logear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tbx_Password);
            this.Controls.Add(this.Tbx_User);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tbx_User;
        private System.Windows.Forms.TextBox Tbx_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Logear;
        private System.Windows.Forms.Button button1;
    }
}

