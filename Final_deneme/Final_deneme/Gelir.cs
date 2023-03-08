using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Final_deneme
{
    public partial class Gelir : Form
    {
        public Gelir()
        {
            InitializeComponent();
        }
        public string k_Adi;//burada form 2 den veri çekiyorum ve atıyorum.

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-KK7Q4SO;Initial Catalog=OnMuhasebe;Integrated Security=True");
        SqlDataAdapter da;
        SqlCommand komut;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Kullanıcı_Adi.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Tutar.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void Kullanıcı_Adi_TextChanged(object sender, EventArgs e)
        {

        }

        private void Gelir_Load(object sender, EventArgs e)
        {
            Kullanıcı_Adi.Text = k_Adi;//burada çektiğim veriyi eşitliyorum
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO Gelir values (@Kullanıcı_Adi,@dateTimePicker1,@Tutar)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Kullanıcı_Adi", Kullanıcı_Adi.Text);
            komut.Parameters.AddWithValue("@dateTimePicker1", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            komut.Parameters.AddWithValue("@Tutar", Tutar.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public void görüntüle()
        {
            baglanti.Open();
            string sorgu = "select * from Gelir where [Kullanici Adi]=@Kullanıcı_Adi ";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Kullanıcı_Adi", Kullanıcı_Adi.Text);
            da = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            görüntüle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "delete from Gelir where [Kullanici Adi]=@Kullanıcı_Adi and Tarih=@dateTimePicker1 and Tutar=@Tutar";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Kullanıcı_Adi", Kullanıcı_Adi.Text);
            komut.Parameters.AddWithValue("@dateTimePicker1", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            komut.Parameters.AddWithValue("@Tutar", Tutar.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kullanıcı_Bilgileri Kullanıcı_Bilgileri = new Kullanıcı_Bilgileri();
            Kullanıcı_Bilgileri.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Detaylı_Görünüm detaylı = new Detaylı_Görünüm();
            detaylı.k_Adi = Kullanıcı_Adi.Text;
            detaylı.Show();
            this.Hide();
        }
    }
}
//dateTimePicker1.Value.ToString("yyyy-MM-dd");