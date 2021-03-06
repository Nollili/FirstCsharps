
namespace RegisztracioEsBelepes
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Felhasználónév = new System.Windows.Forms.TextBox();
            this.Jelszó = new System.Windows.Forms.TextBox();
            this.Belépés = new System.Windows.Forms.Button();
            this.Kilépés = new System.Windows.Forms.Button();
            this.Regisztráció = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Felhasználónév";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jelszó";
            // 
            // Felhasználónév
            // 
            this.Felhasználónév.Location = new System.Drawing.Point(46, 73);
            this.Felhasználónév.Name = "Felhasználónév";
            this.Felhasználónév.Size = new System.Drawing.Size(251, 26);
            this.Felhasználónév.TabIndex = 2;
            // 
            // Jelszó
            // 
            this.Jelszó.Location = new System.Drawing.Point(46, 174);
            this.Jelszó.Name = "Jelszó";
            this.Jelszó.Size = new System.Drawing.Size(251, 26);
            this.Jelszó.TabIndex = 3;
            // 
            // Belépés
            // 
            this.Belépés.Location = new System.Drawing.Point(46, 224);
            this.Belépés.Name = "Belépés";
            this.Belépés.Size = new System.Drawing.Size(251, 32);
            this.Belépés.TabIndex = 4;
            this.Belépés.Text = "Belépés";
            this.Belépés.UseVisualStyleBackColor = true;
            this.Belépés.Click += new System.EventHandler(this.Belépés_Click);
            // 
            // Kilépés
            // 
            this.Kilépés.Location = new System.Drawing.Point(226, 317);
            this.Kilépés.Name = "Kilépés";
            this.Kilépés.Size = new System.Drawing.Size(127, 36);
            this.Kilépés.TabIndex = 5;
            this.Kilépés.Text = "Kilépés";
            this.Kilépés.UseVisualStyleBackColor = true;
            this.Kilépés.Click += new System.EventHandler(this.Kilépés_Click);
            // 
            // Regisztráció
            // 
            this.Regisztráció.Location = new System.Drawing.Point(46, 317);
            this.Regisztráció.Name = "Regisztráció";
            this.Regisztráció.Size = new System.Drawing.Size(127, 36);
            this.Regisztráció.TabIndex = 6;
            this.Regisztráció.Text = "Regisztráció";
            this.Regisztráció.UseVisualStyleBackColor = true;
            this.Regisztráció.Click += new System.EventHandler(this.Regisztráció_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 385);
            this.Controls.Add(this.Regisztráció);
            this.Controls.Add(this.Kilépés);
            this.Controls.Add(this.Belépés);
            this.Controls.Add(this.Jelszó);
            this.Controls.Add(this.Felhasználónév);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Regisztráció és Belépés";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Felhasználónév;
        private System.Windows.Forms.TextBox Jelszó;
        private System.Windows.Forms.Button Belépés;
        private System.Windows.Forms.Button Kilépés;
        private System.Windows.Forms.Button Regisztráció;
    }
}

