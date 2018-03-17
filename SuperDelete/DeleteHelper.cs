using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SuperDelete
{
    public static class DeleteHelper
    {
        private static readonly string File = Path.Combine(Directory.GetCurrentDirectory(), "fastdel.bat");
        public static void DeleteDir(string dir)
        {
            Directory.SetCurrentDirectory(dir);
            var process = Process.Start(File);
            process?.Close();
            MessageBox.Show("123");
        }
    }
}
