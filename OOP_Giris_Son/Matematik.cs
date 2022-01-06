using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Giris_Son
{
    public class Matematik
    {
        // Static olmayan bir class static bir öğeye sahip olabilir.

        // static bir öğe :
        public static int BuyukSayi(int sayi1, int sayi2)
        {
            if (sayi1 > sayi2)
            {
                return sayi1;
            }
            else
            {
                return sayi2;
            }
        }

        // static olmayan, yani instance bir öğe :
        public double Ortalama(params double[] sayilar)
        {
            double havuz = 0;

            for (int i = 0; i < sayilar.Length; i++)
            {
                havuz += sayilar[i];
            }

            return havuz / sayilar.Length;
        }
    }
}
