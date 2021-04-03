using FTPClient.Common;
using FTPClient.Controls;
using FTPClient.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTPClient
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void login_btn_Click(object sender, EventArgs e)
        {
            LoadingOverlay loadingOverlay = new LoadingOverlay();
            Controls.Add(loadingOverlay);
            loadingOverlay.BringToFront();
            FTPHelper.Instance.SetCredentials(server_txt.Text, username_txt.Text, password_txt.Text);
            
            var directoryDetails = await FTPHelper.Instance.GetDirectoryDetails(new Uri("ftp://" + server_txt.Text));
            if (directoryDetails != null)
            {
                Client c = new Client();
                Hide();
                c.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Špatné příhlašovací údaje");
            }

            loadingOverlay.Dispose();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            password_txt.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
}
