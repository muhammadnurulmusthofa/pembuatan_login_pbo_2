using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace latihan_4
{
    public partial class Form1 : Form
    {

        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 2)
            {
                int n = rnd.Next(0, 2);

                ikan ikan = new ikan(n, textBox1.Text, textBox2.Text);
                MessageBox.Show("Nama : " + ikan.Nama + "\n Owner : " + ikan.Owner + "\n kegiatan : " + ikan.Act() + "\n Kegiatan :" + ikan.Act() + "\n pengurus :" + ikan.Care());

     
            }

            if (comboBox1.SelectedIndex == 1)
            {
                int n = rnd.Next(0, 2);

                kucing kucing = new kucing(n, textBox1.Text, textBox2.Text);
                MessageBox.Show("Nama : " + kucing.Nama + "\n Owner : " + kucing.Owner +  "\n Kegiatan :" + kucing.Act() + "\n pengurus :" + kucing.Care());

            }

            if (comboBox1.SelectedIndex == 1)
            {
                int n = rnd.Next(0, 2);

                anjing anjing = new anjing(n, textBox1.Text, textBox2.Text);
                MessageBox.Show("Nama : " + anjing.Nama + "\n Owner : " + anjing.Owner  + "\n Kegiatan :" + anjing.Act() + "\n pengurus :" + anjing.Care());

            }



        }
    }
}
