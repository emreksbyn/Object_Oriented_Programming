using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interface
{
    // Bir class sadece tek bir class' tan kalıtım alabilir. Ama birden fazla interface' den kalıtım alabilir.
    // Yazdığımız property ve metodların içleri boş olması gerekir.

    public interface IErkek
    {
        bool _BekarMi { get; set; }
        bool AskerlikYaptimi { get; set; }
        string TrasKopuguMarkasi { get; set; }
        void TrasOL();
        void CumayaGit();
    }
}
