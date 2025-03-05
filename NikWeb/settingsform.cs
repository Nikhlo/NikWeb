using System;
using FCreate;
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

        static string system;

        static string appdata = Environment.GetEnvironmentVariable("appdata");
        private string pass = appdata + "/NikWeb/settings.txt";

        private void google_CheckedChanged(object sender, EventArgs e)
        {
            system = "https://www.google.com/search?q=";
            FCreateClass.main(system);
        }

        private void yandex_CheckedChanged(object sender, EventArgs e)
        {
            system = "https://ya.ru/search/?text=";
            FCreateClass.main(system);
        }

        private void bing_CheckedChanged(object sender, EventArgs e)
        {
            system = "https://www.bing.com/search?q=";
            FCreateClass.main(system);
        }
    }
}
