namespace PlayMusic.ChildForm
{
    partial class RecentPlays
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
            this.panel_Playlist = new System.Windows.Forms.Panel();
            this.panel_ContainPlaylist = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_PlaylistTitle = new System.Windows.Forms.Label();
            this.panel_Song = new System.Windows.Forms.Panel();
            this.panel_ContainSong = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_SongTitle = new System.Windows.Forms.Panel();
            this.btn_PlayShuffle = new System.Windows.Forms.Button();
            this.lbl_SongTitle = new System.Windows.Forms.Label();
            this.panel_Playlist.SuspendLayout();
            this.panel_Song.SuspendLayout();
            this.panel_SongTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Playlist
            // 
            this.panel_Playlist.BackColor = System.Drawing.Color.White;
            this.panel_Playlist.Controls.Add(this.panel_ContainPlaylist);
            this.panel_Playlist.Controls.Add(this.lbl_PlaylistTitle);
            this.panel_Playlist.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Playlist.Location = new System.Drawing.Point(20, 0);
            this.panel_Playlist.Name = "panel_Playlist";
            this.panel_Playlist.Size = new System.Drawing.Size(664, 240);
            this.panel_Playlist.TabIndex = 0;
            // 
            // panel_ContainPlaylist
            // 
            this.panel_ContainPlaylist.AutoScroll = true;
            this.panel_ContainPlaylist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ContainPlaylist.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panel_ContainPlaylist.Location = new System.Drawing.Point(0, 24);
            this.panel_ContainPlaylist.Name = "panel_ContainPlaylist";
            this.panel_ContainPlaylist.Size = new System.Drawing.Size(664, 216);
            this.panel_ContainPlaylist.TabIndex = 1;
            // 
            // lbl_PlaylistTitle
            // 
            this.lbl_PlaylistTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_PlaylistTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PlaylistTitle.ForeColor = System.Drawing.Color.Black;
            this.lbl_PlaylistTitle.Location = new System.Drawing.Point(0, 0);
            this.lbl_PlaylistTitle.Name = "lbl_PlaylistTitle";
            this.lbl_PlaylistTitle.Size = new System.Drawing.Size(664, 24);
            this.lbl_PlaylistTitle.TabIndex = 0;
            this.lbl_PlaylistTitle.Text = "Danh sách phát gần đây";
            this.lbl_PlaylistTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_PlaylistTitle.Click += new System.EventHandler(this.lbl_PlaylistTitle_Click);
            // 
            // panel_Song
            // 
            this.panel_Song.BackColor = System.Drawing.Color.White;
            this.panel_Song.Controls.Add(this.panel_ContainSong);
            this.panel_Song.Controls.Add(this.panel_SongTitle);
            this.panel_Song.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Song.Location = new System.Drawing.Point(20, 240);
            this.panel_Song.Name = "panel_Song";
            this.panel_Song.Size = new System.Drawing.Size(664, 241);
            this.panel_Song.TabIndex = 1;
            // 
            // panel_ContainSong
            // 
            this.panel_ContainSong.AutoScroll = true;
            this.panel_ContainSong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ContainSong.Location = new System.Drawing.Point(0, 24);
            this.panel_ContainSong.Name = "panel_ContainSong";
            this.panel_ContainSong.Size = new System.Drawing.Size(664, 217);
            this.panel_ContainSong.TabIndex = 4;
            // 
            // panel_SongTitle
            // 
            this.panel_SongTitle.Controls.Add(this.btn_PlayShuffle);
            this.panel_SongTitle.Controls.Add(this.lbl_SongTitle);
            this.panel_SongTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_SongTitle.Location = new System.Drawing.Point(0, 0);
            this.panel_SongTitle.Name = "panel_SongTitle";
            this.panel_SongTitle.Size = new System.Drawing.Size(664, 24);
            this.panel_SongTitle.TabIndex = 3;
            // 
            // btn_PlayShuffle
            // 
            this.btn_PlayShuffle.BackgroundImage = global::PlayMusic.Properties.Resources.shuffle_gray;
            this.btn_PlayShuffle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_PlayShuffle.FlatAppearance.BorderSize = 0;
            this.btn_PlayShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PlayShuffle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PlayShuffle.Location = new System.Drawing.Point(121, 4);
            this.btn_PlayShuffle.Name = "btn_PlayShuffle";
            this.btn_PlayShuffle.Size = new System.Drawing.Size(20, 20);
            this.btn_PlayShuffle.TabIndex = 2;
            this.btn_PlayShuffle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PlayShuffle.UseVisualStyleBackColor = true;
            this.btn_PlayShuffle.Click += new System.EventHandler(this.btn_PlayShuffle_Click);
            this.btn_PlayShuffle.MouseLeave += new System.EventHandler(this.btn_PlayShuffle_MouseLeave);
            this.btn_PlayShuffle.MouseHover += new System.EventHandler(this.btn_PlayShuffle_MouseHover);
            // 
            // lbl_SongTitle
            // 
            this.lbl_SongTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_SongTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SongTitle.ForeColor = System.Drawing.Color.Black;
            this.lbl_SongTitle.Location = new System.Drawing.Point(0, 0);
            this.lbl_SongTitle.Name = "lbl_SongTitle";
            this.lbl_SongTitle.Size = new System.Drawing.Size(115, 24);
            this.lbl_SongTitle.TabIndex = 1;
            this.lbl_SongTitle.Text = "Bài hát gần đây";
            this.lbl_SongTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_SongTitle.Click += new System.EventHandler(this.lbl_SongTitle_Click);
            // 
            // RecentPlays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 481);
            this.Controls.Add(this.panel_Song);
            this.Controls.Add(this.panel_Playlist);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "RecentPlays";
            this.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecentPlays";
            this.Load += new System.EventHandler(this.RecentPlays_Load);
            this.panel_Playlist.ResumeLayout(false);
            this.panel_Song.ResumeLayout(false);
            this.panel_SongTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Playlist;
        private System.Windows.Forms.Label lbl_PlaylistTitle;
        private System.Windows.Forms.Panel panel_Song;
        private System.Windows.Forms.Label lbl_SongTitle;
        private System.Windows.Forms.Panel panel_SongTitle;
        private System.Windows.Forms.Button btn_PlayShuffle;
        private System.Windows.Forms.FlowLayoutPanel panel_ContainPlaylist;
        private System.Windows.Forms.FlowLayoutPanel panel_ContainSong;
    }
}