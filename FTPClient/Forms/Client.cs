using FTPClient.Common;
using FTPClient.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTPClient.Forms
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();

            DirectoryView rootView = new DirectoryView(FTPHelper.Instance.RootUri);
            rootView.Dock = DockStyle.Fill;
            Controls.Add(rootView);
        }
    }
}
