using Kutuphane;
using System.Drawing;

namespace OOP_Giris_Devam
{
    public class Personel : Insan
    {

        public Personel()
        {
            this.Boyu = 1.85;
            this.GozRengi = Color.Brown;
            // Boyu (protected-internal) ve GozRengi (protected) 
        }

        // SSKNo sadece bu class'tan kalıtım alan class içerisinden erişilir:
        protected string SSKNo { get; set; }

        // SicilNo hem bu class'tan kalıtım alan class içerisinden, hem de içerisinde bulunduğu proje içerisinden erişilebilir:
        protected internal int SicilNo { get; set; }

    }
}
