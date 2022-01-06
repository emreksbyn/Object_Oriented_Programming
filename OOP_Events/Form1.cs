using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Events
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Urun urn = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            //Eventler : belirli bir olay olduktan sonra yada belirli bir seviyeye ulastiktan sonra otomatik olarak calisan kod blokları olsuturmak isterseniz event yazmak zorundasınız. bu olayin database karsılıgı triggerdir. ancak trigger performancesiz oldugu için kendi eventinizi yazarsınız. 
            urn = new Urun();
            urn.UrunID = 1;
            urn.UrunAdi = "big babbol";
            urn.UrunUcreti = 10;
            urn.UrunAdedi = 10;
            urn.KritikStokEventi += new StokTemsilcisi(urn_KritikStokEventi);
        }
        void urn_KritikStokEventi(object sender, EventArgs e)
        {
            button1.Enabled = false;
            MessageBox.Show("Urun kritik seviyede lutfen toptanci ile irtibata geciniz");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            urn.UrunAdedi--;
        }
    }
}
