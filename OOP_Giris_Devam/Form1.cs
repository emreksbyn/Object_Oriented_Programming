using System;
using System.Windows.Forms;
using Kutuphane;

namespace OOP_Giris_Devam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Calisan isci = new Calisan();
            isci.Adi = "Emre";
            isci.Soyadi = "Kısaboyun";
            isci.KadinMi = false;
            isci.DogumTarihi = new DateTime(1995, 6, 8);
            isci.AnaDili = Insan.Lisan.Türkçe;
            isci.Departmani = Departman.Yazılım;
            isci.Maasi = 7000;
            isci.Telefonu = "0212 212 12 12";

            MessageBox.Show(isci.Agla());
            MessageBox.Show(isci.KahkahaAt());

            // Cating yöntemi ile isci nesnesi Insan tipinde yakalandı.
            Insan insan = (Calisan)isci;
            MessageBox.Show(insan.Agla());
            MessageBox.Show(insan.KahkahaAt());

            Personel p = new Personel();
            p.SicilNo = 123123;

            // SicilNo ya erişebiliriz ama SSKNo ya erişemeyiz çünkü protected modifier access ' e sahiptir.
        }
    }
}
