
namespace FTPClient.Controls
{
    partial class DirectoryView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dirCreate_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.uploadFile_btn = new System.Windows.Forms.Button();
            this.prevDirectory_btn = new System.Windows.Forms.Button();
            this.DirectoryItemHolder = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.dirCreate_btn);
            this.panel1.Controls.Add(this.back_btn);
            this.panel1.Controls.Add(this.uploadFile_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(431, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 409);
            this.panel1.TabIndex = 0;
            // 
            // dirCreate_btn
            // 
            this.dirCreate_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dirCreate_btn.Location = new System.Drawing.Point(6, 361);
            this.dirCreate_btn.Name = "dirCreate_btn";
            this.dirCreate_btn.Size = new System.Drawing.Size(133, 42);
            this.dirCreate_btn.TabIndex = 1;
            this.dirCreate_btn.Text = "Vytvořit adresář";
            this.dirCreate_btn.UseVisualStyleBackColor = true;
            this.dirCreate_btn.Click += new System.EventHandler(this.dirCreate_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(6, 3);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(133, 23);
            this.back_btn.TabIndex = 0;
            this.back_btn.Text = "O krok dozadu";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // uploadFile_btn
            // 
            this.uploadFile_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uploadFile_btn.Location = new System.Drawing.Point(6, 313);
            this.uploadFile_btn.Name = "uploadFile_btn";
            this.uploadFile_btn.Size = new System.Drawing.Size(133, 42);
            this.uploadFile_btn.TabIndex = 0;
            this.uploadFile_btn.Text = "Nahrát soubor";
            this.uploadFile_btn.UseVisualStyleBackColor = true;
            this.uploadFile_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // prevDirectory_btn
            // 
            this.prevDirectory_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.prevDirectory_btn.Location = new System.Drawing.Point(382, 5);
            this.prevDirectory_btn.Name = "prevDirectory_btn";
            this.prevDirectory_btn.Size = new System.Drawing.Size(43, 23);
            this.prevDirectory_btn.TabIndex = 2;
            this.prevDirectory_btn.Text = "<<<";
            this.prevDirectory_btn.UseVisualStyleBackColor = true;
            this.prevDirectory_btn.Click += new System.EventHandler(this.prevDirectory_btn_Click);
            // 
            // DirectoryItemHolder
            // 
            this.DirectoryItemHolder.AutoScroll = true;
            this.DirectoryItemHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DirectoryItemHolder.Location = new System.Drawing.Point(0, 0);
            this.DirectoryItemHolder.Name = "DirectoryItemHolder";
            this.DirectoryItemHolder.Size = new System.Drawing.Size(431, 377);
            this.DirectoryItemHolder.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.prevDirectory_btn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 377);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(431, 32);
            this.panel2.TabIndex = 2;
            // 
            // DirectoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DirectoryItemHolder);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DirectoryView";
            this.Size = new System.Drawing.Size(573, 409);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel DirectoryItemHolder;
        private System.Windows.Forms.Button uploadFile_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button dirCreate_btn;
        private System.Windows.Forms.Button prevDirectory_btn;
    }
}
