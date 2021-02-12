using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUSİNESSLAYER;
using ENTİTYLAYER;
using FACADELAYER;

namespace Berkay_Akar_172114007
{
    public partial class Musteri_Arac : Form
    {
        public Musteri_Arac()
        {
            InitializeComponent();
        }
        void arabalistele()
        {
            List<ENTİTYARABA> araba = BUSİNESSARABA.LiSTELE();
            dataGridView1.DataSource = araba;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            arabalistele();
        }
        public int kendiarabam;
        void kendiarabamilistele()
        {
            List<ENTİTYARABA> araba = BUSİNESSARABA.LiSTELE();
            dataGridView1.DataSource = araba;
        }

        private void button2_Click(object sender, EventArgs e)
        {
             

            
        }

        private void Musteri_Arac_Load(object sender, EventArgs e)
        {

        }
    }
}
