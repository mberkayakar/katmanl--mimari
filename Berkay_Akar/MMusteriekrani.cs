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
    public partial class MMusteriekrani : Form
    {
        public MMusteriekrani()
        {
            InitializeComponent();
        }
        void musterilistele()
        {
            List<ENTİTYMUSTERİ> araba = BUSİNESSMUSTERİ.LiSTELE();
            dataGridView1.DataSource = araba;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int Tc_no = int.Parse(txtsil.Text);
            BUSİNESSMUSTERİ.SIL(Tc_no);
            MessageBox.Show("Musteri Silindi ");
        }
        public int tc_no=10;
        void tcnolistele(int saseno)
        {
            List<ENTİTYMUSTERİ> musteri = BUSİNESSMUSTERİ.tcnolistele(tc_no);
            dataGridView1.DataSource = musteri;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            tcnolistele(tc_no);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            musteritc.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Musteriisim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            musterisoyisim.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string cinsiyet = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            switch (cinsiyet)
            {
                case "Kadın": radioButton1.Checked = true; break;
                case "Erkek": radioButton2.Checked = true; break;

            }




            musteriil.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            adres.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            sifre.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
        string cinsiyet;
        private void button2_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                cinsiyet = "Erkek";
            }

            if (radioButton2.Checked == true)
            {
                cinsiyet = "Kadın";
            }

            ENTİTYMUSTERİ musteri = new ENTİTYMUSTERİ();
            musteri.Tc_no = int.Parse(musteritc.Text);
            musteri.Isim = Musteriisim.Text;
            musteri.Soyisim = musterisoyisim.Text;
            musteri.Cinsiyet = cinsiyet;
            musteri.Yasadigi_il = musteriil.Text;
            musteri.Adress = adres.Text;
            musteri.Sifre = Convert.ToInt32( sifre.Text);

            BUSİNESSMUSTERİ.Guncelle(musteri);
            MessageBox.Show("Musteri Güncellemesi  Yapıldı");
        }
    }
}
