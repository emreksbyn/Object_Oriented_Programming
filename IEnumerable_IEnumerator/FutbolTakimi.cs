using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_IEnumerator
{
    public class FutbolTakimi : IEnumerable
    {
        private Futbolcu[] TakimSporculari;

        public FutbolTakimi(Futbolcu[] Liste)
        {
            this.TakimSporculari = Liste;
        }
        public IEnumerator GetEnumerator()
        {
            //elimizde IEnumerator den turemis bir class olmadigi icin yeni bir class yazılır ve Ienumerator turer.
            return new TakimEnumerator(TakimSporculari);
        }
    }
}
