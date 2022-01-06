using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kutuphane;

namespace OOP_Giris_Son
{
    public partial class frmCalisanlar : Form
    {
        public frmCalisanlar()
        {
            InitializeComponent();
        }

        Calisan seciliCalisan;

        private void frmCalisanlar_Load(object sender, EventArgs e)
        {
            int alfabeUzunlugu = YazimKurallari.AlfabeUzunlugu;
            string soyadBuyuk = YazimKurallari.SoyadBuyuk("kısaboyun");
            Matematik.BuyukSayi(5, 10);
            Matematik matematik = new Matematik();
            matematik.Ortalama(15.0, 25.0, 5.0, 6.0);
            //public lstboxCalisanlar
            //lstboxCalisanlar.Modifiers = public

            // lstboxCalisanlar kontrolünün, sadece class içerisinden değil, nesne olarak elde edilmiş bir değişkenden de erişilebilmesi istenirse ;

            // 1) Properties Window'da Modifiers özelliği public/internal yapılmalıdır.
            // 2) frmCalisanlar.Designer.cs dosyasında lstboxCalisanlar nesnesinin tanımlandığı yerde başına public/internal yazılmalıdır.

            cmbAnaDili.Items.Add(Insan.Lisan.Almanca);
            cmbAnaDili.Items.Add(Insan.Lisan.Çince);
            cmbAnaDili.Items.Add(Insan.Lisan.Fransızca);
            cmbAnaDili.Items.Add(Insan.Lisan.İngilizce);
            cmbAnaDili.Items.Add(Insan.Lisan.İspanyolca);
            cmbAnaDili.Items.Add(Insan.Lisan.İtalyanca);
            cmbAnaDili.Items.Add(Insan.Lisan.Rusça);
            cmbAnaDili.Items.Add(Insan.Lisan.Türkçe);

            cmbDepartmani.Items.Add(Departman.Grafik);
            cmbDepartmani.Items.Add(Departman.IK);
            cmbDepartmani.Items.Add(Departman.Muhasebe);
            cmbDepartmani.Items.Add(Departman.Yazılım);

            cmbDepartmani.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAnaDili.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnYeniCalisan_Click(object sender, EventArgs e)
        {
            frmYeniCalisan frm = new frmYeniCalisan(this);

            // Eğer frmYeniCalisan sınıfındaki (formundaki) anaForm değişkeni public olsaydı, aşağıdaki gibi atama yapılabilirdi :
            //frm.anaForm = this;

            frm.ShowDialog();
        }

        private void lstboxCalisanlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            seciliCalisan = lstboxCalisanlar.SelectedItem as Calisan;

            txtAdi.Text = seciliCalisan.Adi;
            txtSoyadi.Text = seciliCalisan.Soyadi;
            txtTelefonu.Text = seciliCalisan.Telefonu;
            datetimeDogumTarihi.Value = seciliCalisan.DogumTarihi;
            numMaasi.Value = seciliCalisan.Maasi;

            if (seciliCalisan.KadinMi)
                radioKadin.Checked = true;
            else
                radioErkek.Checked = true;

            cmbAnaDili.SelectedItem = seciliCalisan.AnaDili;
            cmbDepartmani.SelectedItem = seciliCalisan.Departmani;

            propertyGrid1.SelectedObject = seciliCalisan;
        }

        private void frmCalisanlar_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
            }
        }
    }
}
