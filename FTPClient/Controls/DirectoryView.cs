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
    public partial class DirectoryView : UserControl
    {
        private Uri root;
        public DirectoryView(Uri root = null)
        {
            InitializeComponent();

            this.root = root != null ? root : Common.FTPHelper.Instance.serverUri;

            label1.Text = this.root.ToString();
        }

        public void AddDirectoryItem(DirectoryItem d)
        {
            DirectoryItemHolder.Controls.Add(d);
        }
    }
}
