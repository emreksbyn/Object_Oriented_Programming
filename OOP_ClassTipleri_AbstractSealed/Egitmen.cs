using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ClassTipleri_AbstractSealed
{
    // Bu şekilde hem interface hem classtan inheritance alınacağında önce class yazılmalıdır.

    public class Egitmen : Calisan, IDisposable
    {
        byte _KacTaneSinifVar;
        public byte KacTaneSinifVar
        {
            get { return _KacTaneSinifVar; }
            set { _KacTaneSinifVar = value; }
        }
        string _HangiSeanslar;
        public string HangiSeanslar
        {
            get { return _HangiSeanslar; }
            set { _HangiSeanslar = value; }
        }
        public void DerseGir() { }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
