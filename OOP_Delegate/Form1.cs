using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Delegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //delegelerde bir classtır.

        //sizi temsil eden sizin yerinize isleri yapan nesneler demektir. her turlu isi yaparlar yeterki ise uygun bir temsilci oluşturulsun. 
        public void selamla()
        {
            MessageBox.Show("selamlar");
        }
        public void renklendir()
        {
            this.BackColor = Color.Red;
        }

        public string Raporver(string adiniz)
        {
            return "rapor veren kisi : " + adiniz;
        }

        public delegate string DandikDelege(string ad);
        public delegate void Temsilci();

        private void button1_Click(object sender, EventArgs e)
        {
            Temsilci t = new Temsilci(renklendir);
            t.Invoke();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DandikDelege dlg = new DandikDelege(Raporver);
            this.Text = dlg.Invoke("osman");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //her method için delege yazilmaz. birbirlerine yapı olarak yakın olan methodlar tek bir temsilci ile calistirilabilir. Invoke yerine () yapılarakta delege işi yapar.  
            Temsilci t1 = new Temsilci(selamla);
            t1();
        }
    }
}

