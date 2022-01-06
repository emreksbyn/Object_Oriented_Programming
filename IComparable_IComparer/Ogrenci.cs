using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparable_IComparer
{
    public class Ogrenci : IComparable
    {
        int _OkulNO;
        public int OkulNO
        {
            get { return _OkulNO; }
            set { _OkulNO = value; }
        }
        string _Adi;
        public string Adi
        {
            get { return _Adi; }
            set { _Adi = value; }
        }
        string _Soyadi;
        public string Soyadi
        {
            get { return _Soyadi; }
            set { _Soyadi = value; }
        }
        DateTime _Dogumtarihi;
        public DateTime Dogumtarihi
        {
            get { return _Dogumtarihi; }
            set { _Dogumtarihi = value; }
        }
        double _Ortalamasi;
        public double Ortalamasi
        {
            get { return _Ortalamasi; }
            set { _Ortalamasi = value; }
        }


        public override string ToString()
        {
            return this._Adi + " " + this._Soyadi;
        }
        public int CompareTo(object obj)
        {
            Ogrenci other = obj as Ogrenci;
            if (this._OkulNO > other._OkulNO) return 1;
            else if (this._OkulNO < other._OkulNO) return -1;
            else return 0;
        }
    }
    //Icomprable kullanırsanız sadece tek bir kıyaslama sistemi yazabilirsiniz. ancak bir cok sirket sahip oldukkları dataları farklı birimlere gore kıyaslarlar. eger siz elinizdeki dataları ortalamalara gore kıyaslamak isterseniz bir kıyaslayıcı yazmak zorundasınız. bunun için IComprarer dan tureyen bir class yazılmalıdır.

    public class OrtalamaKiyaslayici : IComparer
    {
        public int Compare(object x, object y)
        {
            Ogrenci o1 = x as Ogrenci;
            Ogrenci o2 = y as Ogrenci;
            if (o1.Ortalamasi > o2.Ortalamasi) return 1;
            else if (o1.Ortalamasi < o2.Ortalamasi) return -1;
            else return 0;
        }
    }

    //sayısallar bu sekilde yazılır. metinsel ve tarihsel formatlar ise asagidaki sekilde

    public class DogumtKiyaslayici : IComparer
    {
        public int Compare(object x, object y)
        {
            Ogrenci o1 = x as Ogrenci;
            Ogrenci o2 = y as Ogrenci;
            return DateTime.Compare(o1.Dogumtarihi, o2.Dogumtarihi);
        }
    }

}
