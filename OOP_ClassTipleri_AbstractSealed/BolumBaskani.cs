using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ClassTipleri_AbstractSealed
{
    // Class' larımız daha özele inmeyecekse senaryonun sonuna gelmişsek bu class' a sealed class denir. Sealed class' tan kalıtım alınamaz.
    public sealed class BolumBaskani : Egitmen
    {
        string _SorumluBolgesi;
        public string SorumluBolgesi
        {
            get { return _SorumluBolgesi; }
            set { _SorumluBolgesi = value; }
        }
        int _SeminerSayisi;
        public int SeminerSayisi
        {
            get { return _SeminerSayisi; }
            set { _SeminerSayisi = value; }
        }

        public void SeminereGit() { }
    }
}
