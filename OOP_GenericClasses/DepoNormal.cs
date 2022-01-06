using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GenericClasses
{
    public class DepoNormal
    {
        object[] depoelemanlari;
        int elemanSayisi = 0;

        public DepoNormal(int ElemanSayisi)
        {
            depoelemanlari = new object[ElemanSayisi];
        }

        public void NesneEkle(object Eklenecek)
        {
            if (elemanSayisi < depoelemanlari.Length)
            {
                depoelemanlari[elemanSayisi] = Eklenecek;
                elemanSayisi++;
            }
        }
    }
}
