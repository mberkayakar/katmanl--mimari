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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sifre, tckimlikno;

        private void button2_Click(object sender, EventArgs e)
        {
             //tckimlikno = int.Parse( textBox3.Text);
            // sifre= int.Parse(textBox4.Text);





            Yönetici yönetici = new Yönetici();
            this.Hide();
            yönetici.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MusteriGirdiktenSonra musteri = new MusteriGirdiktenSonra();
            this.Hide();
            musteri.Show();
        }
    }
}
