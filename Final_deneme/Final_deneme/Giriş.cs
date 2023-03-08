using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;

namespace Final_deneme
{
    public partial class Giriþ : Form
    {
        public Giriþ()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-KK7Q4SO;Initial Catalog=OnMuhasebe;Integrated Security=True");
            SqlCommand cmd;
            SqlDataReader reader;
            string sorgu = "select * from Login where [Kullanýcý adý]=@kullanici and Sifre=@sifre";
            cmd = new SqlCommand(sorgu, baglanti);
            cmd.Parameters.AddWithValue("@kullanici", kullanýcý_Box.Text);
            cmd.Parameters.AddWithValue("@sifre", sifre_Box.Text);
            baglanti.Open();
            reader = cmd.ExecuteReader();
            if (reader.Read()) 
            {
                MessageBox.Show("Giriþ Baþarýlý.");
                Kullanýcý_Bilgileri form2 = new Kullanýcý_Bilgileri();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriþ Baþarýsýz Lütfen Bilgilerinizi Kontrol Ediniz.", "HATA", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            baglanti.Close();
        }
    }
}