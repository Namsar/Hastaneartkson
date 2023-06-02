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
    public partial class YöneticiGirişSayfası : Form
    {
        public YöneticiGirişSayfası()
        {
            InitializeComponent();
            
        }
        string connectionString = "Data Source=DESKTOP-9F720B0;Initial Catalog=YöneticiDoktorHemşireŞifreleri;Integrated Security=True";

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
                Anasayfa form1 = new Anasayfa();
                form1.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Anasayfa form2 = new Anasayfa();
            form2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string username = textBox1.Text;
            string password = textBox2.Text;

            if (CheckCredentials(username, password))
            {
                YöneticiAnaSayfa yöneticiAnaSayfa = new YöneticiAnaSayfa();
                yöneticiAnaSayfa.Show();
                this.Hide();
                // Giriş başarılı, istediğiniz işlemleri burada gerçekleştirebilirsiniz.
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
            }


       

        }
        private bool CheckCredentials(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM YöneticiŞifre WHERE [Kullanıcı Adı] = @Username AND Şifre = @Password";
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void YöneticiGirişSayfası_Load(object sender, EventArgs e)
        {

        }
    }
}
