using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GenericClasses
{
    public class DepoGeneric<T>
    {
        T[] depoelemanlari;
        int elemanSayisi = 0;

        public DepoGeneric(int ElemanSayisi)
        {
            depoelemanlari = new T[ElemanSayisi];
        }

        public void NesneEkle(T Eklenecek)
        {
            if (elemanSayisi < depoelemanlari.Length)
            {
                depoelemanlari[elemanSayisi] = Eklenecek;
                elemanSayisi++;
            }
        }
    }
}
