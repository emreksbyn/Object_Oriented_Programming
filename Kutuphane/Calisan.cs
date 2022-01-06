using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel;


namespace Kutuphane
{
    public class Calisan : Insan
    {
        // Kalıtım alan class : Kalıtım alınan class
        // Derived(türeyen) : Base 

        public Calisan()
        {

        }
        public Calisan(string telefon, decimal maas, Departman departmani)
        {
            this.Telefonu = telefon;
            this.Maasi = maas;
            this.Departmani = departmani;
        }
        public Calisan(string adi, string soyadi, DateTime dogumTarihi, bool kadinMi, Lisan anaDili, string telefon, decimal maas, Departman departmani)
        {
            this.Telefonu = telefon;
            this.Maasi = maas;
            this.Departmani = departmani;
        }
        /// <summary>
        /// Çalışanın telefon numarası
        /// </summary>
        [Category("İş Bilgileri")]
        [Description("Çalışanın telefon numarası")]
        public string Telefonu { get; set; }

        [Category("İş Bilgileri")]
        [Description("Çalışanın aldığı maaş")]
        public decimal Maasi { get; set; }

        [Category("İş Bilgileri")]
        [Description("Çalışanın departmanı")]
        public Departman Departmani { get; set; }

        public decimal Zam(decimal zamOrani)
        {
            this.Maasi = (Maasi * zamOrani) + Maasi;
            return Maasi;
        }
        public override string Agla()
        {
            // return base.Agla();
            return "ühühühühü";
        }

        // Kahkaha at metodu virtual alarak belirtilmediği için override edilemez ama new anahtar sözcüğü ile method hiding / shadowing tekniği kullanılabilir.
        new public string KahkahaAt()
        {
            return "muahahahha";
        }
        public override string ToString()
        {
            //return base.ToString();

            return this.Adi + " " + this.Soyadi;
        }
        public void KalitsakOzellikler()
        {
            this.TCKimlikNo = "123123123";
            this.GozRengi = Color.Black;
            this.Boyu = 1.85;
        }

    }
    public enum Departman
    {
        Yazılım,
        Grafik,
        IK,
        Muhasebe
    }
}
