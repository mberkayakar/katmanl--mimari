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
    public partial class ARABA : Form
    {
        public ARABA()
        {
            InitializeComponent();
        }

        private void ARABA_Load(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
            string[] kasatipleri = { "Coupe", "Sedan", "Hatchbag" };
            string[] kapisayisi = { "2", "4" };
            comboBox1.Items.AddRange(kasatipleri);
            comboBox2.Items.AddRange(kapisayisi);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {/*
            if (checkBox1.Checked==true)
            {
                groupBox1.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ENTİTYARABA araba = new ENTİTYARABA();
            araba.Sase_No1 = Convert.ToInt32(textBox1.Text);
            araba.Marka1 = textBox2.Text;
            araba.Model1 = textBox3.Text;
            araba.Kasa_tipi = comboBox1.SelectedItem.ToString();
            araba.Kapı_sayısı= Convert.ToInt32(comboBox2.SelectedItem);
            araba.Uretim_yili = int.Parse(textBox4.Text);
            araba.Plaka = textBox5.Text;
            araba.Kilometre =int.Parse( textBox6.Text);
            araba.Satilikmi = comboBox3.SelectedItem.ToString();
            araba.Fiyat = int.Parse(textBox7.Text);

            BUSİNESSARABA.Ekle(araba);
            MessageBox.Show("Araba Kaydı Yapıldı");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ENTİTYARABA araba = new ENTİTYARABA();
            araba.Sase_No1 = Convert.ToInt32(textBox1.Text);
            araba.Marka1 = textBox2.Text;
            araba.Model1 = textBox3.Text;
            araba.Kasa_tipi = comboBox1.SelectedItem.ToString();
            araba.Kapı_sayısı = Convert.ToInt32(comboBox2.SelectedItem);
            araba.Uretim_yili = int.Parse(textBox4.Text);
            araba.Plaka = textBox5.Text;
            araba.Kilometre = int.Parse(textBox6.Text);
            araba.Satilikmi = comboBox3.SelectedItem.ToString();
            araba.Fiyat = int.Parse(textBox7.Text);

            BUSİNESSARABA.Guncelle(araba);
            MessageBox.Show("Araba Güncellemesi Yapılmıştır ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sase_so = int.Parse(txtsil.Text);
            BUSİNESSARABA.SIL(sase_so);
            MessageBox.Show("Araba Silindi ");
            dataGridView1.ClearSelection();



        }

        void arabalistele() {
            List<ENTİTYARABA> araba = BUSİNESSARABA.LiSTELE();
            dataGridView1.DataSource = araba;
        }

 
        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label13.Visible = false;
            textBox8.Visible = false;
            button6.Visible = false;

            button5.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button5.Visible =false;

            label13.Visible = true;
            textBox8.Visible = true;
            button6.Visible = true;



        }

        private void button5_Click(object sender, EventArgs e)
        {
            arabalistele();
        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

             textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox1.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox2.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox4.Text= dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox5.Text= dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox6.Text= dataGridView1.CurrentRow.Cells[8].Value.ToString();
            comboBox3.Text= dataGridView1.CurrentRow.Cells[9].Value.ToString();
            textBox7.Text= dataGridView1.CurrentRow.Cells[10].Value.ToString();




        }

      void sasenoilelistele(int saseno)
        {
        List<ENTİTYARABA> araba = BUSİNESSARABA.sasenoluaraciguncelle(saseno);
        dataGridView1.DataSource = araba;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int saseno = int.Parse(textBox8.Text);
            sasenoilelistele(saseno);


        }
    }
}
