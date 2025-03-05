using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NikWeblib
{
    public class MainClass
    {
        static string appdata = Environment.GetEnvironmentVariable("appdata");
        public static string file = appdata + "/NikWeb/settings.txt";
        public static string searchsys()
        {
            StreamReader streamReader = new StreamReader(file);
            string searchsystem = streamReader.ReadLine();
            streamReader.Close();
            return searchsystem;
        }
    }
}
