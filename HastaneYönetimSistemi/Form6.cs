using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneYönetimSistemi
{
    public partial class RandevuGirişSayfası : Form
    {
        public RandevuGirişSayfası()
        {
            InitializeComponent();
       
        }
        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
                HastaGirişSayfası form5 = new HastaGirişSayfası();
                form5.Show();
            }
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            HastaneRandevu HastaneRandevu = new HastaneRandevu();
            HastaneRandevu.Show();
            this.Hide();
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
        {
            // TextBox nesnesinden çıkıldığında, eğer TextBox nesnesi boş ise varsayılan metni göster
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = "şifre";
                textBox2.ForeColor = Color.Gray; // Yazı rengini gri olarak ayarla
            }
        }

        private void textBox1_VisibleChanged(object sender, EventArgs e)
        {
            textBox1.Text = "Kimlik No";
            textBox1.ForeColor = Color.Gray;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Kimlik No")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            // TextBox nesnesinden çıkıldığında, eğer TextBox nesnesi boş ise varsayılan metni göster
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Kimlik No";
                textBox1.ForeColor = Color.Gray; // Yazı rengini gri olarak ayarla
            }
        }

        private void Form6_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HastaGirişSayfası form2 = new HastaGirişSayfası();
            form2.Show();
            this.Hide();
        }
    }
}
