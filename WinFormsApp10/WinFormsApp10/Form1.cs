using Npgsql;
using System.Data;

namespace WinFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=hastalar; user ID=postgres; password=1234");


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from hasta";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into hasta (tcno, ad, soyad, telefon, dogumtarihi, dogumyeri, adres, hastalik, ilac) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9)", baglanti);
            komut1.Parameters.AddWithValue("@p1", double.Parse(textBox1.Text));
            komut1.Parameters.AddWithValue("@p2", textBox2.Text);
            komut1.Parameters.AddWithValue("@p3", textBox3.Text);
            komut1.Parameters.AddWithValue("@p4", double.Parse(textBox4.Text));
            komut1.Parameters.AddWithValue("@p5", textBox5.Text);
            komut1.Parameters.AddWithValue("@p6", textBox6.Text);
            komut1.Parameters.AddWithValue("@p7", textBox7.Text);
            komut1.Parameters.AddWithValue("@p8", textBox8.Text);
            komut1.Parameters.AddWithValue("@p9", textBox9.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ekleme yapýldý.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("DElete From hasta where tcno=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", double.Parse(textBox1.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Bilgiler silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update hasta set ad=@p1, soyad=@p2, telefon=@p3, dogumtarihi=@p4, dogumyeri=@p5, adres=@p6, hastalik=@p7, ilac=@p8 where tcno=@p9", baglanti);
            komut3.Parameters.AddWithValue("@p1", textBox2.Text);
            komut3.Parameters.AddWithValue("@p2", textBox3.Text);
            komut3.Parameters.AddWithValue("@p3", double.Parse(textBox4.Text));
            komut3.Parameters.AddWithValue("@p4", textBox5.Text);
            komut3.Parameters.AddWithValue("@p5", textBox6.Text);
            komut3.Parameters.AddWithValue("@p6", textBox7.Text);
            komut3.Parameters.AddWithValue("@p7", textBox8.Text);
            komut3.Parameters.AddWithValue("@p8", textBox9.Text);
            komut3.Parameters.AddWithValue("@p9", double.Parse(textBox1.Text));
            komut3.ExecuteNonQuery();
            MessageBox.Show("Bilgiler güncellendi. ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            baglanti.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}