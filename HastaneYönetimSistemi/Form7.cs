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
using static HastaneYönetimSistemi.HemşireSınıfı;
namespace HastaneYönetimSistemi
{
    public partial class Hemsire : Form
    {
        public Hemsire()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-9F720B0;Initial Catalog=DoktorBilgileri;Integrated Security=True");
        private void Form7_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

       

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastaneDataSet5.Hemşire' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hemşireTableAdapter1.Fill(this.hastaneDataSet5.Hemşire);
            // TODO: yadrBu kod satırı 'hastaneDataSet4.Hemşire' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hemşireTableAdapter.Fill(this.hastaneDataSet4.Hemşire);
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyet)));
            cmbBrans.Items.AddRange(Enum.GetNames(typeof(HBranslar)));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
           PersonelKayıt personelKayıt = new PersonelKayıt();
            personelKayıt.Show();
            this.Hide();

        }

        private void hemşireBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Hemşire";
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

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                SqlCommand komut1 = new SqlCommand("DELETE FROM Hemşire WHERE TC = @TC", baglanti);
                komut1.Parameters.AddWithValue("@TC", Convert.ToInt64(listView1.SelectedItems[0].SubItems[0].Text));

                baglanti.Open();
                komut1.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Veri seçiniz");
            }
            listView1.Items.Clear();
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Hemşire";
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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO Hemşire (TC,Ad,Soyad,[Kullanıcı Adı],[Doğum Tarihi],Cinsiyet,Branş) VALUES (@TC,@Ad,@Soyad,@KullanıcıAdı,@DoğumTarihi,@Cinsiyet,@Branş);", baglanti);
            komut.Parameters.AddWithValue("@TC", Convert.ToInt64(textBox1.Text));
            komut.Parameters.AddWithValue("@Ad", textBox2.Text);
            komut.Parameters.AddWithValue("@Soyad", textBox3.Text);
            komut.Parameters.AddWithValue("@KullanıcıAdı", textBox4.Text);
            komut.Parameters.AddWithValue("@DoğumTarihi", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@Cinsiyet", cmbCinsiyet.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@Branş", cmbBrans.SelectedItem.ToString());

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
