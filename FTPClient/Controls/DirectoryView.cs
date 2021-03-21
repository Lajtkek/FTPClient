using FTPClient.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTPClient.Controls
{
    public partial class DirectoryView : UserControl
    {
        private Uri root;

        public event Action closed;
        public DirectoryView()
        {
            InitializeComponent();

            this.root = Common.FTPHelper.Instance.serverUri;

            label1.Text = this.root.ToString();
            RefreshDirectory();
        }

        public DirectoryView(Uri root)
        {
            InitializeComponent();

            this.root = root;

            label1.Text = this.root.ToString();
            RefreshDirectory();
        }

        private void RefreshDirectory()
        {
            DirectoryItemHolder.Controls.Clear();
            var directoryDetails = FTPHelper.Instance.GetDirectoryDetails(root);
            foreach (string item in directoryDetails)
            {
                DirectoryItem d = new DirectoryItem(root, item);

                AddDirectoryItem(d);
            }
        }

        public void AddDirectoryItem(DirectoryItem d)
        {
            DirectoryItemHolder.Controls.Add(d);
            d.openDirRequest += OpenDir;
        }

        public void OpenDir(Uri u)
        {
            DirectoryView dw = new DirectoryView(u);
            dw.Size = Size;
            dw.Dock = Dock;
            Parent.Controls.Add(dw);
            dw.Show();
            dw.closed += () =>
            {
                Show();
            };
            Hide();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            closed?.Invoke();
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = openFileDialog.FileName;
                    FTPHelper.Instance.UploadFileToFtp(root,filePath);
                    RefreshDirectory();
                }
            }
        }

        private void dirCreate_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
