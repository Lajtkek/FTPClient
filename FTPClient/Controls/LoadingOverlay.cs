using System;
using System.Windows.Forms;

namespace FTPClient.Controls
{
    public partial class LoadingOverlay : UserControl
    {
        public LoadingOverlay(bool progressBar = false)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            progressBar1.Visible = progressBar;
        }

        public void SetProgress(int percentage)
        {
            progressBar1.Value = Math.Min(percentage,100);
        }
    }
}
