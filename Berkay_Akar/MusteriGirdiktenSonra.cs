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
    public partial class MusteriGirdiktenSonra : Form
    {
        public MusteriGirdiktenSonra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Musteri_Arac musteri = new Musteri_Arac();
            this.Hide();
            musteri.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MMusteriekrani mm = new MMusteriekrani();
            mm.Show();
            this.Hide();
        }
    }
}
