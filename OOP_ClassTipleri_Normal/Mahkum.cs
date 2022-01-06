using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ClassTipleri_Normal
{
    public enum SucTipi : byte
    {
        Hirsizlik = 1, Gasp, Dolandiricilik, Cinayet
    }
    public class Mahkum : IDisposable
    {
        private int _mahkumNo;
        public int MahkumNo
        {
            get { return _mahkumNo; }
            set { _mahkumNo = value; }
        }
        private string _AdiSoyadi;
        public string AdiSoyadi
        {
            get { return _AdiSoyadi; }
            set { _AdiSoyadi = value; }
        }
        private SucTipi _Sucu;
        public SucTipi Sucu
        {
            get { return _Sucu; }
            set { _Sucu = value; }
        }
        private byte _kacYil;
        public byte KacYil
        {
            get { return _kacYil; }
            set { _kacYil = value; }
        }

        public Mahkum() { }
        public Mahkum(int NosuKac, string Adine, SucTipi SucuNe, byte kacYilyatacak)
        {
            this._AdiSoyadi = Adine;
            this._kacYil = kacYilyatacak;
            this._mahkumNo = NosuKac;
            this._Sucu = SucuNe;
        }

        public void TunelKaz(int kacM)
        { }
        public void KavgayaKaris(string kiminle)
        { }
        public string KendiniTanit()
        {
            return this._AdiSoyadi;
        }
        public void Dispose()
        {
           GC.SuppressFinalize(this);
        }
    }
}
