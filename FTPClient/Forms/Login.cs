using FTPClient.Common;
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

        private void login_btn_Click(object sender, EventArgs e)
        {
            FTPHelper.Instance.SetCredentials(server_txt.Text, username_txt.Text, password_txt.Text);
            var directoryDetails = FTPHelper.Instance.GetDirectoryDetails(new Uri("ftp://" + server_txt.Text + "/"));
            if (directoryDetails.Count > 0)
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
        }
    }
}
