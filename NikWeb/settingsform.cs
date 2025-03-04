using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NikWeb
{
    public partial class settingsform: Form
    {
        public settingsform()
        {
            InitializeComponent();
        }

        static string appdata = Environment.GetEnvironmentVariable("appdata");
        private string pass = appdata + "/NikWeb/settings.txt";

        private void google_CheckedChanged(object sender, EventArgs e)
        {
            if (File.Exists(pass))
            {
                File.Delete(pass);
                File.Create(pass).Close();
                File.WriteAllText(pass, "https://www.google.com/search?q=");
            }
            else
            {
                File.Create(pass).Close();
                File.WriteAllText(pass, "https://www.google.com/search?q=");
            }
        }

        private void yandex_CheckedChanged(object sender, EventArgs e)
        {
            if (File.Exists(pass))
            {
                File.Delete(pass);
                File.Create(pass).Close();
                File.WriteAllText(pass, "https://ya.ru/search/?text=");
            }
            else
            {
                File.Create(pass).Close();
                File.WriteAllText(pass, "https://ya.ru/search/?text=");
            }
        }

        private void bing_CheckedChanged(object sender, EventArgs e)
        {
            if (File.Exists(pass))
            {
                File.Delete(pass);
                File.Create(pass).Close();
                File.WriteAllText(pass, "https://www.bing.com/search?q=");
            }
            else
            {
                File.Create(pass).Close();
                File.WriteAllText(pass, "https://www.bing.com/search?q=");
            }
        }
    }
}
