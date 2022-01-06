using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ClassTipleri_AbstractSealed
{
    // Bu class diğer classların ortak noktası olacak. Amacımız ortak özellikleri bir kerede yazıp aktarmaktır. Yani aklımıza inheritance (kalıtım) gelmelidir.
    public abstract class Calisan
    {
        protected string _CalisanNo;
        public string CalisanNo
        {
            get { return _CalisanNo; }
            set { _CalisanNo = value; }
        }
        protected string _CalisanAdiSoyadi;
        public string CalisanAdiSoyadi
        {
            get { return _CalisanAdiSoyadi; }
            set { _CalisanAdiSoyadi = value; }
        }
        protected double _CalisanMaasi;
        public double CalisanMaasi
        {
            get { return _CalisanMaasi; }
            set { _CalisanMaasi = value; }
        }
        protected string _CalisanDepartman;
        public string CalisanDepartman
        {
            get { return _CalisanDepartman; }
            set { _CalisanDepartman = value; }
        }
        protected string _CalisanSirketHatti;
        public string CalisanSirketHatti
        {
            get { return _CalisanSirketHatti; }
            set { _CalisanSirketHatti = value; }
        }
        public void GirisCikisKartiniOkut() { }
        public void RaporVer() { }
        public void MaasiniAl() { }
    }
}
