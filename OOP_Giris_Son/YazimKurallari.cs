using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Giris_Son
{
    public static class YazimKurallari
    {
        // Static class içerisnideki herşey static olmak zorundadır. Instance almayı gerektirecek hiç birşeyi içinde barındırmazlar.

        //public YazimKurallari()
        //{
        //    // Static classes cannot have instance constructors
        //}

        //public string OzelIsim(string isim)
        //{
        //    // cannot declare instance members in a static class (Bir static class içerisinde instance öğe tanımlanamaz)
        //    return isim[0].ToString().ToUpper() + isim.Substring(1).ToLower();
        //}

        public static string OzelIsim(string isim)
        {
            return isim[0].ToString().ToUpper() + isim.Substring(1).ToLower();
        }

        public static string SoyadBuyuk(string soyisim)
        {
            return soyisim.ToUpper();
        }

        //public static int AlbafeUzunlugu = 29;

        // const (constant - sabit) değişkenler, özünde zaten sabit olduklarından dolayı, static class içerisinde tanımlanabilirler. static anahtar sözcüğüne gerek duymazlar, hatta static anahtar sözcüğü kullanılamaz :
        public const int AlfabeUzunlugu = 29;
    }
}
