using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTPClient.Dialog
{
    public partial class SingleInputDialog : Form
    {
        public string OutputText => textBox1.Text;
        public SingleInputDialog(string title, string confirmText)
        {
            InitializeComponent();
            title_lbl.Text = title;
            confitm_btn.Text = confirmText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {

            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
