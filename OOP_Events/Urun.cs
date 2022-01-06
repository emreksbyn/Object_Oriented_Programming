using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Events
{
    //sizin yerinize depo gorevlisi gibi stokları takip eden bir temsilciye ihityacınız var. 
    //eventler void yapılardir. 
    public delegate void StokTemsilcisi(object sender, EventArgs e);

    public class Urun
    {
        public event StokTemsilcisi KritikStokEventi;

        private string _urunAdi;
        public string UrunAdi
        {
            get { return _urunAdi; }
            set { _urunAdi = value; }
        }
        private int _urunAdedi;
        public int UrunAdedi
        {
            get { return _urunAdedi; }
            set
            {
                _urunAdedi = value;
                if (KritikStokEventi != null)
                {
                    if (this._urunAdedi < 5)
                    {
                        KritikStokEventi(this, new EventArgs());
                    }
                }
            }
        }
        private double _urunUcreti;
        public double UrunUcreti
        {
            get { return _urunUcreti; }
            set { _urunUcreti = value; }
        }
        private int _urunID;
        public int UrunID
        {
            get { return _urunID; }
            set { _urunID = value; }
        }
    }
}
