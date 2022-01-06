using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEnumerable_IEnumerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Futbolcu[] oyuncular = {
                                   new Futbolcu{ AdiSoyadi="Drogba", FormaNo=9, Mevkii="FW"},
                                   new Futbolcu{AdiSoyadi="Muslera", FormaNo=1, Mevkii="KL"},
                                   new Futbolcu{AdiSoyadi="Fatih", FormaNo=5, Mevkii="DOS"}
                                   };

            FutbolTakimi ft = new FutbolTakimi(oyuncular);
            foreach (Futbolcu item in ft)
            {
                MessageBox.Show(item.AdiSoyadi);
            }
        }
    }
}
