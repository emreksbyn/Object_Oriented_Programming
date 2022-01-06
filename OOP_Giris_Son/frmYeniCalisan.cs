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
    public partial class frmYeniCalisan : Form
    {
        public frmYeniCalisan()
        {
            InitializeComponent();
        }

        public frmYeniCalisan(frmCalisanlar form)
        {
            InitializeComponent();
            anaForm = form;
            this.ShowInTaskbar = false;
        }

        frmCalisanlar anaForm;

        private void frmYeniCalisan_Load(object sender, EventArgs e)
        {
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

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox && (String.IsNullOrEmpty(item.Text)))
                {
                    errorProvider1.SetError(item, "Bu alan boş bırakılamaz!");
                    return;
                }
                else if (item is NumericUpDown && (item as NumericUpDown).Value == 0)
                {
                    errorProvider1.SetError(item, "Maaş belirtmelisiniz!");
                    return;
                }
                else if (item is DateTimePicker && ((DateTimePicker)item).Value > DateTime.Now)
                {
                    errorProvider1.SetError(item, "Geçerli bir tarih giriniz!");
                    return;
                }
                else if (!radioErkek.Checked && !radioKadin.Checked)
                {
                    errorProvider1.SetError(radioKadin, "Cinsiyet belirtmelisiniz!");
                    return;
                }
                else if (item is ComboBox && (item as ComboBox).SelectedItem == null)
                {
                    errorProvider1.SetError(item, "Bir seçim yapmalısınız!");
                    return;
                }
            }

            // Object-Initialization :

            Calisan yeniCalisan = new Calisan()
            {
                Adi = YazimKurallari.OzelIsim(txtAdi.Text),
                Soyadi = YazimKurallari.SoyadBuyuk(txtSoyadi.Text),
                DogumTarihi = datetimeDogumTarihi.Value,
                AnaDili = (Insan.Lisan)cmbAnaDili.SelectedItem,
                KadinMi = radioKadin.Checked,
                Maasi = numMaasi.Value,
                Telefonu = txtTelefonu.Text,
                Departmani = (Departman)cmbDepartmani.SelectedItem
            };


            anaForm.lstboxCalisanlar.Items.Add(yeniCalisan);

            Temizle();
        }

        public void Temizle()
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.ResetText();
                }
                else if (item is NumericUpDown)
                {
                    (item as NumericUpDown).Value = 0;
                }
                else if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value = DateTime.Now;
                }
                else if (item is RadioButton)
                {
                    (item as RadioButton).Checked = false;
                }
                else if (item is ComboBox)
                {
                    (item as ComboBox).SelectedIndex = 0;
                }
            }
        }
    }
}
