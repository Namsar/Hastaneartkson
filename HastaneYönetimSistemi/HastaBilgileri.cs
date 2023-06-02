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
    public partial class HastaBilgileri : Form
    {
        public HastaBilgileri()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            YöneticiAnaSayfa hastagiriş = new YöneticiAnaSayfa();
            hastagiriş.Show();
            this.Hide();
        }
    }
}
