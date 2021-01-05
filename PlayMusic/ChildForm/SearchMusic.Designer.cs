namespace PlayMusic.ChildForm
{
    partial class SearchMusic
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
            this.lbl_TitleSearch = new System.Windows.Forms.Label();
            this.txb_Key = new System.Windows.Forms.TextBox();
            this.panel_SearchBar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Search = new System.Windows.Forms.Button();
            this.panel_SearchResult = new System.Windows.Forms.Panel();
            this.panel_Result = new System.Windows.Forms.Panel();
            this.panel_ContainResult = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_NoResult = new System.Windows.Forms.Panel();
            this.lbl_NoResult = new System.Windows.Forms.Label();
            this.panel_MenuSearch = new System.Windows.Forms.Panel();
            this.panel_MenuAlbum = new System.Windows.Forms.Panel();
            this.pic_Album = new System.Windows.Forms.PictureBox();
            this.btn_Album = new System.Windows.Forms.Button();
            this.panel_MenuArtist = new System.Windows.Forms.Panel();
            this.btn_Artist = new System.Windows.Forms.Button();
            this.pic_Artist = new System.Windows.Forms.PictureBox();
            this.panel_MenuPlaylist = new System.Windows.Forms.Panel();
            this.btn_Playlist = new System.Windows.Forms.Button();
            this.pic_Playlist = new System.Windows.Forms.PictureBox();
            this.panel_MenuSong = new System.Windows.Forms.Panel();
            this.btn_Song = new System.Windows.Forms.Button();
            this.pic_Song = new System.Windows.Forms.PictureBox();
            this.panel_SearchBar.SuspendLayout();
            this.panel_SearchResult.SuspendLayout();
            this.panel_Result.SuspendLayout();
            this.panel_NoResult.SuspendLayout();
            this.panel_MenuSearch.SuspendLayout();
            this.panel_MenuAlbum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Album)).BeginInit();
            this.panel_MenuArtist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Artist)).BeginInit();
            this.panel_MenuPlaylist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Playlist)).BeginInit();
            this.panel_MenuSong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Song)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TitleSearch
            // 
            this.lbl_TitleSearch.AutoSize = true;
            this.lbl_TitleSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitleSearch.ForeColor = System.Drawing.Color.Black;
            this.lbl_TitleSearch.Location = new System.Drawing.Point(3, 23);
            this.lbl_TitleSearch.Name = "lbl_TitleSearch";
            this.lbl_TitleSearch.Size = new System.Drawing.Size(63, 17);
            this.lbl_TitleSearch.TabIndex = 0;
            this.lbl_TitleSearch.Text = "Tìm kiếm";
            // 
            // txb_Key
            // 
            this.txb_Key.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_Key.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Key.ForeColor = System.Drawing.Color.Gray;
            this.txb_Key.Location = new System.Drawing.Point(69, 22);
            this.txb_Key.Name = "txb_Key";
            this.txb_Key.Size = new System.Drawing.Size(200, 18);
            this.txb_Key.TabIndex = 1;
            this.txb_Key.Text = "Nhập từ khóa";
            this.txb_Key.Click += new System.EventHandler(this.txb_Key_Click);
            this.txb_Key.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_Key_KeyDown);
            // 
            // panel_SearchBar
            // 
            this.panel_SearchBar.Controls.Add(this.panel1);
            this.panel_SearchBar.Controls.Add(this.txb_Key);
            this.panel_SearchBar.Controls.Add(this.btn_Search);
            this.panel_SearchBar.Controls.Add(this.lbl_TitleSearch);
            this.panel_SearchBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_SearchBar.Location = new System.Drawing.Point(20, 0);
            this.panel_SearchBar.Name = "panel_SearchBar";
            this.panel_SearchBar.Size = new System.Drawing.Size(644, 60);
            this.panel_SearchBar.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(69, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 0;
            // 
            // btn_Search
            // 
            this.btn_Search.BackgroundImage = global::PlayMusic.Properties.Resources.search_blue;
            this.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Location = new System.Drawing.Point(275, 20);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(25, 25);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // panel_SearchResult
            // 
            this.panel_SearchResult.Controls.Add(this.panel_Result);
            this.panel_SearchResult.Controls.Add(this.panel_MenuSearch);
            this.panel_SearchResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_SearchResult.Location = new System.Drawing.Point(20, 60);
            this.panel_SearchResult.Name = "panel_SearchResult";
            this.panel_SearchResult.Size = new System.Drawing.Size(644, 421);
            this.panel_SearchResult.TabIndex = 4;
            // 
            // panel_Result
            // 
            this.panel_Result.Controls.Add(this.panel_ContainResult);
            this.panel_Result.Controls.Add(this.panel_NoResult);
            this.panel_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Result.Location = new System.Drawing.Point(0, 50);
            this.panel_Result.Name = "panel_Result";
            this.panel_Result.Size = new System.Drawing.Size(644, 371);
            this.panel_Result.TabIndex = 1;
            // 
            // panel_ContainResult
            // 
            this.panel_ContainResult.AutoScroll = true;
            this.panel_ContainResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ContainResult.Location = new System.Drawing.Point(0, 40);
            this.panel_ContainResult.Name = "panel_ContainResult";
            this.panel_ContainResult.Size = new System.Drawing.Size(644, 331);
            this.panel_ContainResult.TabIndex = 1;
            // 
            // panel_NoResult
            // 
            this.panel_NoResult.Controls.Add(this.lbl_NoResult);
            this.panel_NoResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_NoResult.Location = new System.Drawing.Point(0, 0);
            this.panel_NoResult.Name = "panel_NoResult";
            this.panel_NoResult.Size = new System.Drawing.Size(644, 40);
            this.panel_NoResult.TabIndex = 0;
            // 
            // lbl_NoResult
            // 
            this.lbl_NoResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_NoResult.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NoResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_NoResult.Location = new System.Drawing.Point(0, 0);
            this.lbl_NoResult.Name = "lbl_NoResult";
            this.lbl_NoResult.Size = new System.Drawing.Size(644, 40);
            this.lbl_NoResult.TabIndex = 0;
            this.lbl_NoResult.Text = "Nhập từ khóa để tìm kiếm";
            this.lbl_NoResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_MenuSearch
            // 
            this.panel_MenuSearch.Controls.Add(this.panel_MenuAlbum);
            this.panel_MenuSearch.Controls.Add(this.panel_MenuArtist);
            this.panel_MenuSearch.Controls.Add(this.panel_MenuPlaylist);
            this.panel_MenuSearch.Controls.Add(this.panel_MenuSong);
            this.panel_MenuSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_MenuSearch.Location = new System.Drawing.Point(0, 0);
            this.panel_MenuSearch.Name = "panel_MenuSearch";
            this.panel_MenuSearch.Size = new System.Drawing.Size(644, 50);
            this.panel_MenuSearch.TabIndex = 0;
            // 
            // panel_MenuAlbum
            // 
            this.panel_MenuAlbum.Controls.Add(this.pic_Album);
            this.panel_MenuAlbum.Controls.Add(this.btn_Album);
            this.panel_MenuAlbum.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_MenuAlbum.Location = new System.Drawing.Point(432, 0);
            this.panel_MenuAlbum.Name = "panel_MenuAlbum";
            this.panel_MenuAlbum.Size = new System.Drawing.Size(119, 50);
            this.panel_MenuAlbum.TabIndex = 1;
            this.panel_MenuAlbum.Click += new System.EventHandler(this.btn_Album_Click);
            // 
            // pic_Album
            // 
            this.pic_Album.Image = global::PlayMusic.Properties.Resources.album_gray;
            this.pic_Album.Location = new System.Drawing.Point(15, 12);
            this.pic_Album.Name = "pic_Album";
            this.pic_Album.Size = new System.Drawing.Size(25, 25);
            this.pic_Album.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Album.TabIndex = 1;
            this.pic_Album.TabStop = false;
            this.pic_Album.Click += new System.EventHandler(this.btn_Album_Click);
            // 
            // btn_Album
            // 
            this.btn_Album.FlatAppearance.BorderSize = 0;
            this.btn_Album.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Album.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Album.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Album.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Album.ForeColor = System.Drawing.Color.Gray;
            this.btn_Album.Location = new System.Drawing.Point(46, 9);
            this.btn_Album.Name = "btn_Album";
            this.btn_Album.Size = new System.Drawing.Size(65, 32);
            this.btn_Album.TabIndex = 0;
            this.btn_Album.Text = "Album";
            this.btn_Album.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Album.UseVisualStyleBackColor = true;
            this.btn_Album.Click += new System.EventHandler(this.btn_Album_Click);
            // 
            // panel_MenuArtist
            // 
            this.panel_MenuArtist.Controls.Add(this.btn_Artist);
            this.panel_MenuArtist.Controls.Add(this.pic_Artist);
            this.panel_MenuArtist.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_MenuArtist.Location = new System.Drawing.Point(305, 0);
            this.panel_MenuArtist.Name = "panel_MenuArtist";
            this.panel_MenuArtist.Size = new System.Drawing.Size(127, 50);
            this.panel_MenuArtist.TabIndex = 1;
            this.panel_MenuArtist.Click += new System.EventHandler(this.btn_Artist_Click);
            // 
            // btn_Artist
            // 
            this.btn_Artist.FlatAppearance.BorderSize = 0;
            this.btn_Artist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Artist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Artist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Artist.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Artist.ForeColor = System.Drawing.Color.Gray;
            this.btn_Artist.Location = new System.Drawing.Point(46, 9);
            this.btn_Artist.Name = "btn_Artist";
            this.btn_Artist.Size = new System.Drawing.Size(72, 32);
            this.btn_Artist.TabIndex = 0;
            this.btn_Artist.Text = "Nghệ sĩ";
            this.btn_Artist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Artist.UseVisualStyleBackColor = true;
            this.btn_Artist.Click += new System.EventHandler(this.btn_Artist_Click);
            // 
            // pic_Artist
            // 
            this.pic_Artist.Image = global::PlayMusic.Properties.Resources.artist_gray;
            this.pic_Artist.Location = new System.Drawing.Point(15, 12);
            this.pic_Artist.Name = "pic_Artist";
            this.pic_Artist.Size = new System.Drawing.Size(25, 25);
            this.pic_Artist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Artist.TabIndex = 1;
            this.pic_Artist.TabStop = false;
            this.pic_Artist.Click += new System.EventHandler(this.btn_Artist_Click);
            // 
            // panel_MenuPlaylist
            // 
            this.panel_MenuPlaylist.Controls.Add(this.btn_Playlist);
            this.panel_MenuPlaylist.Controls.Add(this.pic_Playlist);
            this.panel_MenuPlaylist.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_MenuPlaylist.Location = new System.Drawing.Point(125, 0);
            this.panel_MenuPlaylist.Name = "panel_MenuPlaylist";
            this.panel_MenuPlaylist.Size = new System.Drawing.Size(180, 50);
            this.panel_MenuPlaylist.TabIndex = 1;
            this.panel_MenuPlaylist.Click += new System.EventHandler(this.btn_Playlist_Click);
            // 
            // btn_Playlist
            // 
            this.btn_Playlist.FlatAppearance.BorderSize = 0;
            this.btn_Playlist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Playlist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Playlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Playlist.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Playlist.ForeColor = System.Drawing.Color.Gray;
            this.btn_Playlist.Location = new System.Drawing.Point(46, 9);
            this.btn_Playlist.Name = "btn_Playlist";
            this.btn_Playlist.Size = new System.Drawing.Size(124, 32);
            this.btn_Playlist.TabIndex = 0;
            this.btn_Playlist.Text = "Danh sách phát";
            this.btn_Playlist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Playlist.UseVisualStyleBackColor = true;
            this.btn_Playlist.Click += new System.EventHandler(this.btn_Playlist_Click);
            // 
            // pic_Playlist
            // 
            this.pic_Playlist.Image = global::PlayMusic.Properties.Resources.playlist_gray;
            this.pic_Playlist.Location = new System.Drawing.Point(15, 12);
            this.pic_Playlist.Name = "pic_Playlist";
            this.pic_Playlist.Size = new System.Drawing.Size(25, 25);
            this.pic_Playlist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Playlist.TabIndex = 1;
            this.pic_Playlist.TabStop = false;
            this.pic_Playlist.Click += new System.EventHandler(this.btn_Playlist_Click);
            // 
            // panel_MenuSong
            // 
            this.panel_MenuSong.Controls.Add(this.btn_Song);
            this.panel_MenuSong.Controls.Add(this.pic_Song);
            this.panel_MenuSong.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_MenuSong.Location = new System.Drawing.Point(0, 0);
            this.panel_MenuSong.Name = "panel_MenuSong";
            this.panel_MenuSong.Size = new System.Drawing.Size(125, 50);
            this.panel_MenuSong.TabIndex = 0;
            this.panel_MenuSong.Click += new System.EventHandler(this.btn_Song_Click);
            // 
            // btn_Song
            // 
            this.btn_Song.FlatAppearance.BorderSize = 0;
            this.btn_Song.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Song.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Song.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Song.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Song.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_Song.Location = new System.Drawing.Point(46, 9);
            this.btn_Song.Name = "btn_Song";
            this.btn_Song.Size = new System.Drawing.Size(72, 32);
            this.btn_Song.TabIndex = 0;
            this.btn_Song.Text = "Bài hát";
            this.btn_Song.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Song.UseVisualStyleBackColor = true;
            this.btn_Song.Click += new System.EventHandler(this.btn_Song_Click);
            // 
            // pic_Song
            // 
            this.pic_Song.Image = global::PlayMusic.Properties.Resources.music_blue1;
            this.pic_Song.Location = new System.Drawing.Point(15, 12);
            this.pic_Song.Name = "pic_Song";
            this.pic_Song.Size = new System.Drawing.Size(25, 25);
            this.pic_Song.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Song.TabIndex = 1;
            this.pic_Song.TabStop = false;
            this.pic_Song.Click += new System.EventHandler(this.btn_Song_Click);
            // 
            // SearchMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 481);
            this.Controls.Add(this.panel_SearchResult);
            this.Controls.Add(this.panel_SearchBar);
            this.Name = "SearchMusic";
            this.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SearchMusic";
            this.panel_SearchBar.ResumeLayout(false);
            this.panel_SearchBar.PerformLayout();
            this.panel_SearchResult.ResumeLayout(false);
            this.panel_Result.ResumeLayout(false);
            this.panel_NoResult.ResumeLayout(false);
            this.panel_MenuSearch.ResumeLayout(false);
            this.panel_MenuAlbum.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Album)).EndInit();
            this.panel_MenuArtist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Artist)).EndInit();
            this.panel_MenuPlaylist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Playlist)).EndInit();
            this.panel_MenuSong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Song)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_TitleSearch;
        private System.Windows.Forms.TextBox txb_Key;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Panel panel_SearchBar;
        private System.Windows.Forms.Panel panel_SearchResult;
        private System.Windows.Forms.Panel panel_Result;
        private System.Windows.Forms.Panel panel_MenuSearch;
        private System.Windows.Forms.PictureBox pic_Album;
        private System.Windows.Forms.PictureBox pic_Artist;
        private System.Windows.Forms.PictureBox pic_Playlist;
        private System.Windows.Forms.PictureBox pic_Song;
        private System.Windows.Forms.Button btn_Album;
        private System.Windows.Forms.Button btn_Artist;
        private System.Windows.Forms.Button btn_Playlist;
        private System.Windows.Forms.Button btn_Song;
        private System.Windows.Forms.Panel panel_NoResult;
        private System.Windows.Forms.Label lbl_NoResult;
        private System.Windows.Forms.Panel panel_MenuAlbum;
        private System.Windows.Forms.Panel panel_MenuArtist;
        private System.Windows.Forms.Panel panel_MenuPlaylist;
        private System.Windows.Forms.Panel panel_MenuSong;
        private System.Windows.Forms.FlowLayoutPanel panel_ContainResult;
        private System.Windows.Forms.Panel panel1;
    }
}