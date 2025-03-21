﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NikWeb
{
    public partial class registerform: Form
    {
        public registerform()
        {
            InitializeComponent();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            if(IsUserExsist())
                return;
            DB dB = new DB();

            MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO users (id, login, password, name, surname, email) VALUES (NULL, @login, @password, @name, @surname, @email)", dB.getConnection());
            mySqlCommand.Parameters.Add("@login", MySqlDbType.VarChar).Value = logintxt.Text;
            mySqlCommand.Parameters.Add("@password", MySqlDbType.VarChar).Value = passwordtxt.Text;
            mySqlCommand.Parameters.Add("@name", MySqlDbType.VarChar).Value = nametxt.Text;
            mySqlCommand.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surnametxt.Text;
            mySqlCommand.Parameters.Add("@email", MySqlDbType.VarChar).Value = emailtxt.Text;

            dB.openConnection();

            if (mySqlCommand.ExecuteNonQuery() == 1)
                MessageBox.Show("успешно");
            else
                MessageBox.Show("error");

            dB.closeConnection();
        }

        private Boolean IsUserExsist()
        {
            DB dB = new DB();

            DataTable dataTable = new DataTable();

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();

            MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM users WHERE `login` = @uL", dB.getConnection());
            mySqlCommand.Parameters.Add("@uL", MySqlDbType.VarChar).Value = logintxt.Text;

            mySqlDataAdapter.SelectCommand = mySqlCommand;
            mySqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже существует");
                return true;
            }
            else
                return false;
        }
    }
}
