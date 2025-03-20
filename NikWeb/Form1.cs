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
            // private void file_create()
            file_create();

            // NikWeblib.MainClass.searchsys()
            string sys = MainClass.searchsys();
            // change tabpage1.Text, load start page
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
            {
                string search = MainClass.searchsys();
                if (search == "https://www.google.com/search?q=")
                {
                    this.tabPage1.Text = "google";
                }
                if (search == "https://www.bing.com/search?q=")
                {
                    this.tabPage1.Text = "bing";
                }
                if (search == "https://ya.ru/search/?text=")
                {
                    this.tabPage1.Text = "yandex";
                }
                chromiumWebBrowser.Load(inputBox.Text);
            }
            else
            {
                // NikWeblib.mainclass.searchsys()
                string search = MainClass.searchsys();
                // change tabpage 1 text
                if (search == "https://www.google.com/search?q=")
                {
                    this.tabPage1.Text = "google";
                }
                if (search == "https://www.bing.com/search?q=")
                {
                    this.tabPage1.Text = "bing";
                }
                if (search == "https://ya.ru/search/?text=")
                {
                    this.tabPage1.Text = "yandex";
                }
                chromiumWebBrowser.Load(search + inputBox.Text);
            }
        }

        private void settings_Click(object sender, EventArgs e)
        {
            // run settings window
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

        private void searchbutton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ChromiumWebBrowser chromiumWebBrowser = tabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
                if (inputBox.Text.Contains("."))
                {
                    chromiumWebBrowser.Load(inputBox.Text);
                    string search = MainClass.searchsys();
                    chromiumWebBrowser.Load(search + inputBox.Text);
                    if (search == "https://www.google.com/search?q=")
                    {
                        this.tabPage1.Text = "google";
                    }
                    if (search == "https://www.bing.com/search?q=")
                    {
                        this.tabPage1.Text = "bing";
                    }
                    if (search == "https://ya.ru/search/?text=")
                    {
                        this.tabPage1.Text = "yandex";
                    }
                }
                else
                {
                    string search = MainClass.searchsys();
                    chromiumWebBrowser.Load(search + inputBox.Text);
                    if (search == "https://www.google.com/search?q=")
                    {
                        this.tabPage1.Text = "google";
                    }
                    if (search == "https://www.bing.com/search?q=")
                    {
                        this.tabPage1.Text = "bing";
                    }
                    if (search == "https://ya.ru/search/?text=")
                    {
                        this.tabPage1.Text = "yandex";
                    }
                }
            }
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            var index = tabControl.SelectedIndex;
            var tab = tabControl.TabPages[index];
            ChromiumWebBrowser chromiumWebBrowser1 = tabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
            string sys = MainClass.searchsys();
            if (sys == "https://www.google.com/search?q=")
            {
                this.tabPage1.Text = "google";
                tab.Text = "google";
                chromiumWebBrowser1.Load(sys);
                chromiumWebBrowser.Load(sys);
            }
            if (sys == "https://www.bing.com/search?q=")
            {
                this.tabPage1.Text = "bing";
                tab.Text = "bing";
                chromiumWebBrowser1.Load(sys);
                chromiumWebBrowser.Load(sys);
            }
            if (sys == "https://ya.ru/search/?text=")
            {
                this.tabPage1.Text = "google";
                tab.Text = "google";
                chromiumWebBrowser1.Load("https://ya.ru/");
                chromiumWebBrowser.Load("https://ya.ru/");
            }
        }
    }
}
