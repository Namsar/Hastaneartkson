using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace HastaneYönetimSistemi
{
    public partial class KayitFormu : Form
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader dataReader;
        public KayitFormu()
        {
            InitializeComponent();
            string ad= adTextBox.Text;
            string soyad= soyadTextBox.Text;
            string tc = textBoxTCKimlik.Text;
            string email= textEposta.Text;
            string sifre= sifreTextBox.Text;
            connection = new SqlConnection("Data Source=LAPTOP-26716A5N;Initial Catalog=HastaKayıt;Integrated Security=True");
            command = new SqlCommand();
            connection.Open();
            command.Connection = connection;
            command.CommandText = "Select*From Bilgi where ad='" + adTextBox + "'And sifre= '" + sifreTextBox + "' And email= '" + textEposta + "' And tc='"+ textBoxTCKimlik + "'";
           
        }
        private void sifreTextBox_VisibleChanged(object sender, EventArgs e)
        {
            sifreTextBox.Text = "şifre";
            sifreTextBox.ForeColor = Color.Gray;
        }
        private void sifreTextBox_Enter(object sender, EventArgs e)
        {
            
            // TextBox nesnesi odak kazandığında, varsayılan metni kontrol edin ve gerekiyorsa silin
            if (sifreTextBox.Text == "şifre")
            {
                sifreTextBox.Text = "";
                sifreTextBox.ForeColor = Color.Black; // Yazı rengini siyah olarak ayarla
            }
        }
        private void sifreTextBox_Leave(object sender, EventArgs e)
        {
            // TextBox nesnesinden çıkıldığında, eğer TextBox nesnesi boş ise varsayılan metni göster
            if (string.IsNullOrWhiteSpace(sifreTextBox.Text))
            {
                sifreTextBox.Text = "şifre";
                sifreTextBox.ForeColor = Color.Gray; // Yazı rengini gri olarak ayarla
            }
        }
        private void soyadTextBox_VisibleChanged(object sender, EventArgs e)
        {
            soyadTextBox.Text = "soyad";
            soyadTextBox.ForeColor = Color.Gray;
        }
        private void soyadTextBox_Enter(object sender, EventArgs e)
        {

            if (soyadTextBox.Text == "soyad")
            {
                soyadTextBox.Text = "";
                soyadTextBox.ForeColor = Color.Black;
            }
        }
        private void soyadTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(soyadTextBox.Text))
            {
                soyadTextBox.Text = "soyad";
                soyadTextBox.ForeColor = Color.Gray; // Yazı rengini gri olarak ayarla
            }
        }
        private void adTextBox_VisibleChanged(object sender, EventArgs e)
        {
            adTextBox.Text = "ad";
            adTextBox.ForeColor = Color.Gray;

        }
        private void adTextBox_Enter(object sender, EventArgs e)
        {
            if (adTextBox.Text == "ad") {
                adTextBox.Text = "";
                adTextBox.ForeColor = Color.Black;
            }
        }
        private void adTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(adTextBox.Text))
            {
                adTextBox.Text = "ad";
                adTextBox.ForeColor = Color.Gray; // Yazı rengini gri olarak ayarla
            }
        }
        private void kayitOlButton_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                Ad = adTextBox.Text,
                Soyad = soyadTextBox.Text,
                Email = txtEmail.Text,
                TCKimlikNo = textBoxTCKimlik.Text,
                Parola = sifreTextBox.Text
            };

            UserValidator validator = new UserValidator();
            var validationResult = validator.Validate(user);

            if (validationResult.IsValid)
            {
                // Veritabanı bağlantısı ve kullanıcıyı kaydetme işlemleri
                try
                {
                    // Veritabanı bağlantısı ve kaydetme işlemleri

                    using (var connection = new SqlConnection("connectionString"))
                    {
                        connection.Open();

                        // Kullanıcıyı veritabanına ekleme işlemi

                        SqlCommand command = new SqlCommand("INSERT INTO Users (FirstName, LastName, Email, Tc, Password) VALUES (@FirstName, @LastName, @Email, @Tc, @Password)", connection);
                        {

                            command.Parameters.AddWithValue("@FirstName", adTextBox.Text);
                            command.Parameters.AddWithValue("@LastName", soyadTextBox.Text);
                            command.Parameters.AddWithValue("@Email", txtEmail.Text);
                            command.Parameters.AddWithValue("@Tc", textBoxTCKimlik.Text);
                            command.Parameters.AddWithValue("@Password", sifreTextBox.Text);
                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Üyelik oluşturuldu.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kullanıcı kaydetme işlemi sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string errors = string.Join(Environment.NewLine, validationResult.Errors.Select(x => x.ErrorMessage));
                MessageBox.Show(errors, "Doğrulama Hataları", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

       

        private void sifreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private bool IsTCKNUnique(string tckn)
        {
            // Girilen değerin TC Kimlik Numarası formatına uygun olup olmadığını kontrol edin
            if (tckn.Length != 11 || !tckn.All(char.IsDigit))
            {
                MessageBox.Show("Lütfen geçerli bir TC Kimlik Numarası girin.");
                return false;
            }

            // TC Kimlik numarasının benzersiz olup olmadığını kontrol edin
            if (!IsTCKNUnique(tckn))
            {
                MessageBox.Show("Bu TC Kimlik Numarası zaten kullanımda. Lütfen başka bir TC Kimlik Numarası girin.");
                return false;
            }

            // Geçerli bir TC Kimlik numarası
            return true;
        }

        private void KayitFormu_Load(object sender, EventArgs e)
        {
           

          
        }

        private void textBoxTCKimlik_TextChanged(object sender, EventArgs e)
        {
            string tckn = textBoxTCKimlik.Text;

           
        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {
          
            if (IsValidEmail(txtEmail.Text))
        {
            // Geçerli bir e-posta adresi
            // Doğrulama kodunuzu buraya ekleyebilirsiniz
        }
        else
        {
            // Geçersiz bir e-posta adresi
            // Kullanıcıyı uyarmak için bir mesaj gösterin
        }
    }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

      

       


        private void textBoxTCKimlik_VisibleChanged(object sender, EventArgs e)
        {
            textBoxTCKimlik.Text = "Kimlik No";
            textBoxTCKimlik.ForeColor = Color.Gray;
        }

        private void textBoxTCKimlik_Enter(object sender, EventArgs e)
        {
            if (textBoxTCKimlik.Text == "Kimlik No")
            {
                textBoxTCKimlik.Text = "";
                textBoxTCKimlik.ForeColor = Color.Black;
            }
        }

        private void textBoxTCKimlik_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTCKimlik.Text))
            {
                textBoxTCKimlik.Text = "E-posta";
                textBoxTCKimlik.ForeColor = Color.Gray; // Yazı rengini gri olarak ayarla
            }
        }

        private void textEposta_VisibleChanged(object sender, EventArgs e)
        {
            textEposta.Text = "E-posta";
            textEposta.ForeColor = Color.Gray;
        }

        private void textEposta_Enter(object sender, EventArgs e)
        {
            if (textEposta.Text == "E-posta")
            {
                textEposta.Text = "";
                textEposta.ForeColor = Color.Black;
            }
        }

        private void textEposta_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textEposta.Text))
            {
                textEposta.Text = "E-posta";
                textEposta.ForeColor = Color.Gray; // Yazı rengini gri olarak ayarla
            }
        }

        private void txtEmail_VisibleChanged(object sender, EventArgs e)
        {
            txtEmail.Text = "E-posta";
            txtEmail.ForeColor = Color.Gray;
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "E-posta")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void textBox2_VisibleChanged(object sender, EventArgs e)
        {
            textBox2.Text = "şifre";
            textBox2.ForeColor = Color.Gray;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            // TextBox nesnesi odak kazandığında, varsayılan metni kontrol edin ve gerekiyorsa silin
            if (textBox2.Text == "şifre")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black; // Yazı rengini siyah olarak ayarla
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        { // TextBox nesnesinden çıkıldığında, eğer TextBox nesnesi boş ise varsayılan metni göster
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = "şifre";
                textBox2.ForeColor = Color.Gray; // Yazı rengini gri olarak ayarla
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.Text = "E-posta";
                txtEmail.ForeColor = Color.Gray; // Yazı rengini gri olarak ayarla
            }
        }

        private void KayitFormu_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void adTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HastaGirişSayfası hastaGirişSayfası = new HastaGirişSayfası();
            hastaGirişSayfası.Show();
            this.Hide();    
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
