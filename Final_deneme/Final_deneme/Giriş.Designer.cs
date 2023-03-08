namespace Final_deneme
{
    partial class Giriş
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
            this.btn_Giris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kullanıcı_Box = new System.Windows.Forms.TextBox();
            this.sifre_Box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Giris
            // 
            this.btn_Giris.Location = new System.Drawing.Point(111, 159);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(88, 36);
            this.btn_Giris.TabIndex = 0;
            this.btn_Giris.Text = "Giriş";
            this.btn_Giris.UseVisualStyleBackColor = true;
            this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre";
            // 
            // kullanıcı_Box
            // 
            this.kullanıcı_Box.Location = new System.Drawing.Point(111, 42);
            this.kullanıcı_Box.Name = "kullanıcı_Box";
            this.kullanıcı_Box.Size = new System.Drawing.Size(100, 23);
            this.kullanıcı_Box.TabIndex = 3;
            // 
            // sifre_Box
            // 
            this.sifre_Box.Location = new System.Drawing.Point(111, 83);
            this.sifre_Box.Name = "sifre_Box";
            this.sifre_Box.PasswordChar = '*';
            this.sifre_Box.Size = new System.Drawing.Size(100, 23);
            this.sifre_Box.TabIndex = 4;
            // 
            // Giriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(298, 258);
            this.Controls.Add(this.sifre_Box);
            this.Controls.Add(this.kullanıcı_Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Giris);
            this.Name = "Giriş";
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Giris;
        private Label label1;
        private Label label2;
        private TextBox kullanıcı_Box;
        private TextBox sifre_Box;
    }
}