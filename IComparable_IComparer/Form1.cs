using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IComparable_IComparer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList listem = new ArrayList();

        private void Form1_Load(object sender, EventArgs e)
        {
            // normal degiskenleri kıyaslamak kolaydir. ancak birden fazla degiskenin bir araya gelerek olusturdugu class gibi komplike yapılarda kıyaslama imkansizdir.cunku sistem hangi ozellige gore kıyaslama yapacagini bilemez. burada biz yardimci oluyorz ve dataların sıralanmasını saglıyoruz. 

            listem.Add(new Ogrenci { Adi = "hakan", Dogumtarihi = DateTime.Now.AddDays(2), OkulNO = 1, Ortalamasi = 3.45, Soyadi = "mart" });
            listem.Add(new Ogrenci { Adi = "ali", Dogumtarihi = DateTime.Now.AddDays(1), OkulNO = 5, Ortalamasi = 2.45, Soyadi = "sart" });
            listem.Add(new Ogrenci { Adi = "deniz", Dogumtarihi = DateTime.Now.AddDays(3), OkulNO = 3, Ortalamasi = 3.35, Soyadi = "kart" });
            listem.Add(new Ogrenci { Adi = "belgin", Dogumtarihi = DateTime.Now.AddDays(5), OkulNO = 2, Ortalamasi = 1.45, Soyadi = "bart" });

        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listem.Sort();
            foreach (var item in listem)
            {
                listBox1.Items.Add(item);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listem.Sort(new OrtalamaKiyaslayici());
            foreach (var item in listem)
            {
                listBox1.Items.Add(item);
            }

        }
    }
}
