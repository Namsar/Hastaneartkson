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

namespace HastaneYönetimSistemi
{
    public partial class DoktorGirişSayfası : Form
    {
        public DoktorGirişSayfası()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // yeni formu ekranın ortasında aç
            this.TopMost = true; // yeni formu en üstte göster
        }

        string connectionString = "Data Source=DESKTOP-9F720B0;Initial Catalog=YöneticiDoktorHemşireŞifreleri;Integrated Security=True";


        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
                Anasayfa form1 = new Anasayfa();
                form1.Show();
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //DoktorKullanıcıGirişiSınıfı DKG = new DoktorKullanıcıGirişiSınıfı();

        private void button1_Click(object sender, EventArgs e)
        {

            string username = txtKullanıcıAdı.Text;
            string password = txtŞifre.Text;

            if (CheckCredentials(username, password))
            {
                DoktorAnaSayfa doktorAnaSayfa = new DoktorAnaSayfa();
                doktorAnaSayfa.Show();
                this.Hide();
                // Giriş başarılı, istediğiniz işlemleri burada gerçekleştirebilirsiniz.
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
            }
            // DKG.DoktorKullanıcı(txtKullanıcıAdı,txtŞifre);
             

        }
        private bool CheckCredentials(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM DoktorŞifre WHERE [Kullanıcı Adı] = @Username AND Şifre = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    connection.Open();
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    connection.Close();

                    return count > 0;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Anasayfa form1 = new Anasayfa();
            form1.Show();
            this.Hide();
        }

        private void DoktorGirişSayfası_Load(object sender, EventArgs e)
        {

        }
    }
}
