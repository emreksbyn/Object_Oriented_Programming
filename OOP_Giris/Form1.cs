using System;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_Giris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Otomobil 
        {
            // Default constructor.
            public Otomobil()
            {

            }



            // Instance alırken farklı opsiyonlar meydana gelmesi istenirse özelleştirilmiş constructor tanımlanır.
            public Otomobil(DateTime uretimTarihi)
            {
                this._UretimTarihi = uretimTarihi;
            }




            // Auto-Implemented Property' ler tanımladık
            public string Markasi { get; set; }
            public string Modeli { get; set; }
            public Color Rengi { get; set; }
            public int Hizi { get; set; }


            private double _MotorHacmi; // Field tanımladık
            public double MotorHacmi // Field' a Encapsulation işlemi yapıldı
            {
                // Property okunduğunda, talep edildiğinde çalışır.
                get
                {
                    return _MotorHacmi / 1000; 
                }
                // property' e değer atanacağı zaman çalışır.
                set
                {
                    _MotorHacmi = value;
                }
            }
            // Sadece get bloğundan oluşursa bu property Read-Only 'dir.



            private string _GovdeTipi;
            public string GovdeTipi { get => _GovdeTipi; set => _GovdeTipi = value; }


            private DateTime _UretimTarihi;           
            public string UretimTarihi
            {
                // read-only bir property :
                get
                {
                    return _UretimTarihi.ToShortDateString();
                }
            }

            public string KornaCal()
            {
                return "dütdüt";
            }

            public void SelektorYap()
            {
                // Selektör işlemi..
            }

            public void Calis()
            {
                // Çalışma işlemi
            }

            public override string ToString()
            {
                //return base.ToString();
                return this.Markasi + "-" + this.Modeli;
            }

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            Otomobil mercedes = new Otomobil();
            mercedes.Markasi = "Mercedes";
            mercedes.Modeli = "SLS 65 AMG";
            mercedes.MotorHacmi = 5000;
            double a = mercedes.MotorHacmi;
            string tarih = mercedes.UretimTarihi;

            Otomobil bmw = new Otomobil(new DateTime(1999, 6, 13));
            bmw.Markasi = "BMW";
            bmw.Modeli = "M3";

            MessageBox.Show(bmw.ToString());
            MessageBox.Show(mercedes.ToString());

            lstboxNesneler.Items.Add(mercedes);
            lstboxNesneler.Items.Add(bmw);
           
        }
        BMW bmw = new BMW();

    }
}
