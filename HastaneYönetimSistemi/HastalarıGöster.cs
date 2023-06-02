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
using System.Data.SqlClient;
using static System.Windows.Forms.AxHost;

namespace HastaneYönetimSistemi
{
    public partial class HastalarıGöster : Form
    {
        public HastalarıGöster()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-9F720B0;Initial Catalog=Randevu;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            HastaListesi hastaListesi = new HastaListesi();
            hastaListesi.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM RandevuZamanları";
            komut.Connection = baglanti;

            SqlDataAdapter adap = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();

            adap.Fill(tablo);


            for (int i = 0; i < tablo.Rows.Count; i++)
            {
                listView1.Items.Add(tablo.Rows[i]["TC"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["Ad"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["Soyad"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["Poliklinik"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["Hekim"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["Randevu Tarihi"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["Randevu Saati"].ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                SqlCommand komut1 = new SqlCommand("DELETE FROM RandevuZamanları WHERE TC = @TC", baglanti);
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
            komut.CommandText = "SELECT * FROM RandevuZamanları";
            komut.Connection = baglanti;

            SqlDataAdapter adap = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();

            adap.Fill(tablo);


            for (int i = 0; i < tablo.Rows.Count; i++)
            {
                listView1.Items.Add(tablo.Rows[i]["TC"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["Ad"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["Soyad"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["Poliklinik"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["Hekim"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["Randevu Tarihi"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["Randevu Saati"].ToString());
            }


        }
<<<<<<< HEAD
=======

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
>>>>>>> d1a42ffafc195b77062166c80d6ec4a771c12580
    }
}

