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
    public partial class YöneticiAnaSayfa : Form
    {
        public YöneticiAnaSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonelKayıt personelKayıt= new PersonelKayıt();
            personelKayıt.Show();
            this.Hide();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            YöneticiGirişSayfası form2 = new YöneticiGirişSayfası();
            form2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HastaListesi hastaListesi = new HastaListesi();
            hastaListesi.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HastaBilgileri hastagiriş = new HastaBilgileri();
            hastagiriş.Show();
            this.Hide();
        }
    }
}
