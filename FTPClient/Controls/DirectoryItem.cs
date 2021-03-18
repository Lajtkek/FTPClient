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
        public DirectoryItem()
        {
            InitializeComponent();
        }

        public DirectoryItem(string directoryLine)
        {
            InitializeComponent();

            label1.Text = directoryLine.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Last();
        }
    }
}
