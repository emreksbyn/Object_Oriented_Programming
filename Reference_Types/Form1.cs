using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reference_Types
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Class' lar referans tiplilerdir.
            // Class' ları referans eden değişkenler stack bölgesinde tutulur .

            TextBox txt = new TextBox();
            TextBox txt2 = txt;
            txt2.BackColor = Color.White;           

            // txt2' nin arka plan rengini değiştirdiğimizde txt' nin de değişir. Çünkü ikiside Heap' teki aynı adresi referans ediyorlar.


        }
    }
}
