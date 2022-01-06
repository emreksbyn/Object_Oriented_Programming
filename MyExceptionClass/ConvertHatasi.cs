using System;
using System.IO;
using System.Text;


namespace MyExceptionClass
{
    public class ConvertHatasi : ApplicationException
    {
        private string _hataMesaji;
        public ConvertHatasi(string hatasi)
        {
            this._hataMesaji = hatasi;
        }

        public override string Message
        {
            get
            {
                return this._hataMesaji;
            }
        }

        public DateTime HataZamani
        {
            get { return DateTime.Now; }
        }

        public void Logla()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.HataZamani.ToString());
            sb.Append(" : ");
            sb.Append(this.Message);
            StreamWriter yazici = new StreamWriter("hatalog.txt");
            yazici.WriteLine(sb.ToString());
            yazici.Close();
        }
    }
}
