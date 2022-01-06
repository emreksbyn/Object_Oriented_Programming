using System;
using System.Windows.Forms;

namespace MyExceptionClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayi;

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtSayi.Text, out sayi))
                {
                    MessageBox.Show("Convert işlemi başarılı");
                }
                else
                {
                    throw new ConvertHatasi("Girdiğiniz değer convert edilemedi.");
                }
            }
            catch (ConvertHatasi ex)
            {
                this.Text = ex.Message;
                ex.Logla();
                MessageBox.Show("Hata dosyanız oluşmuştur.");
            }
        }
    }
}
