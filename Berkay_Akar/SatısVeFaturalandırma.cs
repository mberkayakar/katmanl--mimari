using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTİTYLAYER;
using BUSİNESSLAYER;
using FACADELAYER;

namespace Berkay_Akar_172114007
{
    public partial class SatısVeFaturalandırma : Form
    {
        public SatısVeFaturalandırma()
        {
            InitializeComponent();
        }

        private void geridön_Click(object sender, EventArgs e)
        {
            int sase_no = int.Parse(sase.Text);
            int tcno = int.Parse(textBox1.Text);
            int fiyat = int.Parse(textBox2.Text);


            ENTİTYFATURA araba = new ENTİTYFATURA();
            araba.Saseno= Convert.ToInt32(sase.Text);
            araba.Tcno =Convert.ToInt32( textBox1.Text);
            araba.Fiyat= Convert.ToInt32( textBox2.Text);
 

 BUSİNESSFATURA.FaturaEkle(araba);
            MessageBox.Show("Araba Kaydı Yapıldı");


        }
    }
}
