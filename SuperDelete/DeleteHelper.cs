using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SuperDelete
{
    public static class DeleteHelper
    {
        public static void DeleteDir(string dir)
        {
            try
            {
                var deleteFilesCmd = $"/C del /f /s /q {dir} > nil";
                var deleteFoldersCmd = $"/C rmdir /s /q {dir}";
                Interaction.Shell(deleteFilesCmd, AppWinStyle.Hide);
                Interaction.Shell(deleteFoldersCmd, AppWinStyle.Hide);
                //System.Diagnostics.Process.Start("CMD.exe", deleteFilesCmd);
                //System.Diagnostics.Process.Start("CMD.exe", deleteFoldersCmd);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, @"Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            
        }
    }
}
