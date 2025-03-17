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
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace NikWeb
{
    public partial class settingsform: Form
    {
        public settingsform()
        {
            InitializeComponent();
        }

        static string system;

        private void enterbtn_Click(object sender, EventArgs e)
        {
            string username = logintextBox.Text;
            string userpassword = passwordtextBox.Text;

            DB dB = new DB();

            DataTable dataTable = new DataTable();

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();

            MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM users WHERE `login` = @uL AND `password` = @uP", dB.getConnection());
            mySqlCommand.Parameters.Add("@uL", MySqlDbType.VarChar).Value = username;
            mySqlCommand.Parameters.Add("@uP", MySqlDbType.VarChar).Value = userpassword;

            mySqlDataAdapter.SelectCommand = mySqlCommand;
            mySqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
                MessageBox.Show("yes");
            else
                MessageBox.Show("no");
        }

        private void applybtn_Click(object sender, EventArgs e)
        {
            if (google.Checked)
            {
                system = "https://www.google.com/search?q=";
                FCreateClass.main(system);
            }

            if (yandex.Checked)
            {
                system = "https://ya.ru/search/?text=";
                FCreateClass.main(system);
            }

            if (bing.Checked)
            {
                system = "https://www.bing.com/search?q=";
                FCreateClass.main(system);
            }
        }

        private void regbtn_Click(object sender, EventArgs e)
        {
            registerform registerform = new registerform();
            registerform.Show();
        }
    }
}
