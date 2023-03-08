using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_deneme
{
    public partial class Detaylı_Görünüm : Form
    {
        public Detaylı_Görünüm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-KK7Q4SO;Initial Catalog=OnMuhasebe;Integrated Security=True");
        SqlDataAdapter da;
        SqlCommand komut;
        public string k_Adi;
        public void görüntüle()
        {
            baglanti.Open();
            string sorgu = "select Tutar,FORMAT(Tarih,'d','tr-TR') as 'Tarih' from Gelir where [Kullanici Adi]=@Kullanıcı_Adi";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Kullanıcı_Adi", k_Adi);
            da = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView2.DataSource = tablo;
            baglanti.Close();

        }
        public void görüntüle2()
        {
            baglanti.Open();
            string sorgu = "select Tutar,FORMAT(Tarih,'d','tr-TR') as 'Tarih',format(DATEADD(month, vade, tarih),'d','tr-TR') AS 'Son Ödeme' ,convert(varchar,Vade)+' Ay' as Vade from Gider where [Kullanici Adi]=@Kullanıcı_Adi";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Kullanıcı_Adi", k_Adi);
            da = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }
        public int kar_Toplam;
        public void kar()
        {
            baglanti.Open();
            string sorgu = "select sum(Tutar) from Gelir where [Kullanici Adi]=@Kullanıcı_Adi";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Kullanıcı_Adi", k_Adi);
            kar_Toplam=(int)komut.ExecuteScalar();
            baglanti.Close();

        }
        public int zarar_Toplam;
        public void zarar()
        {
            baglanti.Open();
            string sorgu = "select sum(Tutar) from Gider where [Kullanici Adi]=@Kullanıcı_Adi";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Kullanıcı_Adi", k_Adi);
            zarar_Toplam = (int)komut.ExecuteScalar();
            baglanti.Close();

        }
        public int son_toplam;
        public void son()
        {
            son_toplam = kar_Toplam - zarar_Toplam; 
        }
        private void Detaylı_Görünüm_Load(object sender, EventArgs e)
        {
            görüntüle();
            görüntüle2();
            kar();
            zarar();
            son();
            textBox1.Text=son_toplam.ToString();
        }
        
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kullanıcı_Bilgileri form2 = new Kullanıcı_Bilgileri();
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
