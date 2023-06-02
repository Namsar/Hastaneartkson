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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YöneticiGirişSayfası form2 = new YöneticiGirişSayfası();
            form2.Show();
            this.Hide();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoktorGirişSayfası form3 = new DoktorGirişSayfası();
            form3.Show();
            this.Hide();
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            HemşireGirişSayfası form4 = new HemşireGirişSayfası();
            form4.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HastaGirişSayfası form5 = new HastaGirişSayfası();
            form5.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Doktor doktor = new Doktor();
            doktor.Show();
            this.Hide();
        }
    }
}
