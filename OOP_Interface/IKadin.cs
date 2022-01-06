using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interface
{
    public interface IKadin
    {
        bool _Bekarmi { get; set; }
        string _Sacrengi { get; set; }
        bool _AnneMi { get; set; }
        string _RujMarkasi { get; set; }

        void MakyajYap();


    }
}
