using FTPClient.Common;
using FTPClient.Dialog;
using FTPClient.Forms;
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

        LoadingOverlay lo;
        public DirectoryView()
        {
            InitializeComponent();

            this.root = Common.FTPHelper.Instance.serverUri;

            label1.Text = this.root.ToString();

            RefreshDirectory();
        }

        public DirectoryView(Uri root, bool isRoot = false)
        {
            InitializeComponent();

            this.root = root;

            label1.Text = this.root.ToString();

            back_btn.Enabled = !isRoot;
            RefreshDirectory();
        }

        private async void RefreshDirectory()
        {
            DirectoryItemHolder.Controls.Clear();
            var directoryDetails = await FTPHelper.Instance.GetDirectoryDetails(root);
            foreach (string item in directoryDetails)
            {
                var info = item.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                var name = info.Last();

                if (name != "." && name != "..")
                {
                    DirectoryItem d = new DirectoryItem(root, item);
                    AddDirectoryItem(d);
                }
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

        private async void button1_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    LoadStart();
                    var filePath = openFileDialog.FileName;

                    await FTPHelper.Instance.UploadFileToFtp(root, filePath);

                    RefreshDirectory();
                    LoadEnd();
                }
            }
        }

        private void LoadStart()
        {
            if (lo != null) lo.Dispose();

            lo = new LoadingOverlay();
            Controls.Add(lo);
            lo.BringToFront();
            panel1.Enabled = false;
        }

        private void LoadEnd()
        {
            if (lo != null)
            lo.Dispose();
            panel1.Enabled = true;
        }

        private void dirCreate_btn_Click(object sender, EventArgs e)
        {

            SingleInputDialog sid = new SingleInputDialog("Vytvočit adredíš", "Nazev");
            if (sid.ShowDialog() == DialogResult.OK)
            {
                FTPHelper.Instance.CreateDirectory(root, sid.OutputText);
                RefreshDirectory();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DirectoryView dw = new DirectoryView(new Uri(root.ToString() + ".."));
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
    }
}
