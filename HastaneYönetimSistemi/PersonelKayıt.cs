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
    public partial class PersonelKayıt : Form
    {
        public PersonelKayıt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Doktor Doktor = new Doktor();
            Doktor.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hemsire form7 = new Hemsire();
            form7.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            YöneticiAnaSayfa yöneticiAnaSayfa = new YöneticiAnaSayfa();
            yöneticiAnaSayfa.Show();
            this.Hide();
        }
    }
}
