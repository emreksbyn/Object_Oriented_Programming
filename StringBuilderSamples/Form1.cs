using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringBuilderSamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // String ifadelerin + ile birleştirmek aslında saçma bir yöntemdir. StringBuilder çok daha performanslı bir yöntemdir.

            StringBuilder sb = new StringBuilder();
            sb.Append("Merhaba ");
            sb.Append("bugün ");
            sb.Append("nasilsiniz ?");

            this.Text = sb.ToString();

            sb.AppendLine();
            sb.Append("Yapacak");
            sb.AppendLine();
            sb.Append("işleriniz");
            sb.AppendLine();
            sb.Append("neler ?");
            MessageBox.Show(sb.ToString());
        }
    }
}
