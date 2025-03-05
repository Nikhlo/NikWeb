using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCreate
{
    public class FCreateClass
    {
        static string appdata = Environment.GetEnvironmentVariable("appdata");
        static string file = appdata + "/NikWeb/settings.txt";
        public static void main(string searchsys)
        {
            if (File.Exists(file))
            {
                File.Delete(file);
                File.Create(file).Close();
                File.WriteAllText(file, searchsys);
            }
            else
            {
                File.Create(file).Close();
                File.WriteAllText(file, searchsys);
            }
        }
    }
}
