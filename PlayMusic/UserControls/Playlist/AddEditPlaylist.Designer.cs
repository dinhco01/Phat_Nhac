namespace PlayMusic.UserControls.Playlist
{
    partial class AddEditPlaylist
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txb_NewName = new System.Windows.Forms.TextBox();
            this.pic_Playlist = new System.Windows.Forms.PictureBox();
            this.panel_Title = new System.Windows.Forms.Panel();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.panel_ContainSong = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Playlist)).BeginInit();
            this.panel_Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(11, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(39, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 1);
            this.panel2.TabIndex = 5;
            // 
            // txb_NewName
            // 
            this.txb_NewName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_NewName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_NewName.ForeColor = System.Drawing.Color.Gray;
            this.txb_NewName.Location = new System.Drawing.Point(39, 12);
            this.txb_NewName.Name = "txb_NewName";
            this.txb_NewName.Size = new System.Drawing.Size(291, 18);
            this.txb_NewName.TabIndex = 4;
            this.txb_NewName.Text = "Tên danh sách phát";
            this.txb_NewName.Click += new System.EventHandler(this.txb_NewName_Click);
            this.txb_NewName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_NewName_KeyDown);
            // 
            // pic_Playlist
            // 
            this.pic_Playlist.Image = global::PlayMusic.Properties.Resources.playlist_blue1;
            this.pic_Playlist.Location = new System.Drawing.Point(3, 3);
            this.pic_Playlist.Name = "pic_Playlist";
            this.pic_Playlist.Size = new System.Drawing.Size(30, 30);
            this.pic_Playlist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Playlist.TabIndex = 7;
            this.pic_Playlist.TabStop = false;
            // 
            // panel_Title
            // 
            this.panel_Title.Controls.Add(this.btn_OK);
            this.panel_Title.Controls.Add(this.btn_Cancel);
            this.panel_Title.Controls.Add(this.pic_Playlist);
            this.panel_Title.Controls.Add(this.txb_NewName);
            this.panel_Title.Controls.Add(this.panel2);
            this.panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(414, 36);
            this.panel_Title.TabIndex = 8;
            // 
            // btn_OK
            // 
            this.btn_OK.BackgroundImage = global::PlayMusic.Properties.Resources.ok_blue;
            this.btn_OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_OK.FlatAppearance.BorderSize = 0;
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Location = new System.Drawing.Point(372, 2);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(30, 31);
            this.btn_OK.TabIndex = 8;
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackgroundImage = global::PlayMusic.Properties.Resources.cancel_red;
            this.btn_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Location = new System.Drawing.Point(336, 2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(30, 31);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // panel_ContainSong
            // 
            this.panel_ContainSong.AutoScroll = true;
            this.panel_ContainSong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ContainSong.Location = new System.Drawing.Point(0, 36);
            this.panel_ContainSong.Name = "panel_ContainSong";
            this.panel_ContainSong.Size = new System.Drawing.Size(414, 514);
            this.panel_ContainSong.TabIndex = 10;
            // 
            // AddEditPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(414, 550);
            this.Controls.Add(this.panel_ContainSong);
            this.Controls.Add(this.panel_Title);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditPlaylist";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm danh sách phát";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEditPlaylist_FormClosing);
            this.Load += new System.EventHandler(this.RenamePlaylist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Playlist)).EndInit();
            this.panel_Title.ResumeLayout(false);
            this.panel_Title.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txb_NewName;
        private System.Windows.Forms.PictureBox pic_Playlist;
        private System.Windows.Forms.Panel panel_Title;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.FlowLayoutPanel panel_ContainSong;
    }
}