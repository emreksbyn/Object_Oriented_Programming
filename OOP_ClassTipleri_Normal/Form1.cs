using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_ClassTipleri_Normal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Mahkum m = new Mahkum();
            m.AdiSoyadi = "Suç Makinesi";
            m.KacYil = 50;
            m.MahkumNo = 000001;
            m.Sucu = SucTipi.Cinayet;

            Mahkum mahkum = new Mahkum(000002, "Mafya Babası", SucTipi.Dolandiricilik, 67);

            Mahkum mahkum1 = new Mahkum()
            {
                AdiSoyadi = "Asd Qwerty",
                KacYil = 1,
                MahkumNo = 000003,
                Sucu = SucTipi.Hirsizlik
            };
        }
    }
}
