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

namespace SuperDelete
{
    public partial class Form1 : Form
    {
        
        private string _dir;
        public Form1()
        {
            InitializeComponent();
            if (Directory.Exists(_dir))
            {
                _dir = dirTxt.Text;
            }
            else
            {
                _dir = "";
                dirTxt.Text = "";
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(_dir))
            {
                DeleteHelper.DeleteDir(_dir);
            }
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                var dir = folderBrowserDialog.SelectedPath;
                if (Directory.Exists(dir))
                {
                    _dir = dir;
                    dirTxt.Text = _dir;
                }
            }
        }

        private void dirTxt_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(dirTxt.Text))
            {
                _dir = dirTxt.Text;
            }
        }
    }
}
