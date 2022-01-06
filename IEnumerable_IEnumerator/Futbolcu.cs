using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_IEnumerator
{
    //Amac : kendi yazdıgınız classlar içerisinde foreach kullanarak her bir elemani disari cikartamazsiniz. bunun için gerekli interface ikisi bunlardir. 
    //bir koleksiyon uzerinden foreach cevirmek isterseniz getEnumerator methoduna sahip olmalısınız. 
    public class Futbolcu
    {
        public int FormaNo { get; set; }
        public string AdiSoyadi { get; set; }
        public string Mevkii { get; set; }
    }
}
