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
    public partial class HastaGirişSayfası : Form
    {
        public HastaGirişSayfası()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // yeni formu ekranın ortasında aç
            this.TopMost = true; // yeni formu en üstte göster
        }
        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
                Anasayfa form1 = new Anasayfa();
                form1.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RandevuGirişSayfası form6 = new RandevuGirişSayfası();
            form6.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KayitFormu kayitFormu = new KayitFormu();
            kayitFormu.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Anasayfa form1 = new Anasayfa();
            form1.Show();
            this.Hide();
        }
    }
}
