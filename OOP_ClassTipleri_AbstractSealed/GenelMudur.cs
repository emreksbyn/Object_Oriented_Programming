using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ClassTipleri_AbstractSealed
{
    public class GenelMudur : Calisan
    {
        int _HisseSayisi;

        public int HisseSayisi
        {
            get { return _HisseSayisi; }
            set { _HisseSayisi = value; }
        }

        // Polymorphism, çok yönlülük demektir.
        // Nesnelerin ortak noktaları bulunarak, hepsinin üstünde geçerli olacak bir metod tanımlandığında bu metoda polymorfik metod denir.

        public void Kov(Calisan kovulacak) { }

    }
}
