using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Berkay_Akar_172114007
{
    public partial class Yönetici : Form
    {
        public Yönetici()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ARABA araba = new ARABA();
            this.Hide();
            araba.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SatısVeFaturalandırma satıs = new SatısVeFaturalandırma();
            this.Hide();
            satıs.Show();

        }
    }
}
