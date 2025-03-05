using CefSharp.WinForms;
using FCreate;
using NikWeblib;
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
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string appdata = Environment.GetEnvironmentVariable("appdata");

        private void file_create()
        {
            string file = appdata + "/NikWeb/settings.txt";
            if (File.Exists(file))
                return;
            else
            {
                File.Create(file).Close();
                File.WriteAllText(file, "https://www.google.com/search?q=");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            file_create();
            string sys = MainClass.searchsys();
            if (sys == "https://www.google.com/search?q=")
            {
                this.tabPage1.Text = "google";
                chromiumWebBrowser.Load(sys);
            }
            if (sys == "https://www.bing.com/search?q=") 
            {
                this.tabPage1.Text = "bing";
                chromiumWebBrowser.Load(sys);
            }
            if (sys == "https://ya.ru/search/?text=")
            {
                this.tabPage1.Text = "yandex";
                chromiumWebBrowser.Load("https://ya.ru/");
            }
        }

        private void newtabbutton_Click(object sender, EventArgs e)
        {
            TabPage tabPage = new TabPage();
            tabPage.Text = "новая вкладка";
            tabControl.Controls.Add(tabPage);
            ChromiumWebBrowser chromiumWebBrowser = new ChromiumWebBrowser();
            tabPage.Controls.Add(chromiumWebBrowser);
            chromiumWebBrowser.Dock = DockStyle.Fill;
            tabControl.SelectTab(tabPage);
        }

        private void closetabbutton_Click(object sender, EventArgs e)
        {
            if (tabControl.TabCount == 1)
                this.Close();
            var index = tabControl.SelectedIndex;
            var tab = tabControl.TabPages[index];
            tabControl.Controls.Remove(tab);
            tabControl.SelectedIndex = index - 1;
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            ChromiumWebBrowser chromiumWebBrowser = tabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
            if (inputBox.Text.Contains("."))
                chromiumWebBrowser.Load(inputBox.Text);
            else
            {
                string search = MainClass.searchsys();
                chromiumWebBrowser.Load(search + inputBox.Text);
            }
            if (inputBox.Text.Contains(". "))
            {
                string search = MainClass.searchsys();
                chromiumWebBrowser.Load(search + inputBox.Text);
            }
        }

        private void settings_Click(object sender, EventArgs e)
        {
            settingsform settingsform = new settingsform();
            settingsform.Show();
        }

        private void inputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ChromiumWebBrowser chromiumWebBrowser = tabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
                if (inputBox.Text.Contains("."))
                    chromiumWebBrowser.Load(inputBox.Text);
                else
                {
                    string search = MainClass.searchsys();
                    chromiumWebBrowser.Load(search + inputBox.Text);
                }
            }
        }
    }
}
