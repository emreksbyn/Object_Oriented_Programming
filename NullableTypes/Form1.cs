using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NullableTypes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //reference tipler null gecilebilir durumdadırlar. 
            string kelime = null;
            Button btn = null;

            // value types null deger alamaz. normal degiskenlerinizin null gecilebilmesi için nullable bir ozellige sahip olması gerekir. 2 sekilde yapılır. 
            int? sayi = null;
            Nullable<float> sayim = new Nullable<float>();

            int toplam = sayi.GetValueOrDefault(0);

            toplam = sayi.HasValue ? sayi.Value : 0;
        }
    }
}
