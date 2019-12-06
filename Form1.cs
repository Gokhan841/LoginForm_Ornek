using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kullanıcı_Giriş_Ekranı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int sayac = 4;
        PictureBox[] resimler = new PictureBox[5];
        int hak=5;
        int i;
        void hata()
        {
            textBox1.Clear();
            int yeniSayi = rnd.Next(0, 100000000);
            label3.Text = yeniSayi.ToString();
            textBox1.Focus();//imleç yanıp söner
            resimler[sayac].Visible = false;          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          if (textBox1.Text==label3.Text)
            {
                Form2 yeni = new Form2();
                yeni.Show();
                this.Hide(); // bu komut Form2 açıldığında Form1'i kapatır.
            }
          else
            {
                if (hak > 0)
                {
                    hata();
                    sayac--;
                }
                if(sayac<0)
                {
                    textBox1.Text = "";
                    button1.Enabled = textBox1.Enabled = false;
                    button1.BackColor = Color.Red;
                    label3.Text = "********";
                    MessageBox.Show("GİRİŞ SAĞLANAMADI");
                    resimler[0].Visible = true;
                    resimler[1].Visible = true;
                    resimler[2].Visible = true;
                    resimler[3].Visible = true;
                    resimler[4].Visible = true;
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int sayi = rnd.Next(0, 100000000);
            label3.Text = sayi.ToString();
            resimler[0] = pictureBox1;
            resimler[1] = pictureBox2;
            resimler[2] = pictureBox3;
            resimler[3] = pictureBox4;
            resimler[4] = pictureBox5;

        }
    }
}
