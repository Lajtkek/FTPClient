using FTPClient.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTPClient.Controls
{
    public partial class DirectoryItem : UserControl
    {
        private Uri uri;
        private string name;
        private long size = 0;
        private bool isDirectory;
        public DirectoryItem()
        {
            InitializeComponent();
        }

        public DirectoryItem(Uri baseUri, string directoryLine)
        {
            InitializeComponent();

            var info = directoryLine.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            name = info.Last();
            long.TryParse(info[4], out size);

            int intType = int.Parse(info[1]);
            isDirectory = intType != 2 && intType != 17 && intType != 4;

            label1.Text = name + "(" + (isDirectory ? (size + "b)") : "directory)");
        }

        private void DirectoryItem_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Size = new Size(300, 80);
            }
        }
    }
}
