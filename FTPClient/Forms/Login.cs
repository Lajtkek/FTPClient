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
            LoadingOverlay lo = new LoadingOverlay();
            Controls.Add(lo);
            lo.BringToFront();
            FTPHelper.Instance.SetCredentials(server_txt.Text, username_txt.Text, password_txt.Text);
            
            var directoryDetails = await FTPHelper.Instance.GetDirectoryDetails(new Uri("ftp://" + server_txt.Text + "/"));
            if (directoryDetails != null)
            {
                Client c = new Client(directoryDetails);
                Hide();
                c.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Wrong creds");
            }
            lo.Dispose();
        }
    }
}
