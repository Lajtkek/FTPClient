
namespace FTPClient.Controls
{
    partial class DirectoryItem
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
            this.file_name = new System.Windows.Forms.Label();
            this.file_size = new System.Windows.Forms.Label();
            this.download_btn = new System.Windows.Forms.Button();
            this.rename_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.fileMenu = new System.Windows.Forms.Panel();
            this.folder_menu = new System.Windows.Forms.Panel();
            this.openDir_btn = new System.Windows.Forms.Button();
            this.deleteFolder_btn = new System.Windows.Forms.Button();
            this.renameDir_btn = new System.Windows.Forms.Button();
            this.folderIco = new System.Windows.Forms.PictureBox();
            this.fileIco = new System.Windows.Forms.PictureBox();
            this.fileMenu.SuspendLayout();
            this.folder_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folderIco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileIco)).BeginInit();
            this.SuspendLayout();
            // 
            // file_name
            // 
            this.file_name.Location = new System.Drawing.Point(36, 0);
            this.file_name.Name = "file_name";
            this.file_name.Size = new System.Drawing.Size(124, 30);
            this.file_name.TabIndex = 0;
            this.file_name.Text = "name";
            this.file_name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // file_size
            // 
            this.file_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file_size.Location = new System.Drawing.Point(166, 0);
            this.file_size.Name = "file_size";
            this.file_size.Size = new System.Drawing.Size(102, 30);
            this.file_size.TabIndex = 1;
            this.file_size.Text = "( 0b )";
            this.file_size.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // download_btn
            // 
            this.download_btn.Location = new System.Drawing.Point(3, 3);
            this.download_btn.Name = "download_btn";
            this.download_btn.Size = new System.Drawing.Size(75, 23);
            this.download_btn.TabIndex = 3;
            this.download_btn.Text = "Stáhnout";
            this.download_btn.UseVisualStyleBackColor = true;
            this.download_btn.Click += new System.EventHandler(this.download_btn_Click);
            // 
            // rename_btn
            // 
            this.rename_btn.Location = new System.Drawing.Point(84, 3);
            this.rename_btn.Name = "rename_btn";
            this.rename_btn.Size = new System.Drawing.Size(75, 23);
            this.rename_btn.TabIndex = 4;
            this.rename_btn.Text = "Přejmenovat";
            this.rename_btn.UseVisualStyleBackColor = true;
            this.rename_btn.Click += new System.EventHandler(this.rename_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(165, 3);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 5;
            this.delete_btn.Text = "Smazat";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // fileMenu
            // 
            this.fileMenu.BackColor = System.Drawing.Color.Transparent;
            this.fileMenu.Controls.Add(this.delete_btn);
            this.fileMenu.Controls.Add(this.download_btn);
            this.fileMenu.Controls.Add(this.rename_btn);
            this.fileMenu.Location = new System.Drawing.Point(272, 33);
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(250, 30);
            this.fileMenu.TabIndex = 6;
            // 
            // folder_menu
            // 
            this.folder_menu.BackColor = System.Drawing.Color.Transparent;
            this.folder_menu.Controls.Add(this.openDir_btn);
            this.folder_menu.Controls.Add(this.deleteFolder_btn);
            this.folder_menu.Controls.Add(this.renameDir_btn);
            this.folder_menu.Location = new System.Drawing.Point(16, 33);
            this.folder_menu.Name = "folder_menu";
            this.folder_menu.Size = new System.Drawing.Size(250, 30);
            this.folder_menu.TabIndex = 7;
            // 
            // openDir_btn
            // 
            this.openDir_btn.Location = new System.Drawing.Point(3, 3);
            this.openDir_btn.Name = "openDir_btn";
            this.openDir_btn.Size = new System.Drawing.Size(75, 23);
            this.openDir_btn.TabIndex = 6;
            this.openDir_btn.Text = "Otevřít";
            this.openDir_btn.UseVisualStyleBackColor = true;
            this.openDir_btn.Click += new System.EventHandler(this.openDir_btn_Click);
            // 
            // deleteFolder_btn
            // 
            this.deleteFolder_btn.Location = new System.Drawing.Point(165, 3);
            this.deleteFolder_btn.Name = "deleteFolder_btn";
            this.deleteFolder_btn.Size = new System.Drawing.Size(75, 23);
            this.deleteFolder_btn.TabIndex = 5;
            this.deleteFolder_btn.Text = "Smazat";
            this.deleteFolder_btn.UseVisualStyleBackColor = true;
            this.deleteFolder_btn.Click += new System.EventHandler(this.deleteFolder_btn_Click);
            // 
            // renameDir_btn
            // 
            this.renameDir_btn.Location = new System.Drawing.Point(84, 3);
            this.renameDir_btn.Name = "renameDir_btn";
            this.renameDir_btn.Size = new System.Drawing.Size(75, 23);
            this.renameDir_btn.TabIndex = 4;
            this.renameDir_btn.Text = "Přejmenovat";
            this.renameDir_btn.UseVisualStyleBackColor = true;
            this.renameDir_btn.Click += new System.EventHandler(this.renameDir_btn_Click);
            // 
            // folderIco
            // 
            this.folderIco.BackgroundImage = global::FTPClient.Properties.Resources.File;
            this.folderIco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.folderIco.Location = new System.Drawing.Point(1, 1);
            this.folderIco.Name = "folderIco";
            this.folderIco.Size = new System.Drawing.Size(32, 32);
            this.folderIco.TabIndex = 9;
            this.folderIco.TabStop = false;
            // 
            // fileIco
            // 
            this.fileIco.BackgroundImage = global::FTPClient.Properties.Resources.Folder;
            this.fileIco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fileIco.Location = new System.Drawing.Point(1, 1);
            this.fileIco.Name = "fileIco";
            this.fileIco.Size = new System.Drawing.Size(32, 32);
            this.fileIco.TabIndex = 8;
            this.fileIco.TabStop = false;
            // 
            // DirectoryItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.folderIco);
            this.Controls.Add(this.fileIco);
            this.Controls.Add(this.folder_menu);
            this.Controls.Add(this.fileMenu);
            this.Controls.Add(this.file_size);
            this.Controls.Add(this.file_name);
            this.Name = "DirectoryItem";
            this.Size = new System.Drawing.Size(525, 70);
            this.fileMenu.ResumeLayout(false);
            this.folder_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.folderIco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileIco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label file_name;
        private System.Windows.Forms.Label file_size;
        private System.Windows.Forms.Button download_btn;
        private System.Windows.Forms.Button rename_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Panel fileMenu;
        private System.Windows.Forms.Panel folder_menu;
        private System.Windows.Forms.Button openDir_btn;
        private System.Windows.Forms.Button deleteFolder_btn;
        private System.Windows.Forms.Button renameDir_btn;
        private System.Windows.Forms.PictureBox fileIco;
        private System.Windows.Forms.PictureBox folderIco;
    }
}
