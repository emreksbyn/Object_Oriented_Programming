using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kutuphane;
using System.Drawing;
using System.ComponentModel;

namespace Kutuphane
{
    public class Insan
    {
        /// <summary>
        /// Adı
        /// </summary>
        [Category("Kişisel Bilgiler")]
        public string Adi { get; set; }

        /// <summary>
        /// Soyadı
        /// </summary>
        [Category("Kişisel Bilgiler")]
        public string Soyadi { get; set; }

        [Category("Kişisel Bilgiler")]
        public DateTime DogumTarihi { get; set; }

        [Category("Kişisel Bilgiler")]
        public bool KadinMi { get; set; }

        [Category("Kişisel Bilgiler")]
        public Lisan AnaDili { get; set; }

        [Category("Kişisel Bilgiler")]
        internal string TCKimlikNo { get; set; }

        [Category("Kişisel Bilgiler")]
        protected Color GozRengi { get; set; }

        [Category("Kişisel Bilgiler")]
        protected internal double Boyu { get; set; }

        // Bu class' tan kalıtım alacak sınıflarda override edilebilmesi için virtual keyword' une ihtiyacımız vardır.
        public virtual string Agla()
        {
            return "ıngaaaaa";
        }
        public string KahkahaAt()
        {
            return "hahahaha";
        }
        public enum Lisan
        {
            İngilizce,
            Türkçe,
            Almanca,
            Fransızca,
            İtalyanca,
            Rusça,
            İspanyolca,
            Çince
        }
    }
}
