using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_IEnumerator
{
    public class TakimEnumerator : IEnumerator
    {
        Futbolcu[] Oyuncular;
        int index = -1;

        public TakimEnumerator(Futbolcu[] EleAlinacaklar)
        {
            Oyuncular = EleAlinacaklar;
        }

        public object Current
        {
            get
            {

                try
                {
                    return this.Oyuncular[index];
                }
                catch (Exception)
                {
                    throw new InvalidOperationException();
                }

            }
        }

        public bool MoveNext()
        {
            index++;
            return index < Oyuncular.Length;
        }

        public void Reset()
        {
            index = -1;
        }
    }
}
