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
    public partial class DoktorAnaSayfa : Form
    {
        public DoktorAnaSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoktorGirişSayfası doktorGirişSayfası = new DoktorGirişSayfası();
            doktorGirişSayfası.Show();
            this.Hide();    
        }

        private void button6_Click(object sender, EventArgs e)
        {
           DoktorGirişSayfası doktorGiriş = new DoktorGirişSayfası();
            doktorGiriş.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string veri = textBox1.Text;
            listBox1.Items.Add(veri);
        }
    }
}
