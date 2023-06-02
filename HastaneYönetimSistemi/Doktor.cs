using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static HastaneYönetimSistemi.DoktorSınıfı;

namespace HastaneYönetimSistemi
{
    public partial class Doktor : Form
    {
        public Doktor()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-9F720B0;Initial Catalog=DoktorBilgileri;Integrated Security=True");
       

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Doktor_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastaneDataSet3.Doktorlar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.doktorlarTableAdapter.Fill(this.hastaneDataSet3.Doktorlar);
           
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyet)));
            cmbBrans.Items.AddRange(Enum.GetNames(typeof(Branslar)));
        }

        private void richTextBox1_VisibleChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "Arama...";
            richTextBox1.ForeColor = Color.Gray;
        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
         
            if (richTextBox1.Text == "Arama...")
            {
                richTextBox1.Text = "";
                richTextBox1.ForeColor = Color.Black; // Yazı rengini siyah olarak ayarla
            }
        }

        private void richTextBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                richTextBox1.Text = "Arama...";
                richTextBox1.ForeColor = Color.Gray; // Yazı rengini gri olarak ayarla
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PersonelKayıt personelKayıt = new PersonelKayıt();
            personelKayıt.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO Doktor (TC,Ad,Soyad,[Kullanıcı Adı],[Doğum Tarihi],Cinsiyet,Branş) VALUES (@TC,@Ad,@Soyad,@KullanıcıAdı,@DoğumTarihi,@Cinsiyet,@Branş);", baglanti);
            komut.Parameters.AddWithValue("@TC", Convert.ToInt64(textBox1.Text));
            komut.Parameters.AddWithValue("@Ad", Ad.Text);
            komut.Parameters.AddWithValue("@Soyad", Soyad.Text);
            komut.Parameters.AddWithValue("@KullanıcıAdı", textBox4.Text);
            komut.Parameters.AddWithValue("@DoğumTarihi", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@Cinsiyet", cmbCinsiyet.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@Branş", cmbBrans.SelectedItem.ToString());

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();


        }
        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                SqlCommand komut1 = new SqlCommand("DELETE FROM Doktor WHERE TC = @TC",baglanti);
                komut1.Parameters.AddWithValue("@TC", Convert.ToInt64(listView1.SelectedItems[0].SubItems[0].Text));

                baglanti.Open();
                komut1.ExecuteNonQuery();
                baglanti.Close();   
            }
            catch (Exception )
            {
                MessageBox.Show("Veri seçiniz");
            }
            listView1.Items.Clear();
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Doktor";
            komut.Connection = baglanti;

            SqlDataAdapter adap = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();

            adap.Fill(tablo);


            for (int i = 0; i < tablo.Rows.Count; i++)
            {
                listView1.Items.Add(tablo.Rows[i]["TC"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["Ad"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["Soyad"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["Kullanıcı Adı"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["Doğum Tarihi"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["Cinsiyet"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["Branş"].ToString());
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.doktorTableAdapter.FillBy(this.hastaneDataSet.Doktor);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ad_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Doktor";
            komut.Connection = baglanti;

            SqlDataAdapter adap = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();

            adap.Fill(tablo);


            for (int i = 0; i < tablo.Rows.Count; i++)
            {
                listView1.Items.Add(tablo.Rows[i]["TC"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["Ad"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["Soyad"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["Kullanıcı Adı"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["Doğum Tarihi"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["Cinsiyet"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["Branş"].ToString());
            }

        }
    }
}
