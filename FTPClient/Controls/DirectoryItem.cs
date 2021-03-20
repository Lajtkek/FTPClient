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

        public event Action<Uri> openDirRequest;

        public DirectoryItem(Uri baseUri, string directoryLine)
        {
            InitializeComponent();

            uri = baseUri;
            var info = directoryLine.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            name = info.Last();
            long.TryParse(info[4], out size);

            int intType = int.Parse(info[1]);
            isDirectory = intType == 2 || intType == 17 || intType == 4;

            file_name.Text = name;
            if (isDirectory)
                file_size.Hide();
            else
                file_size.Text = "(" + size + "b)";

            //fileMenu.Visible = isDirectory;
            //folder_menu.Visible = !isDirectory;
            if (!isDirectory)
            {
                fileMenu.Show();
                folder_menu.Hide();
            }
            else
            {
                fileMenu.Hide();
                folder_menu.Show();
            }
            Size = new Size(300, 30);
        }

        private void DirectoryItem_MouseUp(object sender, MouseEventArgs e)
        {
            //if(e.Button == MouseButtons.Left)
            //{
            // TODO: REMOVE
            //}
        }

        private void Expand_Click(object sender, EventArgs e)
        {
            if (Size.Height == 30)
                Size = new Size(300, 100);
            else
                Size = new Size(300, 30);
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {

        }

        private void rename_btn_Click(object sender, EventArgs e)
        {

        }

        private void download_btn_Click(object sender, EventArgs e)
        {

        }

        private void openDir_btn_Click(object sender, EventArgs e)
        {
            openDirRequest?.Invoke(new Uri(this.uri.ToString() + name));
        }

        private void renameDir_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
