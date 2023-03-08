namespace Final_deneme
{
    partial class Kullanıcı_Bilgileri
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
            this.Id = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Gelir_Ekle = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.M_Ekle = new System.Windows.Forms.Button();
            this.M_Sil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(116, 45);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(100, 23);
            this.Id.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(269, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(155, 201);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "Görüntüle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Gelir_Ekle
            // 
            this.Gelir_Ekle.Location = new System.Drawing.Point(21, 271);
            this.Gelir_Ekle.Name = "Gelir_Ekle";
            this.Gelir_Ekle.Size = new System.Drawing.Size(89, 23);
            this.Gelir_Ekle.TabIndex = 6;
            this.Gelir_Ekle.Text = "Gelir Ekle";
            this.Gelir_Ekle.UseVisualStyleBackColor = true;
            this.Gelir_Ekle.Click += new System.EventHandler(this.Gelir_Ekle_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(145, 271);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Gider Ekle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // M_Ekle
            // 
            this.M_Ekle.BackColor = System.Drawing.Color.Transparent;
            this.M_Ekle.Location = new System.Drawing.Point(269, 271);
            this.M_Ekle.Name = "M_Ekle";
            this.M_Ekle.Size = new System.Drawing.Size(102, 23);
            this.M_Ekle.TabIndex = 8;
            this.M_Ekle.Text = "Müşteri Ekle";
            this.M_Ekle.UseVisualStyleBackColor = false;
            this.M_Ekle.Click += new System.EventHandler(this.M_Ekle_Click);
            // 
            // M_Sil
            // 
            this.M_Sil.Location = new System.Drawing.Point(403, 271);
            this.M_Sil.Name = "M_Sil";
            this.M_Sil.Size = new System.Drawing.Size(102, 23);
            this.M_Sil.TabIndex = 9;
            this.M_Sil.Text = "Müşteri Sil";
            this.M_Sil.UseVisualStyleBackColor = true;
            this.M_Sil.Click += new System.EventHandler(this.M_Sil_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(525, 355);
            this.Controls.Add(this.M_Sil);
            this.Controls.Add(this.M_Ekle);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Gelir_Ekle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox Id;
        private DataGridView dataGridView1;
        private Button button1;
        private Button Gelir_Ekle;
        private Button button3;
        private Button M_Ekle;
        private Button M_Sil;
    }
}