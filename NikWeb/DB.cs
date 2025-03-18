using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NikWeb
{
    class DB
    {
        MySqlConnection mySqlConnection = new MySqlConnection("server=127.0.0.1;port=8889;username=root;password=root;database=nikwebsql");

        public void openConnection()
        {
            if (mySqlConnection.State == System.Data.ConnectionState.Closed)
                mySqlConnection.Open();
        }

        public void closeConnection()
        {
            if (mySqlConnection.State == System.Data.ConnectionState.Open)
                mySqlConnection.Close();
        }

        public MySqlConnection getConnection()
        {
            return mySqlConnection;
        }
    }
}
