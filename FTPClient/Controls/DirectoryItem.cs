using FTPClient.Common;
using FTPClient.Dialog;
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
            isDirectory = intType != 1; //intType == 2 || intType == 17 || intType == 4 || intType == 5;

            file_name.Text = name;
            if (isDirectory)
                file_size.Hide();
            else
                file_size.Text = Helper.FormatBytes(size);

            //fileMenu.Visible = isDirectory;
            //folder_menu.Visible = !isDirectory;
            var location = new Point(270, 3);
            if (!isDirectory)
            {
                fileMenu.Show();
                fileMenu.Location = location;
                folder_menu.Hide();
            }
            else
            {
                fileMenu.Hide();
                folder_menu.Show();
                folder_menu.Location = location;
            }
            Size = new Size(Size.Width,32);
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
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                FTPHelper.Instance.DeleteFileFromFtp(new Uri(uri.ToString() + "/" + name));
                Dispose();
            }
            else
            {
                // If 'No', do something here.
            }
        }

        private void rename_btn_Click(object sender, EventArgs e)
        {
            SingleInputDialog sid = new SingleInputDialog("Přejmenovat soubor", "Nový název", "Přejmenovat");
            if (sid.ShowDialog() == DialogResult.OK)
            {
                if (FTPHelper.Instance.RenameFile(new Uri(uri.ToString() + "/" + name), sid.OutputText)){
                    name = sid.OutputText;
                    file_name.Text = name;
                } else
                    MessageBox.Show("Něco se pokazilo, asi nemáte práva");
            }
        }

        private async void download_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = name;
            saveFileDialog1.Filter = "Any (.*)|*.*"; // Filter files by extension

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                await FTPHelper.Instance.DownloadFileFTP(new Uri(uri.ToString() + "/" + name), saveFileDialog1.FileName);               
            }
        }

        private void openDir_btn_Click(object sender, EventArgs e)
        {
            openDirRequest?.Invoke(new Uri(uri.ToString()  + "/" + name));
        }

        private void renameDir_btn_Click(object sender, EventArgs e)
        {
            SingleInputDialog sid = new SingleInputDialog("Přejmenovat složku","Nový název", "Přejmenovat");
            if(sid.ShowDialog() == DialogResult.OK)
            {
                if (FTPHelper.Instance.RenameFile(new Uri((uri.ToString() + "/" + name).TrimEnd('/')), sid.OutputText))
                {
                    name = sid.OutputText;
                    file_name.Text = name;
                }else
                    MessageBox.Show("Něco se pokazilo, asi nemáte práva");
            }
        }

        private void deleteFolder_btn_Click(object sender, EventArgs e)
        {
            if (FTPHelper.Instance.DeleteFolder(new Uri(uri.ToString() + "/" + name)))
                Dispose();
            else
                MessageBox.Show("Něco se nepovedlo. \nMožná nemáte práva nebo není adresář prázdný.");
        }
    }
}
