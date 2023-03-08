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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Final_deneme
{
    public partial class Kullanıcı_Bilgileri : Form
    {
        public Kullanıcı_Bilgileri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-KK7Q4SO;Initial Catalog=OnMuhasebe;Integrated Security=True");
        SqlDataAdapter da;
        SqlCommand komut;

        public void listele()
        {
            baglanti.Open();
            string sorgu = "select [Kullanici Adi] from Kullanıcılar";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            da = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void M_Ekle_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO Kullanıcılar values (@Id)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Id", Id.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            listele();
        }

        private void M_Sil_Click(object sender, EventArgs e)
        {
            string sorgu = "delete from Kullanıcılar where [Kullanici Adi]=@Id";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Id", Id.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            listele();
        }

        private void Gelir_Ekle_Click(object sender, EventArgs e)
        {
            Gelir gelir = new Gelir();
            gelir.k_Adi=Id.Text;
            gelir.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Gider gider  = new Gider();
            gider.k_Adi = Id.Text;
            gider.Show();
            this.Hide();
        }
    }
}
